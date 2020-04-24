/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 03:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BD_ostos
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
		void AltasClick(object sender, EventArgs e)
		{
			Altas alta=new Altas();
			alta.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Buscar bus=new Buscar();
			bus.Show();
		}
		void EstatusClick(object sender, EventArgs e)
		{
			cambio_de_estatus es= new cambio_de_estatus();
			es.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Mostrar_servicios mo= new Mostrar_servicios();
			mo.Show();
		}

		
	}
	
}
