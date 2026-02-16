using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Main : Form
    {
        private readonly Calculadora _calculadora = new Calculadora();

        private bool _novoNumero = true;
        private Button[] _buttons;

        public Main()
        {
            InitializeComponent();

            _buttons = new[]
            {
                btnPorcent, btnCE, btnC, btnApagar,
                btnInverso, btnAoQuadrado, btnRaizQuadrada, btnDividir,
                btn7, btn8, btn9, btnMultiplicar,
                btn4, btn5, btn6, btnSubtrair,
                btn1, btn2, btn3, btnSomar,
                btnInverterSinal, btn0, btnSeparadorDecimal, btnIgual
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InicializarTela();
        }

        private void InicializarTela()
        {
            Utils.EstilizarButtons(_buttons);
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (lblDisplayTop.Text.Contains("="))
            {
                lblDisplayTop.Text = string.Empty;
                lblDisplay.Text    = "0";
                _novoNumero        = true;
            }

            if (lblDisplay.Text == "0" || _novoNumero)
            {
                lblDisplay.Text = btn.Text;
                _novoNumero     = false;
            }
            else
            {
                lblDisplay.Text += btn.Text;
            }

            AtualizarDisplayFormatado();
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (lblDisplayTop.Text.Contains("="))
                lblDisplayTop.Text = string.Empty;

            if (lblDisplay.Text != "0")
            {
                lblDisplayTop.Text += $"{lblDisplay.Text} {btn.Text} ";
                _novoNumero = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplay.Text    = "0";
            lblDisplayTop.Text = string.Empty;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text.Length > 1
                ? lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1)
                : "0";
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            var valor     = decimal.Parse(lblDisplay.Text.Replace(",", "."));
            var resultado = _calculadora.Inverso(valor);

            lblDisplayTop.Text += $"1 / ( {lblDisplay.Text} ) ";
            lblDisplay.Text     = resultado.ToString().Replace(".", ",");
        }

        private void btnAoQuadrado_Click(object sender, EventArgs e)
        {
            var valor     = decimal.Parse(lblDisplay.Text.Replace(",", "."));
            var resultado = _calculadora.AoQuadrado(valor);

            lblDisplayTop.Text += $"( {lblDisplay.Text} )² ";
            lblDisplay.Text     = resultado.ToString();
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            var valor     = decimal.Parse(lblDisplay.Text.Replace(",", "."));
            var resultado = _calculadora.RaizQuadrada(valor);

            lblDisplay.Text = resultado.ToString().Replace(".", ",");
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text.StartsWith("-")
                ? lblDisplay.Text.Substring(1)
                : "-" + lblDisplay.Text;
        }

        private void btnSeparadorDecimal_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains(","))
                lblDisplay.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
                RealizarOperacao();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(200, 0, 30);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Transparent;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizarDisplayFormatado()
        {
            var cultura = new CultureInfo("pt-BR");

            if (decimal.TryParse(lblDisplay.Text, NumberStyles.Any, cultura, out decimal valor))
            {
                lblDisplay.Text = valor.ToString("#,##0.################", cultura);
            }
        }

        private void RealizarOperacao()
        {
            if (lblDisplayTop.Text.Contains("%"))
            {
                string[] partes = lblDisplayTop.Text.Split(' ');

                if (partes.Length >= 2)
                {
                    double valor1    = double.Parse(partes[0].Replace(",", "."));
                    double valor2    = double.Parse(lblDisplay.Text.Replace(",", "."));
                    double resultado = valor1 * (valor2 / 100);

                    lblDisplayTop.Text += lblDisplay.Text + " = ";
                    lblDisplay.Text     = resultado.ToString().Replace(".", ",");
                }

                return;
            }

            if (!string.IsNullOrEmpty(lblDisplayTop.Text) &&
                !lblDisplayTop.Text.Contains("="))
            {
                string expressao = lblDisplayTop.Text + lblDisplay.Text;

                expressao = expressao
                    .Replace("x", "*")
                    .Replace("÷", "/")
                    .Replace(".", "") 
                    .Replace(",", ".");

                var dt        = new DataTable();
                var resultado = dt.Compute(expressao, "");

                lblDisplayTop.Text += lblDisplay.Text + " = ";
                lblDisplay.Text     = resultado.ToString();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST  = 0x84;
            const int HTCLIENT      = 1;
            const int HTCAPTION     = 2;
            const int HTLEFT        = 10;
            const int HTRIGHT       = 11;
            const int HTTOP         = 12;
            const int HTTOPLEFT     = 13;
            const int HTTOPRIGHT    = 14;
            const int HTBOTTOM      = 15;
            const int HTBOTTOMLEFT  = 16;
            const int HTBOTTOMRIGHT = 17;

            const int RESIZE_AREA = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == HTCLIENT)
                {
                    Point pos = PointToClient(Cursor.Position);

                    bool left   = pos.X <= RESIZE_AREA;
                    bool right  = pos.X >= Width - RESIZE_AREA;
                    bool top    = pos.Y <= RESIZE_AREA;
                    bool bottom = pos.Y >= Height - RESIZE_AREA;

                    if (left && top)            m.Result = (IntPtr)HTTOPLEFT;
                    else if (right && top)      m.Result = (IntPtr)HTTOPRIGHT;
                    else if (left && bottom)    m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (right && bottom)   m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else if (left)              m.Result = (IntPtr)HTLEFT;
                    else if (right)             m.Result = (IntPtr)HTRIGHT;
                    else if (top)               m.Result = (IntPtr)HTTOP;
                    else if (bottom)            m.Result = (IntPtr)HTBOTTOM;
                    else                        m.Result = (IntPtr)HTCAPTION;
                }

                return;
            }

            base.WndProc(ref m);
        }
    }
}