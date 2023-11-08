using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Crie	3	variáveis	com	as	idades	dos	seus	melhores	amigos	e/ou	familiares.
// Em	seguida,	pegue	essas	3	idades	e	calcule	a	média	delas.	
// Exiba	o	resultado	em	um	MessageBox.

namespace Learning_C_
{	
	public partial class MainForm : Form
	{
			
		int idadeJoao, idadeMaria, idadeMarcia;
		
		public MainForm()
		{
			InitializeComponent();		
		
			idadeJoao =	10;
			idadeMaria = 25;
			idadeMarcia = 20;
		}
				
		void Button1Click(object sender, EventArgs e)
		{						
			float media = ((idadeJoao + idadeMaria + idadeMarcia) / 3);
			
			MessageBox.Show(media.ToString());
		}
	}
}
