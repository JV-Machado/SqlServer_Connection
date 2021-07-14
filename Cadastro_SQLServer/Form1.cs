using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro_SQLServer
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=LAPTOP-GJHCSDBT;Database=Customer;User Id=Id;Password=Password;");

                strSQL = "INSERT INTO Regis_Customer (NAME, NUMBER) VALUES (@NAME, @NUMBER)";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@NAME", txtName.Text);
                command.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
            
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=LAPTOP-GJHCSDBT;Database=Customer;User Id=Id;Password=Password;");

                strSQL = "UPDATE Regis_Customer SET NAME = @NAME, NUMBER = @NUMBER WHERE ID = @ID";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID", txtId.Text);
                command.Parameters.AddWithValue("@NAME", txtName.Text);
                command.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Btn_Consult_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=LAPTOP-GJHCSDBT;Database=Customer;User Id=Id;Password=Password;");

                strSQL = "SELECT * FROM Regis_Customer WHERE ID = @ID";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID", txtId.Text);

                connection.Open();

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    txtName.Text = Convert.ToString(dr["name"]);
                    txtNumber.Text = Convert.ToString(dr["number"]);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=LAPTOP-GJHCSDBT;Database=Customer;User Id=Id;Password=Password;");

                strSQL = "SELECT * FROM Regis_Customer";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, connection);

                da.Fill(ds);

                dgvData.DataSource = ds.Tables[0];
         
                connection.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=LAPTOP-GJHCSDBT;Database=Customer;User Id=Id;Password=Password;");

                strSQL = "DELETE Regis_Customer WHERE ID = @ID";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@Id", txtId.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }

}
