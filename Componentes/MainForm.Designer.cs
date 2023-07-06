/*
 * Criado por SharpDevelop.
 * Usuário: nti
 * Data: 11/10/2022
 * Hora: 09:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Componentes
{
	partial class F_Principal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.TextBox txtCarro1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCarros;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnMudar;
		private System.Windows.Forms.Label lbMudar;
		private System.Windows.Forms.TextBox txtMudar;
		private System.Windows.Forms.Button btnMostrar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCarro1 = new System.Windows.Forms.TextBox();
			this.txtCarros = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnMudar = new System.Windows.Forms.Button();
			this.lbMudar = new System.Windows.Forms.Label();
			this.txtMudar = new System.Windows.Forms.TextBox();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite aqui o nome dos carros: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCarro1
			// 
			this.txtCarro1.Location = new System.Drawing.Point(12, 35);
			this.txtCarro1.Name = "txtCarro1";
			this.txtCarro1.Size = new System.Drawing.Size(155, 20);
			this.txtCarro1.TabIndex = 1;
			// 
			// txtCarros
			// 
			this.txtCarros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarros.Location = new System.Drawing.Point(12, 84);
			this.txtCarros.Multiline = true;
			this.txtCarros.Name = "txtCarros";
			this.txtCarros.Size = new System.Drawing.Size(155, 165);
			this.txtCarros.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Carros adicionador: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(173, 25);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(90, 30);
			this.btnAdicionar.TabIndex = 4;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(173, 61);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(90, 32);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair\r\n";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(173, 99);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(90, 32);
			this.btnLimpar.TabIndex = 7;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnMudar
			// 
			this.btnMudar.Location = new System.Drawing.Point(269, 25);
			this.btnMudar.Name = "btnMudar";
			this.btnMudar.Size = new System.Drawing.Size(89, 30);
			this.btnMudar.TabIndex = 8;
			this.btnMudar.Text = "Mudar";
			this.btnMudar.UseVisualStyleBackColor = true;
			this.btnMudar.Click += new System.EventHandler(this.BtnMudarClick);
			// 
			// lbMudar
			// 
			this.lbMudar.Location = new System.Drawing.Point(283, 70);
			this.lbMudar.Name = "lbMudar";
			this.lbMudar.Size = new System.Drawing.Size(266, 23);
			this.lbMudar.TabIndex = 9;
			this.lbMudar.Text = "Texto escrito!";
			// 
			// txtMudar
			// 
			this.txtMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMudar.Location = new System.Drawing.Point(283, 99);
			this.txtMudar.Name = "txtMudar";
			this.txtMudar.Size = new System.Drawing.Size(266, 21);
			this.txtMudar.TabIndex = 10;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(173, 137);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(107, 46);
			this.btnMostrar.TabIndex = 11;
			this.btnMostrar.Text = "Mostrar veicuçlos";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.BtnMostrarClick);
			// 
			// F_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 271);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.txtMudar);
			this.Controls.Add(this.lbMudar);
			this.Controls.Add(this.btnMudar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCarros);
			this.Controls.Add(this.txtCarro1);
			this.Controls.Add(this.label1);
			this.Name = "F_Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Componentes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
