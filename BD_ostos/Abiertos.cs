/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 06/11/2019
 * Time: 04:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_ostos
{
	/// <summary>
	/// Description of Abiertos.
	/// </summary>
	public partial class Abiertos : Form
	{
		public Abiertos()
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
			Buscar_Telefono tel= new Buscar_Telefono();
			tel.Show();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			Buscar_Domicilio bu= new Buscar_Domicilio();
			bu.Show();
	
		}
	}
}
