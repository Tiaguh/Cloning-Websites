using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Learning_C_
{	
	public partial class MainForm : Form
	{
		int numeroConta;	
		double saldoConta = 100.0;
		double valorSaque = 10.0;
		
		public MainForm()
		{
			InitializeComponent();
			
			numeroConta = 1;
			saldoConta -= valorSaque;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Conta: " + numeroConta + "\nSaldo: " + saldoConta);
		}
	}
}
