/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 11/10/2022
 * Hora: 09:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class F_Principal : Form
	{
		
		
		
		public F_Principal()
		{
			InitializeComponent();
		}
		
		
		void BtnAdicionarClick(object sender, EventArgs e)
		{
			if(txtCarro1.Text == ""){
				MessageBox.Show("Digite um veiculo!");
				txtCarro1.Focus();
				return;
			}
			else{
				txtCarros.Text +=  txtCarro1.Text + ", ";
				txtCarro1.Clear();
				txtCarro1.Focus();
			}
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
			
			txtCarros.Clear();
			txtCarro1.Clear();
			txtCarro1.Focus();
			
		}
		void BtnMudarClick(object sender, EventArgs e)
		{
			if(txtMudar.Text == ""){
				MessageBox.Show("Digite algo para Mudar!");
			}
			else{
				lbMudar.Text = txtMudar.Text;
			}
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			Close();
		}
		void BtnMostrarClick(object sender, EventArgs e)
		{
			F_secundaria fsecundaria = new F_secundaria(txtCarros.Text);
			fsecundaria.ShowDialog();
		}
	
		
	}
}
