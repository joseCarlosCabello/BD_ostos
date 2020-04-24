/*
 * Created by SharpDevelop.
 * User: Rogger
 * Date: 23/09/2019
 * Time: 03:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_ostos
{
	/// <summary>
	/// Description of Altas.
	/// </summary>
	public partial class Altas : Form
	{
		public Altas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void fechaa()
		{
			string fecha= DateTime.Now.ToString("MM/dd/yyyy");
		}
		void Button1Click(object sender, EventArgs e)
		{
			string fecha= DateTime.Now.ToString("MM/dd/yyyy");
			//string nota,remision,cliente,domicilio,telefono1,telefono2,equipo,marca,modelo,falla,visita;
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			MySqlCommand cmd;
			cmd=new MySqlCommand("agregar_animal",conexion);
			cmd.CommandType=System.Data.CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@alta",fecha);
			cmd.Parameters.AddWithValue("@baja","na");
			cmd.Parameters.AddWithValue("@notaa",this.Nota.Text);
			cmd.Parameters.AddWithValue("@re",this.Remision.Text);
			cmd.Parameters.AddWithValue("@clien",this.Cliente.Text);
			cmd.Parameters.AddWithValue("@domici",this.Domicilio.Text);
			cmd.Parameters.AddWithValue("@tel1",this.Telefono_1.Text);
			cmd.Parameters.AddWithValue("@tel2",this.Telefono_2.Text);
			cmd.Parameters.AddWithValue("@equi",this.comboBox1.Text);
			cmd.Parameters.AddWithValue("@mar",this.comboBox2.Text);
			cmd.Parameters.AddWithValue("@mode",this.Modelo.Text);
			cmd.Parameters.AddWithValue("@fa",this.Falla.Text);
			cmd.Parameters.AddWithValue("@vis",this.Visita.Text);
			cmd.Parameters.AddWithValue("@esta","alta");
			cmd.Parameters.AddWithValue("@diagnos","NA");
			cmd.Parameters.AddWithValue("@pres","NA");
			cmd.Parameters.AddWithValue("@gar","NA");
			cmd.Parameters.AddWithValue("@tec1","NA");
			cmd.Parameters.AddWithValue("@tec2","NA");
			conexion.Open();
			int res=cmd.ExecuteNonQuery();
			conexion.Close();
			/*string consulta ="INSERT INTO padres VALUES("+this.textBox1.Text + ",'"+this.textBox2.Text+"',"+this.textBox3.Text+","+this.textBox4.Text+",0);";
			MySqlCommand insertar =new MySqlCommand(consulta,conexion);
			conexion.Open();
			insertar.ExecuteNonQuery();
			conexion.Close();*/
			Nota.Text="";
			Remision.Text="";
			Cliente.Text="";
			Domicilio.Text="";
			Telefono_1.Text="";
			Telefono_2.Text="";
			comboBox1.Text="";
			comboBox2.Text="";
			Modelo.Text="";
			Falla.Text="";
			Visita.Text="";
			

		}
		void Button2Click(object sender, EventArgs e)
		{
		try{
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			conexion.Open();
			string consulta="select * from servicios where telefono1="+"'"+Telefono_1.Text+"'";
			MySqlCommand mycmd=new MySqlCommand();
			mycmd.Connection=conexion;
			mycmd.CommandText=consulta;
			MySqlDataReader myReader=mycmd.ExecuteReader();
			if(myReader.HasRows)
			{
				while(myReader.Read())
				{
					myReader.Read();
					Nota.Text=""+""+myReader["nota"];
					Remision.Text=""+""+myReader["remision"];
					Cliente.Text=""+""+myReader["cliente"];
					Domicilio.Text=""+""+myReader["domicilio"];
					Nota.Text=""+" "+myReader["nota"];
					Telefono_1.Text=""+""+myReader["telefono1"];
					Telefono_2.Text=""+""+myReader["telefono2"];
					comboBox1.Text=""+""+myReader["equipo"];
					comboBox2.Text=""+""+myReader["marca"];
					Modelo.Text=""+""+myReader["modelo"];
					Falla.Text=""+""+myReader["falla"];
					Visita.Text=""+""+myReader["visita"];
					
				}
			}
			
			conexion.Close();
			}
						catch(Exception)
			{
				MessageBox.Show("No se encontro el Telefono");
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
					try{
			MySqlConnection conexion;
			conexion= new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=ostos;uid=root;pwd='1' ");
			conexion.Open();
			string consulta="select * from servicios where cliente="+"'"+Cliente.Text+"'";
			MySqlCommand mycmd=new MySqlCommand();
			mycmd.Connection=conexion;
			mycmd.CommandText=consulta;
			MySqlDataReader myReader=mycmd.ExecuteReader();
			if(myReader.HasRows)
			{
				while(myReader.Read())
				{
					myReader.Read();
					Nota.Text=""+""+myReader["nota"];
					Remision.Text=""+""+myReader["remision"];
					Cliente.Text=""+""+myReader["cliente"];
					Domicilio.Text=""+""+myReader["domicilio"];
					Nota.Text=""+" "+myReader["nota"];
					Telefono_1.Text=""+""+myReader["telefono1"];
					Telefono_2.Text=""+""+myReader["telefono2"];
					comboBox1.Text=""+""+myReader["equipo"];
					comboBox2.Text=""+""+myReader["marca"];
					Modelo.Text=""+""+myReader["modelo"];
					Falla.Text=""+""+myReader["falla"];
					Visita.Text=""+""+myReader["visita"];
					
				}
			}
			
			conexion.Close();
			}
						catch(Exception)
			{
				MessageBox.Show("No se encontro el cliente con ese nombre");
			}
	
		}

		
	}
}
