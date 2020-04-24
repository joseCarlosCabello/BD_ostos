/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 06/11/2019
 * Time: 05:14 p. m.
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
	/// Description of Mostrar_servicios.
	/// </summary>
	public partial class Mostrar_servicios : Form
	{
		public Mostrar_servicios()
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
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand comando= new MySqlCommand("select * from servicios where estatus='alta'",conexion);
			MySqlDataAdapter adaptador= new MySqlDataAdapter();
			adaptador.SelectCommand= comando;
			DataTable tabla= new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource= tabla;
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand comando= new MySqlCommand("select * from servicios where estatus='Taller'",conexion);
			MySqlDataAdapter adaptador= new MySqlDataAdapter();
			adaptador.SelectCommand= comando;
			DataTable tabla= new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource= tabla;
		}
		void Button3Click(object sender, EventArgs e)
		{
				MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand comando= new MySqlCommand("select * from servicios where estatus='Pendiente por refaccion'",conexion);
			MySqlDataAdapter adaptador= new MySqlDataAdapter();
			adaptador.SelectCommand= comando;
			DataTable tabla= new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource= tabla;
		}
		void Button4Click(object sender, EventArgs e)
		{
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand comando= new MySqlCommand("select * from servicios where estatus='cerrado'",conexion);
			MySqlDataAdapter adaptador= new MySqlDataAdapter();
			adaptador.SelectCommand= comando;
			DataTable tabla= new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource= tabla;
		}
	}
}
