using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using CM = System.Configuration.ConfigurationManager;

namespace ConfigurationManagerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                /*               
                 * string settingOne = ConfigurationManager.AppSettings["MyFirstSetting"];
                   string settingTwo = ConfigurationManager.AppSettings["MyName"];
                   string noSuchSetting = ConfigurationManager.AppSettings["NoSetting"];
                */

                string settingOne = CM.AppSettings["MyFirstSetting"];
                string settingTwo = CM.AppSettings["MyName"];
                string noSuchSetting = CM.AppSettings["NoSetting"];

                lblSetting1.Text = settingOne;
                lblSetting2.Text = settingTwo;

                if (noSuchSetting == null)
                    Debug.WriteLine("No such setting");

                int myNumber = Convert.ToInt32(CM.AppSettings["MyNumber"]); // Using CM


                Debug.WriteLine(myNumber * 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnOne_Click(object sender, EventArgs e)
        {
            /*            string connString = CM.ConnectionStrings["NorthwindConnection"].ConnectionString;
                        SqlConnection conn = new (connString);

                        try
                        {
                            conn.Open();
                            MessageBox.Show($"Connection state is {conn.State}");
                        } catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed");
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                            MessageBox.Show($"Connection state is {conn.State}");
                            conn.Dispose();
                        }*/

            ConnectToDatabase("NorthwindConnection");
        }

        private void btnConnTwo_Click(object sender, EventArgs e)
        {
            ConnectToDatabase("GEXConnection");
        }

        private void ConnectToDatabase(string connectionName)
        {
            SqlConnection conn = null;

            try
            {

                string connString = CM.ConnectionStrings[connectionName].ConnectionString;
                conn = new(connString);

                conn.Open();
                MessageBox.Show($"Connection state is {conn.State}");
            
            }catch (Exception ex)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    MessageBox.Show($"Connection state is {conn.State}");
                    conn.Dispose();
                }
            }
        }
    }
}