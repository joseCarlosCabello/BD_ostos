/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 04:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_ostos
{
	/// <summary>
	/// Description of Buscar.
	/// </summary>
	public partial class Buscar : Form
	{
		public Buscar()
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
			Buscar_Telefono b= new Buscar_Telefono();
			b.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Buscar_Domicilio bus= new Buscar_Domicilio();
			bus.Show();
		
		}
	}
}
