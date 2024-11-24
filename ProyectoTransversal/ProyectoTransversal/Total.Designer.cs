/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 22/11/2024
 * Time: 12:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTransversal
{
	partial class Total
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Lblprecio = new System.Windows.Forms.Label();
			this.Lbltotal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(134, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "Precio aproximados del tapete";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Silver;
			this.label2.Location = new System.Drawing.Point(76, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(596, 105);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ten en cuenta que en la realizacion del tapete puede ocurrir algun imprevisto que" +
	" aumente el precio dado que no se puede controlar los elementos naturales como e" +
	"l clima.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Lblprecio
			// 
			this.Lblprecio.BackColor = System.Drawing.Color.Transparent;
			this.Lblprecio.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblprecio.ForeColor = System.Drawing.Color.Silver;
			this.Lblprecio.Location = new System.Drawing.Point(76, 226);
			this.Lblprecio.Name = "Lblprecio";
			this.Lblprecio.Size = new System.Drawing.Size(596, 86);
			this.Lblprecio.TabIndex = 2;
			this.Lblprecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Lbltotal
			// 
			this.Lbltotal.BackColor = System.Drawing.Color.Transparent;
			this.Lbltotal.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbltotal.ForeColor = System.Drawing.Color.Silver;
			this.Lbltotal.Location = new System.Drawing.Point(311, 323);
			this.Lbltotal.Name = "Lbltotal";
			this.Lbltotal.Size = new System.Drawing.Size(137, 43);
			this.Lbltotal.TabIndex = 3;
			// 
			// Total
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(739, 480);
			this.Controls.Add(this.Lbltotal);
			this.Controls.Add(this.Lblprecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Total";
			this.Text = "Total";
			this.Load += new System.EventHandler(this.TotalLoad);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label Lblprecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Lbltotal;
	}
}
