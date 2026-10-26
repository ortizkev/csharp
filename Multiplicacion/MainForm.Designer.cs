/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 23/10/2026
 * Hora: 7:38 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Multiplicacion
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtbNum1 = new System.Windows.Forms.TextBox();
			this.txtbNum2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnSumar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 2:";
			// 
			// txtbNum1
			// 
			this.txtbNum1.Location = new System.Drawing.Point(64, 13);
			this.txtbNum1.Name = "txtbNum1";
			this.txtbNum1.Size = new System.Drawing.Size(100, 20);
			this.txtbNum1.TabIndex = 2;
			// 
			// txtbNum2
			// 
			this.txtbNum2.Location = new System.Drawing.Point(64, 40);
			this.txtbNum2.Name = "txtbNum2";
			this.txtbNum2.Size = new System.Drawing.Size(100, 20);
			this.txtbNum2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Multiplicar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(88, 69);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 5;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(88, 92);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(12, 92);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 7;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(175, 127);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtbNum2);
			this.Controls.Add(this.txtbNum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Multiplicacion";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtbNum2;
		private System.Windows.Forms.TextBox txtbNum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
