/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 04:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace BD_ostos
{
	/// <summary>
	/// Description of Buscar_Telefono.
	/// </summary>
	public partial class Buscar_Telefono : Form
	{
		public Buscar_Telefono()
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
					try{
			
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand comando= new MySqlCommand("select * from servicios where telefono1='"+textBox1.Text+"'and estatus= abierto",conexion);
			MySqlDataAdapter adaptador= new MySqlDataAdapter();
			adaptador.SelectCommand= comando;
			DataTable tabla= new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource= tabla;
			}
						catch(Exception)
			{
				MessageBox.Show("No se encuentra el telefono");
			}
		}
	}
}
