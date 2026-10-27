/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 23/10/2026
 * Hora: 7:38 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplicacion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double res, num1=Convert.ToDouble(txtbNum1.Text), num2=Convert.ToDouble(txtbNum2.Text);
			res=num1*num2;
			MessageBox.Show("El resultado es: "+res);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double res, num1=Convert.ToDouble(txtbNum1.Text), num2=Convert.ToDouble(txtbNum2.Text);
			res=num1/num2;
			MessageBox.Show("El resultado es: "+res);
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double res, num1=Convert.ToDouble(txtbNum1.Text), num2=Convert.ToDouble(txtbNum2.Text);
			res=num1+num2;
			MessageBox.Show("El resultado es: "+res);			
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double res, num1=Convert.ToDouble(txtbNum1.Text), num2=Convert.ToDouble(txtbNum2.Text);
			res=num1-num2;
			MessageBox.Show("El resultado es: "+res);			
		}
		
		void BtnModClick(object sender, EventArgs e)
		{
			double num1=Convert.ToDouble(txtbNum1.Text), num2=Convert.ToDouble(txtbNum2.Text);
			if (num1<=0 || num2<=0){
				MessageBox.Show("No se puede dividir entre cero.");
				return;
			}
			MessageBox.Show("El resultado es: "+ num1%num2);				
		}
	}
}
