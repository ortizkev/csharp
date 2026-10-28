/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 27/10/2026
 * Hora: 8:22 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Multiplicacion
{
	partial class Form1
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
			this.txtbA = new System.Windows.Forms.TextBox();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valorDeX1YX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor de A:";
			// 
			// txtbA
			// 
			this.txtbA.Location = new System.Drawing.Point(74, 27);
			this.txtbA.Name = "txtbA";
			this.txtbA.Size = new System.Drawing.Size(100, 20);
			this.txtbA.TabIndex = 1;
			// 
			// txtbB
			// 
			this.txtbB.Location = new System.Drawing.Point(240, 27);
			this.txtbB.Name = "txtbB";
			this.txtbB.Size = new System.Drawing.Size(100, 20);
			this.txtbB.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(180, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Valor de B:";
			// 
			// txtbC
			// 
			this.txtbC.Location = new System.Drawing.Point(158, 59);
			this.txtbC.Name = "txtbC";
			this.txtbC.Size = new System.Drawing.Size(100, 20);
			this.txtbC.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(98, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Valor de C:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(148, 88);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.operacionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(363, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// operacionesToolStripMenuItem
			// 
			this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.basicasToolStripMenuItem,
									this.valorDeX1YX2ToolStripMenuItem});
			this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
			this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.operacionesToolStripMenuItem.Text = "Operaciones";
			// 
			// basicasToolStripMenuItem
			// 
			this.basicasToolStripMenuItem.Name = "basicasToolStripMenuItem";
			this.basicasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.basicasToolStripMenuItem.Text = "Básicas";
			this.basicasToolStripMenuItem.Click += new System.EventHandler(this.BasicasToolStripMenuItemClick);
			// 
			// valorDeX1YX2ToolStripMenuItem
			// 
			this.valorDeX1YX2ToolStripMenuItem.Name = "valorDeX1YX2ToolStripMenuItem";
			this.valorDeX1YX2ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.valorDeX1YX2ToolStripMenuItem.Text = "Valor de x1 y x2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 125);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtbC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Valores";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem valorDeX1YX2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem basicasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtbC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtbB;
		private System.Windows.Forms.TextBox txtbA;
		private System.Windows.Forms.Label label1;
	}
}
