namespace Calculadora
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnMinimizar = new Button();
            lblDisplayTop = new Label();
            btnFechar = new Button();
            lblDisplay = new Label();
            btnApagar = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnPorcent = new Button();
            btnInverso = new Button();
            btnAoQuadrado = new Button();
            btnRaizQuadrada = new Button();
            btnDividir = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicar = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtrair = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSomar = new Button();
            btnInverterSinal = new Button();
            btn0 = new Button();
            btnSeparadorDecimal = new Button();
            btnIgual = new Button();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(lblDisplayTop);
            pnlTop.Controls.Add(btnFechar);
            pnlTop.Controls.Add(lblDisplay);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(400, 118);
            pnlTop.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackgroundImageLayout = ImageLayout.None;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Verdana", 12F);
            btnMinimizar.ForeColor = SystemColors.Control;
            btnMinimizar.Location = new Point(302, -1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 30);
            btnMinimizar.TabIndex = 26;
            btnMinimizar.TabStop = false;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblDisplayTop
            // 
            lblDisplayTop.Font = new Font("Segoe UI", 11F);
            lblDisplayTop.ForeColor = SystemColors.ControlDark;
            lblDisplayTop.Location = new Point(-1, 44);
            lblDisplayTop.Name = "lblDisplayTop";
            lblDisplayTop.RightToLeft = RightToLeft.No;
            lblDisplayTop.Size = new Size(401, 23);
            lblDisplayTop.TabIndex = 25;
            lblDisplayTop.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.Transparent;
            btnFechar.BackgroundImageLayout = ImageLayout.None;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.Control;
            btnFechar.Location = new Point(351, -1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 30);
            btnFechar.TabIndex = 0;
            btnFechar.TabStop = false;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            btnFechar.MouseEnter += btnFechar_MouseEnter;
            btnFechar.MouseLeave += btnFechar_MouseLeave;
            // 
            // lblDisplay
            // 
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.WhiteSmoke;
            lblDisplay.Location = new Point(0, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.RightToLeft = RightToLeft.No;
            lblDisplay.Size = new Size(400, 118);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(50, 50, 50);
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 14F);
            btnApagar.ForeColor = Color.WhiteSmoke;
            btnApagar.Location = new Point(302, 143);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(93, 70);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "DEL";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(50, 50, 50);
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 14F);
            btnC.ForeColor = Color.WhiteSmoke;
            btnC.Location = new Point(203, 143);
            btnC.Name = "btnC";
            btnC.Size = new Size(93, 70);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(50, 50, 50);
            btnCE.FlatAppearance.BorderSize = 0;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Segoe UI", 14F);
            btnCE.ForeColor = Color.WhiteSmoke;
            btnCE.Location = new Point(104, 143);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(93, 70);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnPorcent
            // 
            btnPorcent.BackColor = Color.FromArgb(50, 50, 50);
            btnPorcent.FlatAppearance.BorderSize = 0;
            btnPorcent.FlatStyle = FlatStyle.Flat;
            btnPorcent.Font = new Font("Segoe UI", 14F);
            btnPorcent.ForeColor = Color.WhiteSmoke;
            btnPorcent.Location = new Point(5, 143);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Size = new Size(93, 70);
            btnPorcent.TabIndex = 1;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = false;
            btnPorcent.Click += Operador_Click;
            // 
            // btnInverso
            // 
            btnInverso.BackColor = Color.FromArgb(50, 50, 50);
            btnInverso.FlatAppearance.BorderSize = 0;
            btnInverso.FlatStyle = FlatStyle.Flat;
            btnInverso.Font = new Font("Segoe UI", 14F);
            btnInverso.ForeColor = Color.WhiteSmoke;
            btnInverso.Location = new Point(5, 219);
            btnInverso.Name = "btnInverso";
            btnInverso.Size = new Size(93, 70);
            btnInverso.TabIndex = 5;
            btnInverso.Text = "¹/x";
            btnInverso.UseVisualStyleBackColor = false;
            btnInverso.Click += btnInverso_Click;
            // 
            // btnAoQuadrado
            // 
            btnAoQuadrado.BackColor = Color.FromArgb(50, 50, 50);
            btnAoQuadrado.FlatAppearance.BorderSize = 0;
            btnAoQuadrado.FlatStyle = FlatStyle.Flat;
            btnAoQuadrado.Font = new Font("Segoe UI", 14F);
            btnAoQuadrado.ForeColor = Color.WhiteSmoke;
            btnAoQuadrado.Location = new Point(104, 219);
            btnAoQuadrado.Name = "btnAoQuadrado";
            btnAoQuadrado.Size = new Size(93, 70);
            btnAoQuadrado.TabIndex = 6;
            btnAoQuadrado.Text = "x²";
            btnAoQuadrado.UseVisualStyleBackColor = false;
            btnAoQuadrado.Click += btnAoQuadrado_Click;
            // 
            // btnRaizQuadrada
            // 
            btnRaizQuadrada.BackColor = Color.FromArgb(50, 50, 50);
            btnRaizQuadrada.FlatAppearance.BorderSize = 0;
            btnRaizQuadrada.FlatStyle = FlatStyle.Flat;
            btnRaizQuadrada.Font = new Font("Segoe UI", 14F);
            btnRaizQuadrada.ForeColor = Color.WhiteSmoke;
            btnRaizQuadrada.Location = new Point(203, 219);
            btnRaizQuadrada.Name = "btnRaizQuadrada";
            btnRaizQuadrada.Size = new Size(93, 70);
            btnRaizQuadrada.TabIndex = 7;
            btnRaizQuadrada.Text = "²√x";
            btnRaizQuadrada.UseVisualStyleBackColor = false;
            btnRaizQuadrada.Click += btnRaizQuadrada_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.FromArgb(50, 50, 50);
            btnDividir.FlatAppearance.BorderSize = 0;
            btnDividir.FlatStyle = FlatStyle.Flat;
            btnDividir.Font = new Font("Segoe UI", 18F);
            btnDividir.ForeColor = Color.WhiteSmoke;
            btnDividir.Location = new Point(302, 219);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(93, 70);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += Operador_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(65, 65, 65);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 14F);
            btn7.ForeColor = Color.WhiteSmoke;
            btn7.Location = new Point(5, 295);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 70);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Numero_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(65, 65, 65);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14F);
            btn8.ForeColor = Color.WhiteSmoke;
            btn8.Location = new Point(104, 295);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 70);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Numero_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(65, 65, 65);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 14F);
            btn9.ForeColor = Color.WhiteSmoke;
            btn9.Location = new Point(203, 295);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 70);
            btn9.TabIndex = 11;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Numero_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.FromArgb(50, 50, 50);
            btnMultiplicar.FlatAppearance.BorderSize = 0;
            btnMultiplicar.FlatStyle = FlatStyle.Flat;
            btnMultiplicar.Font = new Font("Verdana", 12F);
            btnMultiplicar.ForeColor = Color.WhiteSmoke;
            btnMultiplicar.Location = new Point(302, 295);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(93, 70);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += Operador_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(65, 65, 65);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14F);
            btn4.ForeColor = Color.WhiteSmoke;
            btn4.Location = new Point(5, 371);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 70);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Numero_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(65, 65, 65);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14F);
            btn5.ForeColor = Color.WhiteSmoke;
            btn5.Location = new Point(104, 371);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 70);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Numero_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(65, 65, 65);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14F);
            btn6.ForeColor = Color.WhiteSmoke;
            btn6.Location = new Point(203, 371);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 70);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Numero_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.BackColor = Color.FromArgb(50, 50, 50);
            btnSubtrair.FlatAppearance.BorderSize = 0;
            btnSubtrair.FlatStyle = FlatStyle.Flat;
            btnSubtrair.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtrair.ForeColor = Color.WhiteSmoke;
            btnSubtrair.Location = new Point(302, 371);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(93, 70);
            btnSubtrair.TabIndex = 16;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += Operador_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(65, 65, 65);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14F);
            btn1.ForeColor = Color.WhiteSmoke;
            btn1.Location = new Point(5, 447);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 70);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Numero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(65, 65, 65);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14F);
            btn2.ForeColor = Color.WhiteSmoke;
            btn2.Location = new Point(104, 447);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 70);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Numero_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(65, 65, 65);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14F);
            btn3.ForeColor = Color.WhiteSmoke;
            btn3.Location = new Point(203, 447);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 70);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Numero_Click;
            // 
            // btnSomar
            // 
            btnSomar.BackColor = Color.FromArgb(50, 50, 50);
            btnSomar.FlatAppearance.BorderSize = 0;
            btnSomar.FlatStyle = FlatStyle.Flat;
            btnSomar.Font = new Font("Segoe UI", 18F);
            btnSomar.ForeColor = Color.WhiteSmoke;
            btnSomar.Location = new Point(302, 447);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(93, 70);
            btnSomar.TabIndex = 20;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += Operador_Click;
            // 
            // btnInverterSinal
            // 
            btnInverterSinal.BackColor = Color.FromArgb(65, 65, 65);
            btnInverterSinal.FlatAppearance.BorderSize = 0;
            btnInverterSinal.FlatStyle = FlatStyle.Flat;
            btnInverterSinal.Font = new Font("Segoe UI", 14F);
            btnInverterSinal.ForeColor = Color.WhiteSmoke;
            btnInverterSinal.Location = new Point(5, 523);
            btnInverterSinal.Name = "btnInverterSinal";
            btnInverterSinal.Size = new Size(93, 70);
            btnInverterSinal.TabIndex = 21;
            btnInverterSinal.Text = "+/-";
            btnInverterSinal.UseVisualStyleBackColor = false;
            btnInverterSinal.Click += btnInverterSinal_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(65, 65, 65);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14F);
            btn0.ForeColor = Color.WhiteSmoke;
            btn0.Location = new Point(104, 523);
            btn0.Name = "btn0";
            btn0.Size = new Size(93, 70);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Numero_Click;
            // 
            // btnSeparadorDecimal
            // 
            btnSeparadorDecimal.BackColor = Color.FromArgb(65, 65, 65);
            btnSeparadorDecimal.FlatAppearance.BorderSize = 0;
            btnSeparadorDecimal.FlatStyle = FlatStyle.Flat;
            btnSeparadorDecimal.Font = new Font("Segoe UI", 14F);
            btnSeparadorDecimal.ForeColor = Color.WhiteSmoke;
            btnSeparadorDecimal.Location = new Point(203, 523);
            btnSeparadorDecimal.Name = "btnSeparadorDecimal";
            btnSeparadorDecimal.Size = new Size(93, 70);
            btnSeparadorDecimal.TabIndex = 23;
            btnSeparadorDecimal.Text = ",";
            btnSeparadorDecimal.UseVisualStyleBackColor = false;
            btnSeparadorDecimal.Click += btnSeparadorDecimal_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.MediumSeaGreen;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 18F);
            btnIgual.ForeColor = Color.Black;
            btnIgual.Location = new Point(302, 523);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(93, 70);
            btnIgual.TabIndex = 24;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(400, 600);
            Controls.Add(btnInverterSinal);
            Controls.Add(btn0);
            Controls.Add(btnSeparadorDecimal);
            Controls.Add(btnIgual);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnSomar);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnSubtrair);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnInverso);
            Controls.Add(btnAoQuadrado);
            Controls.Add(btnRaizQuadrada);
            Controls.Add(btnDividir);
            Controls.Add(btnPorcent);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(btnApagar);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximumSize = new Size(400, 600);
            MinimumSize = new Size(400, 600);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblDisplay;
        private Button btnFechar;
        private Button btnApagar;
        private Button btnC;
        private Button btnCE;
        private Button btnPorcent;
        private Button btnInverso;
        private Button btnAoQuadrado;
        private Button btnRaizQuadrada;
        private Button btnDividir;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicar;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtrair;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSomar;
        private Button btnInverterSinal;
        private Button btn0;
        private Button btnSeparadorDecimal;
        private Button btnIgual;
        private Label lblDisplayTop;
        private Button btnMinimizar;
    }
}
