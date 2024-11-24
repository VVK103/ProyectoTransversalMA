/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 21/11/2024
 * Time: 10:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
public static class DatosCompartidos {
		public static string diseno {
		get; set;
	}
		public static double disenoprecio {
		get; set;}
		public static double tamano {
		get; set;}
		public static double manodeobra {
		get; set;}
		public static string materiales {
		get; set;}
		public static double aserrin {
		get; set;}
		public static double arena {
		get; set;}
		public static double pintura {
		get; set;}
		public static double cal {
		get; set;}
		public static double petalos {
		get; set;}
	}

namespace ProyectoTransversal
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
			Dimenciones Dimenciones = new Dimenciones();
			Dimenciones.Show();
		}
	}
}
