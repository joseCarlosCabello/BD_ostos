/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 06/11/2019
 * Time: 04:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BD_ostos
{
	partial class Abiertos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 91);
			this.button1.TabIndex = 0;
			this.button1.Text = "Buscar por telefono";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(195, 150);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 91);
			this.button2.TabIndex = 1;
			this.button2.Text = "Buscar por direccion";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Abiertos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 309);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Abiertos";
			this.Text = "Abiertos";
			this.ResumeLayout(false);

		}
	}
}
