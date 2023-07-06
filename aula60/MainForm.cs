/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 11/10/2022
 * Hora: 07:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aula60
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public void Button1Click(object sender, EventArgs e)
		{
			//string txt;
			
			if(txtTexto == null){
				
			}
			else{
				/*txt = txtTexto.Text;
				lbTexto.Text = txt;*/
				
				// ******* OU ********
				lbTexto.Text= txtTexto.Text;
			}
		}
	}
}
