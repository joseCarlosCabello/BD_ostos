/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 06/11/2019
 * Time: 05:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BD_ostos
{
	partial class Mostrar_servicios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Altas";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(113, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Taller";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(209, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Pendiente refaccion";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(297, 23);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 34);
			this.button4.TabIndex = 3;
			this.button4.Text = "Cerrados";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.Location = new System.Drawing.Point(21, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(350, 250);
			this.dataGridView1.TabIndex = 4;
			// 
			// Mostrar_servicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 341);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Mostrar_servicios";
			this.Text = "Mostrar_servicios";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
