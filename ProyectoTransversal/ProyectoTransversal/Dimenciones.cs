/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 21/11/2024
 * Time: 11:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTransversal
{
	/// <summary>
	/// Description of Dimenciones.
	/// </summary>
	public partial class Dimenciones : Form
	{
		public Dimenciones()
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
			Seleccion1 Seleccion1 = new Seleccion1();
			Seleccion1.Show();
		}
	}
}
