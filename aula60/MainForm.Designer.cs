/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 11/10/2022
 * Hora: 07:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace aula60
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtTexto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbTexto;
		
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
			this.btnStart = new System.Windows.Forms.Button();
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbTexto = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStart.Location = new System.Drawing.Point(143, 131);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(120, 73);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtTexto
			// 
			this.txtTexto.Location = new System.Drawing.Point(74, 95);
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(276, 20);
			this.txtTexto.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(143, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mude o Texto abaixo!";
			// 
			// lbTexto
			// 
			this.lbTexto.Location = new System.Drawing.Point(121, 70);
			this.lbTexto.Name = "lbTexto";
			this.lbTexto.Size = new System.Drawing.Size(162, 22);
			this.lbTexto.TabIndex = 3;
			this.lbTexto.Text = "Era uma vez os tres porquinhos";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 316);
			this.Controls.Add(this.lbTexto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTexto);
			this.Controls.Add(this.btnStart);
			this.Name = "MainForm";
			this.Text = "aula60";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
