/*
 * Created by SharpDevelop.
 * User: CC1_PC41
 * Date: 21/11/2024
 * Time: 11:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTransversal
{
	partial class Seleccion1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Cbxdiseño = new System.Windows.Forms.ComboBox();
			this.Txttamaño1 = new System.Windows.Forms.TextBox();
			this.Txttamaño2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Cbxmanodeobra = new System.Windows.Forms.ComboBox();
			this.Cbxmaterial = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Txtpersonas = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 98);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(940, 407);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(489, 109);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selecciona las dimensiones y sus materiales que planeas utilizar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(823, 545);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(97, 87);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(117, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tipo de Diseño:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(117, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tamaño de el tapete:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(117, 359);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Mano de obra:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(117, 419);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Materiales:";
			// 
			// Cbxdiseño
			// 
			this.Cbxdiseño.FormattingEnabled = true;
			this.Cbxdiseño.Items.AddRange(new object[] {
			"Diseño sencillo",
			"Diseño normal",
			"Diseño complejo"});
			this.Cbxdiseño.Location = new System.Drawing.Point(272, 255);
			this.Cbxdiseño.Name = "Cbxdiseño";
			this.Cbxdiseño.Size = new System.Drawing.Size(158, 21);
			this.Cbxdiseño.TabIndex = 11;
			this.Cbxdiseño.Text = "Diseño de Tapete";
			// 
			// Txttamaño1
			// 
			this.Txttamaño1.Location = new System.Drawing.Point(303, 300);
			this.Txttamaño1.Name = "Txttamaño1";
			this.Txttamaño1.Size = new System.Drawing.Size(29, 20);
			this.Txttamaño1.TabIndex = 12;
			// 
			// Txttamaño2
			// 
			this.Txttamaño2.Location = new System.Drawing.Point(387, 300);
			this.Txttamaño2.Name = "Txttamaño2";
			this.Txttamaño2.Size = new System.Drawing.Size(29, 20);
			this.Txttamaño2.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(331, 305);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 18);
			this.label6.TabIndex = 14;
			this.label6.Text = "m";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(416, 305);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "m";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(359, 302);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 18);
			this.label8.TabIndex = 16;
			this.label8.Text = "x";
			// 
			// Cbxmanodeobra
			// 
			this.Cbxmanodeobra.FormattingEnabled = true;
			this.Cbxmanodeobra.Items.AddRange(new object[] {
			"Artistas graduados",
			"Dibujantes",
			"Personas normales"});
			this.Cbxmanodeobra.Location = new System.Drawing.Point(272, 361);
			this.Cbxmanodeobra.Name = "Cbxmanodeobra";
			this.Cbxmanodeobra.Size = new System.Drawing.Size(158, 21);
			this.Cbxmanodeobra.TabIndex = 17;
			this.Cbxmanodeobra.Text = "Tipo de mano de obra";
			// 
			// Cbxmaterial
			// 
			this.Cbxmaterial.FormattingEnabled = true;
			this.Cbxmaterial.Items.AddRange(new object[] {
			"Arena",
			"Aserrin"});
			this.Cbxmaterial.Location = new System.Drawing.Point(272, 421);
			this.Cbxmaterial.Name = "Cbxmaterial";
			this.Cbxmaterial.Size = new System.Drawing.Size(113, 21);
			this.Cbxmaterial.TabIndex = 18;
			this.Cbxmaterial.Text = "Material principal";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(117, 469);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Cantidad de personas:";
			// 
			// Txtpersonas
			// 
			this.Txtpersonas.Location = new System.Drawing.Point(272, 472);
			this.Txtpersonas.Name = "Txtpersonas";
			this.Txtpersonas.Size = new System.Drawing.Size(29, 20);
			this.Txtpersonas.TabIndex = 21;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(377, 545);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 38);
			this.button1.TabIndex = 24;
			this.button1.Text = "Siguiente";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Seleccion1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(920, 629);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Txtpersonas);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Cbxmaterial);
			this.Controls.Add(this.Cbxmanodeobra);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Txttamaño2);
			this.Controls.Add(this.Txttamaño1);
			this.Controls.Add(this.Cbxdiseño);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Seleccion1";
			this.Text = "Dimenciones";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Txtpersonas;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox Cbxmaterial;
		private System.Windows.Forms.ComboBox Cbxmanodeobra;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Txttamaño2;
		private System.Windows.Forms.TextBox Txttamaño1;
		private System.Windows.Forms.ComboBox Cbxdiseño;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
