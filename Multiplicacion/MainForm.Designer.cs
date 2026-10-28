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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbNum1 = new System.Windows.Forms.TextBox();
			this.txtbNum2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnMod = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.operacionesBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.básicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valorDeX1YX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 2:";
			// 
			// txtbNum1
			// 
			this.txtbNum1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbNum1.Location = new System.Drawing.Point(126, 33);
			this.txtbNum1.Name = "txtbNum1";
			this.txtbNum1.Size = new System.Drawing.Size(100, 22);
			this.txtbNum1.TabIndex = 2;
			// 
			// txtbNum2
			// 
			this.txtbNum2.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbNum2.Location = new System.Drawing.Point(126, 60);
			this.txtbNum2.Name = "txtbNum2";
			this.txtbNum2.Size = new System.Drawing.Size(100, 22);
			this.txtbNum2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(74, 89);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Multiplicar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(150, 89);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 5;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestar.Location = new System.Drawing.Point(150, 112);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnSumar
			// 
			this.btnSumar.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSumar.Location = new System.Drawing.Point(74, 112);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 7;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnMod
			// 
			this.btnMod.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMod.Location = new System.Drawing.Point(110, 136);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(75, 23);
			this.btnMod.TabIndex = 8;
			this.btnMod.Text = "Modulo";
			this.btnMod.UseVisualStyleBackColor = true;
			this.btnMod.Click += new System.EventHandler(this.BtnModClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.operacionesBasicasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(242, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// operacionesBasicasToolStripMenuItem
			// 
			this.operacionesBasicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.básicasToolStripMenuItem,
									this.valorDeX1YX2ToolStripMenuItem});
			this.operacionesBasicasToolStripMenuItem.Name = "operacionesBasicasToolStripMenuItem";
			this.operacionesBasicasToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.operacionesBasicasToolStripMenuItem.Text = "Operaciones";
			// 
			// básicasToolStripMenuItem
			// 
			this.básicasToolStripMenuItem.Name = "básicasToolStripMenuItem";
			this.básicasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.básicasToolStripMenuItem.Text = "Básicas";
			// 
			// valorDeX1YX2ToolStripMenuItem
			// 
			this.valorDeX1YX2ToolStripMenuItem.Name = "valorDeX1YX2ToolStripMenuItem";
			this.valorDeX1YX2ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.valorDeX1YX2ToolStripMenuItem.Text = "Valor de x1 y x2";
			this.valorDeX1YX2ToolStripMenuItem.Click += new System.EventHandler(this.ValorDeX1YX2ToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(12, 141);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 59);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(242, 207);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnMod);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtbNum2);
			this.Controls.Add(this.txtbNum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Multiplicacion";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem valorDeX1YX2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem básicasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operacionesBasicasToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnMod;
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
