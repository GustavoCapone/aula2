/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 13/10/2022
 * Hora: 10:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Componentes
{
	partial class F_secundaria
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtLista;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtLista = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtLista
			// 
			this.txtLista.Location = new System.Drawing.Point(49, 33);
			this.txtLista.Multiline = true;
			this.txtLista.Name = "txtLista";
			this.txtLista.Size = new System.Drawing.Size(375, 288);
			this.txtLista.TabIndex = 0;
			// 
			// F_secundaria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 333);
			this.Controls.Add(this.txtLista);
			this.Name = "F_secundaria";
			this.Text = "lista de veiculos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
