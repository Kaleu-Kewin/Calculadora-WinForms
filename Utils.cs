using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace Calculadora
{
    public static class Utils
    {
        public static void EstilizarButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                //configurações de estilo aqui...

                ArredondarButton(button, 10);
            }
        }

        public static void ArredondarButton(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();

            botao.Region = new Region(path);
        }
    }
}
