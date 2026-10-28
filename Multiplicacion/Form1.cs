/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 27/10/2026
 * Hora: 8:22 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplicacion
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a=Convert.ToDouble(txtbA.Text), b=Convert.ToDouble(txtbB.Text), c=Convert.ToDouble(txtbC.Text);
			double disc=(b*b)-(4*a*c);
			double x1=(-b+Math.Sqrt(disc))/(2*a);
            double x2=(-b-Math.Sqrt(disc))/(2*a);
            MessageBox.Show("Los valores son: \nx1: "+x1+"\nx2: "+x2);
		}
		
		void BasicasToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Hide();			
		}
	}
}
