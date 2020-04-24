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
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;

namespace BD_ostos
{
	/// <summary>
	/// Description of cambio_de_estatus.
	/// </summary>
	public partial class cambio_de_estatus : Form
	{
		public cambio_de_estatus()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		/*void TelClick(object sender, EventArgs e)
		{
								try{
				
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			conexion.Open();
			string consulta="select * from servicios where telefono1="+"'"+textBox1.Text+"'";
			MySqlCommand mycmd=new MySqlCommand();
			mycmd.Connection=conexion;
			mycmd.CommandText=consulta;
			MySqlDataReader myReader=mycmd.ExecuteReader();
			if(myReader.HasRows)
			{
				while(myReader.Read())
				{
					myReader.Read();
					textBox2.Text="Fecha alta:"+" "+myReader["fecha_alta"]+ Environment.NewLine +"fecha de baja:"+" "+myReader["fecha_baja"]+ Environment.NewLine +
						"Numero de Nota:"+" "+myReader["nota"]+ Environment.NewLine +"Remision:"+" "+myReader["remision"]+ Environment.NewLine +"Cliente:"+" "+myReader["cliente"]+Environment.NewLine +"Direccion:"+" "+myReader["domicilio"]+ Environment.NewLine +"Telefono1:"+" "+myReader["telefono1"]+ Environment.NewLine +"Telefono2:"+" "+myReader["telefono2"]+ Environment.NewLine +"Equipo:"+" "+myReader["equipo"]+ Environment.NewLine +"Marca:"+" "+myReader["marca"]+ Environment.NewLine +"Modelo:"+" "+myReader["modelo"]+ Environment.NewLine +"Falla:"+" "+myReader["falla"]+ Environment.NewLine +"Visita:"+" "+myReader["visita"]+ Environment.NewLine +"Estatus:"+" "+myReader["estatus"];
				}
			}
			conexion.Close();
			}
						catch(Exception)
			{
				MessageBox.Show("No se encuentra el telefono");
			}
		}
		void DireccionClick(object sender, EventArgs e)
		{
					try{
				textBox2.Clear();
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			conexion.Open();
			string consulta="select * from servicios where domicilio="+"'"+textBox1.Text+"'";
			MySqlCommand mycmd=new MySqlCommand();
			mycmd.Connection=conexion;
			mycmd.CommandText=consulta;
			MySqlDataReader myReader=mycmd.ExecuteReader();
			if(myReader.HasRows)
			{
				while(myReader.Read())
				{
					myReader.Read();
					textBox2.Text="Fecha alta:"+" "+myReader["fecha_alta"]+ Environment.NewLine +"fecha de baja:"+" "+myReader["fecha_baja"]+ Environment.NewLine +
						"Numero de Nota:"+" "+myReader["nota"]+ Environment.NewLine +"Remision:"+" "+myReader["remision"]+ Environment.NewLine +"Cliente:"+" "+myReader["cliente"]+Environment.NewLine +"Direccion:"+" "+myReader["domicilio"]+ Environment.NewLine +"Telefono1:"+" "+myReader["telefono1"]+ Environment.NewLine +"Telefono2:"+" "+myReader["telefono2"]+ Environment.NewLine +"Equipo:"+" "+myReader["equipo"]+ Environment.NewLine +"Marca:"+" "+myReader["marca"]+ Environment.NewLine +"Modelo:"+" "+myReader["modelo"]+ Environment.NewLine +"Falla:"+" "+myReader["falla"]+ Environment.NewLine +"Visita:"+" "+myReader["visita"]+ Environment.NewLine +"Estatus:"+" "+myReader["estatus"];
				}
			}
			conexion.Close();
			}
						catch(Exception)
			{
				MessageBox.Show("No se encontro el domicilio");
			}
		}*/
		void Boton_cierreClick(object sender, EventArgs e)
		{
			string vacio="";
		

			try{
				string fecha= DateTime.Now.ToString("MM/dd/yyyy");
						MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection(
				"server=localhost;database=ostos;uid=root;pwd='1' ");
						//string consulta ="update servicios set estatus='cerrado' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";

			//MySqlCommand insertar =new MySqlCommand(consulta,conexion);
			//conexion.Open();
			//insertar.ExecuteNonQuery();
			//conexion.Close();
			
			
			string consulta2 ="update servicios set diagnostico='"+textBox3.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar2 =new MySqlCommand(consulta2,conexion);
			conexion.Open();
			insertar2.ExecuteNonQuery();
			conexion.Close();
			
			string consulta3 ="update servicios set presupuesto='"+textBox4.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar3 =new MySqlCommand(consulta3,conexion);
			conexion.Open();
			insertar3.ExecuteNonQuery();
			conexion.Close();
			
			string consulta4 ="update servicios set garantia='"+comboBox1.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar4 =new MySqlCommand(consulta4,conexion);
			conexion.Open();
			insertar4.ExecuteNonQuery();
			conexion.Close();
			
			string consulta5 ="update servicios set tecnico1='"+textBox6.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar5 =new MySqlCommand(consulta5,conexion);
			conexion.Open();
			insertar5.ExecuteNonQuery();
			conexion.Close();
			
			string consulta6 ="update servicios set tecnico2='"+textBox7.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar6 =new MySqlCommand(consulta6,conexion);
			conexion.Open();
			insertar6.ExecuteNonQuery();
			conexion.Close();
			
			string consulta7 ="update servicios set estatus='"+comboBox2.Text+"' where domicilio="+"'"+textBox1.Text+"';"+"update servicios set fecha_baja='"+fecha+"'where domicilio="+"'"+textBox1.Text+"';";
			MySqlCommand insertar7 =new MySqlCommand(consulta7,conexion);
			if(comboBox2.Text.Contains("Cerrado"))
			   {
			   	if(!textBox3.Text.Equals(vacio) && !textBox4.Text.Equals(vacio)&&!textBox6.Text.Equals(vacio)&&!comboBox1.Text.Equals(vacio))
			   	{
			   		if(textBox7.Text.Equals(vacio))
			   		   {
			   		   	textBox7.Text="NA";
			   		   }
			   		
			   		conexion.Open();
			   		insertar7.ExecuteNonQuery();
			   		conexion.Close();
			   		MessageBox.Show("Estatus cambiado");
			   	}
			   	else
			   		MessageBox.Show("llene los campos necesarios");
			   		
			   }
			else
			{
				
			   		conexion.Open();
			   		insertar7.ExecuteNonQuery();
			   		conexion.Close();
			   		MessageBox.Show("Estatus cambiado");
				
			}
			
			
			
			}
			catch(Exception)
			{
				MessageBox.Show("Error");
			}
			

		}



		



		
	}
}
