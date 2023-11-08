using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Learning_C_
{   
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();                    
        }
        
        void Button1Click(object sender, EventArgs e)
        {   
            int a = 2;
            int b = 3;
            int c = 4;

            double delta, a1, a2;

            delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = (-b - Math.Sqrt(delta)) / (2 * a);

                MessageBox.Show(a1.ToString()); // Exibe a primeira raiz se delta for não negativo
                MessageBox.Show(a2.ToString()); // Exibe a segunda raiz se delta for não negativo
            }
            else
            {
                MessageBox.Show("Não há raízes reais para a equação.");
            }
        }
    }
}
