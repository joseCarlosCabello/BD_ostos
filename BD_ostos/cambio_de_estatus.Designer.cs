/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 04:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BD_ostos
{
	partial class cambio_de_estatus
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button boton_cierre;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambio_de_estatus));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.boton_cierre = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(166, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(501, 20);
			this.textBox1.TabIndex = 0;
			// 
			// boton_cierre
			// 
			this.boton_cierre.Location = new System.Drawing.Point(833, 100);
			this.boton_cierre.Name = "boton_cierre";
			this.boton_cierre.Size = new System.Drawing.Size(119, 69);
			this.boton_cierre.TabIndex = 7;
			this.boton_cierre.Text = "Actualizar estatus";
			this.boton_cierre.UseVisualStyleBackColor = true;
			this.boton_cierre.Click += new System.EventHandler(this.Boton_cierreClick);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(166, 63);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(501, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(166, 116);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(501, 20);
			this.textBox4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Domicilio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Presupuesto";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Diagnostico";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Garantia";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Tecnico 1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(21, 268);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Tecnico 2";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(166, 219);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(501, 20);
			this.textBox6.TabIndex = 5;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(166, 265);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(501, 20);
			this.textBox7.TabIndex = 6;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"N/A",
			"1 mes",
			"2 meses",
			"3 meses",
			"6 meses",
			"1 anio"});
			this.comboBox1.Location = new System.Drawing.Point(164, 174);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(503, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Estatus";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"Taller",
			"Pendiente por refaccion",
			"Cerrado"});
			this.comboBox2.Location = new System.Drawing.Point(166, 309);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(501, 21);
			this.comboBox2.TabIndex = 16;
			// 
			// cambio_de_estatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1122, 334);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.boton_cierre);
			this.Controls.Add(this.textBox1);
			this.Name = "cambio_de_estatus";
			this.Text = "cambio_de_estatus";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
