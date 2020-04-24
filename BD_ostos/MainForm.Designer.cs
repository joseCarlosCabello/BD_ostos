/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 03:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BD_ostos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Altas;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button estatus;
		private System.Windows.Forms.Button button2;
		
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
			this.Altas = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.estatus = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Altas
			// 
			this.Altas.Location = new System.Drawing.Point(49, 22);
			this.Altas.Name = "Altas";
			this.Altas.Size = new System.Drawing.Size(138, 38);
			this.Altas.TabIndex = 0;
			this.Altas.Text = "Altas";
			this.Altas.UseVisualStyleBackColor = true;
			this.Altas.Click += new System.EventHandler(this.AltasClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(49, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// estatus
			// 
			this.estatus.Location = new System.Drawing.Point(49, 159);
			this.estatus.Name = "estatus";
			this.estatus.Size = new System.Drawing.Size(138, 50);
			this.estatus.TabIndex = 2;
			this.estatus.Text = "Cambio de estatus";
			this.estatus.UseVisualStyleBackColor = true;
			this.estatus.Click += new System.EventHandler(this.EstatusClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(49, 225);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 50);
			this.button2.TabIndex = 3;
			this.button2.Text = "Ver servicios";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(228, 299);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.estatus);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Altas);
			this.Name = "MainForm";
			this.Text = "BD_ostos";
			this.ResumeLayout(false);

		}
	}
}
