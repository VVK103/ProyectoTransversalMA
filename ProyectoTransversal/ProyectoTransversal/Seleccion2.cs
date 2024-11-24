/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 21/11/2024
 * Time: 12:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTransversal
{
	/// <summary>
	/// Description of Seleccion2.
	/// </summary>
	public partial class Seleccion2 : Form
	{
		public Seleccion2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Seleccion2Load(object sender, EventArgs e)
		{
			if(DatosCompartidos.materiales == "Arena")
			{
				Lblarena.Text = "Recomendado: " + DatosCompartidos.tamano*2;
			}
			if(DatosCompartidos.materiales == "Aserrin")
			{
				Lblaserrin.Text = "Recomendado: " + DatosCompartidos.tamano*3.5;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(Cbxaserrin.Text=="Aserrin natural")
			{
				DatosCompartidos.aserrin= (double.Parse(Txtaserrin.Text)*15);
			}
			if(Cbxaserrin.Text=="Aserrin teñido")
			{
				DatosCompartidos.aserrin= (double.Parse(Txtaserrin.Text)*25);
			}
			if(Cbxaserrin.Text=="Aserrin molido")
			{
				DatosCompartidos.aserrin= (double.Parse(Txtaserrin.Text)*10);
			}
			
			
			if(Cbxarena.Text=="Arena comun")
			{
				DatosCompartidos.arena= (double.Parse(Txtarena.Text)*10);
			}
			if(Cbxarena.Text=="Arena teñida")
			{
				DatosCompartidos.arena= (double.Parse(Txtarena.Text)*15);
			}
			
			
			if(Cbxpintura.Text=="Pigmentos artesanales")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*150);
			}
			if(Cbxpintura.Text=="Pigmentos naturales")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*200);
			}
			if(Cbxpintura.Text=="Comex")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*200);
			}
			if(Cbxpintura.Text=="Berel")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*250);
			}
			if(Cbxpintura.Text=="Vinci")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*150);
			}
			if(Cbxpintura.Text=="Politec")
			{
				DatosCompartidos.pintura= (double.Parse(Txtpintura.Text)*300);
			}
			
			
			if(Cbxflores.Text=="Flores de Cempasuchil")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*100);
			}
			if(Cbxflores.Text=="Flor de Dalia")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*60);
			}
			if(Cbxflores.Text=="Rosas")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*150);
			}
			if(Cbxflores.Text=="Flor de nube(Gypsophila)")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*50);
			}
			if(Cbxflores.Text=="Crisantemos")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*75);
			}
			if(Cbxflores.Text=="Claveles")
			{
				DatosCompartidos.petalos= (double.Parse(Txtpetalos.Text)*90);
			}
			
			DatosCompartidos.cal= double.Parse(Txtcal.Text);
			
			Total Total = new Total();
			Total.Show();
		}
	}
}
