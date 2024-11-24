/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 21/11/2024
 * Time: 11:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTransversal
{
	/// <summary>
	/// Description of Seleccion1.
	/// </summary>
	public partial class Seleccion1 : Form
	{
		public Seleccion1()
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
			
			DatosCompartidos.diseno= Cbxdiseño.Text;
			DatosCompartidos.materiales= Cbxmaterial.Text;
			DatosCompartidos.tamano= double.Parse(Txttamaño1.Text) * double.Parse(Txttamaño2.Text);
			
			if(Cbxmanodeobra.Text == "Personas normales")
			{
				DatosCompartidos.manodeobra = 100.0 * double.Parse(Txtpersonas.Text);
			}
			if(Cbxmanodeobra.Text== "Artistas Graduados")
			{
				DatosCompartidos.manodeobra = 500.0 * double.Parse(Txtpersonas.Text);
			}
			if(Cbxmanodeobra.Text == "Dibujantes")
			{
				DatosCompartidos.manodeobra = 300.0 * double.Parse(Txtpersonas.Text);
			}
			Precios Precios = new Precios();
			Precios.Show();
		}
		
	}
}
