/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 13/10/2022
 * Hora: 10:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class F_secundaria : Form
	{
		public F_secundaria(string v)
		{
			InitializeComponent();
			
			txtLista.Text = v;
		}
	}
}
