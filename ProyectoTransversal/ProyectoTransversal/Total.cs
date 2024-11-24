/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 22/11/2024
 * Time: 12:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ProyectoTransversal
{
	/// <summary>
	/// Description of Total.
	/// </summary>
	public partial class Total : Form
	{
		public Total()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TotalLoad(object sender, EventArgs e)
		{
			
			if(DatosCompartidos.diseno == "Diseño sencillo")
			{
				Lblprecio.Text ="El precio aproximado de un Tapete con las características: "+ DatosCompartidos.diseno + " + " + DatosCompartidos.tamano + "m2";
				DatosCompartidos.disenoprecio = 20.0* DatosCompartidos.tamano;
			}
			if(DatosCompartidos.diseno == "Diseño normal")
			{
				Lblprecio.Text ="El precio aproximado de un Tapete con las características: "+ DatosCompartidos.diseno + " + " + DatosCompartidos.tamano + "m2";
				DatosCompartidos.disenoprecio = 35.0* DatosCompartidos.tamano;
			}
			if(DatosCompartidos.diseno == "Diseño complejo")
			{
				Lblprecio.Text ="El precio aproximado de un Tapete con las características: "+ DatosCompartidos.diseno + " + " + DatosCompartidos.tamano + "m2";
				DatosCompartidos.disenoprecio = 45.0* DatosCompartidos.tamano;
			}
			
			double total= DatosCompartidos.manodeobra + DatosCompartidos.disenoprecio + DatosCompartidos.arena + DatosCompartidos.aserrin +
			DatosCompartidos.cal + DatosCompartidos.petalos + DatosCompartidos.pintura;
			Lbltotal.Text="$ "+ total;
		}
	}
}
