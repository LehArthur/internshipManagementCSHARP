using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace InternshipWindowsForm
{
    public partial class Fm_chart_event : Form
    {
        //Initialise data
        public Fm_chart_event()
        {
            InitializeComponent();
        }

        //TODO Sql requests refractor
        //TODO JE CODE AVEC LE CUL
        private void Fm_chart_event_Load(object sender, EventArgs e)
        {
            //SQL connection DB
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString =
                "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
            
            //New SQL request
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            //
            //New request open
            cmd.Connection = conn;
            //Getting events between date
            cmd.CommandText = "SELECT count(*) FROM event WHERE date BETWEEN '2011-01-01' AND '2012-01-01'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            //Events SQL variable
            string myEvents = null;
            //Read the data
            while (reader.Read())
            {
                myEvents = reader.GetString(0);
            }
            reader.Close();
            //Close connect
            conn.Close();
            
            //New request open
            MySqlCommand cmd1 = new MySqlCommand();
            conn.Open();
            cmd1.Connection = conn;
            //Getting events between date
            cmd1.CommandText = "SELECT count(*) FROM event WHERE date BETWEEN '2012-01-01' AND '2013-01-01'";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            //Events SQL variable
            string myEvents1 = null;
            //Read the data
            while (reader1.Read())
            {
                myEvents1 = reader1.GetString(0);
            }
            //Close connect
            conn.Close();
             

            //New request open
            MySqlCommand cmd2 = new MySqlCommand();
            conn.Open();
            cmd2.Connection = conn;
            //Getting events between date
            cmd2.CommandText = "SELECT count(*) FROM event WHERE date BETWEEN '2013-01-01' AND '2014-01-01'";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            //Events SQL variable
            string myEvents2 = null;
            //Read the data
            while (reader2.Read())
            {
                myEvents2 = reader2.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd3 = new MySqlCommand();
            conn.Open();
            cmd3.Connection = conn;
            //Getting events between date
            cmd3.CommandText = "SELECT count(*) FROM event WHERE date BETWEEN '2014-01-01' AND '2015-01-01'";
            cmd3.CommandType = CommandType.Text;
            cmd3.ExecuteNonQuery();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            //Events SQL variable
            string myEvents3 = null;
            //Read the data
            while (reader3.Read())
            {
                myEvents3 = reader3.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd4 = new MySqlCommand();
            conn.Open();
            cmd4.Connection = conn;
            //Getting events between date
            cmd4.CommandText = "SELECT count(*) FROM event WHERE date BETWEEN '2015-01-01' AND '2016-01-01'";
            cmd4.CommandType = CommandType.Text;
            cmd4.ExecuteNonQuery();
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            //Events SQL variable
            string myEvents4 = null;
            //Read the data
            while (reader4.Read())
            {
                myEvents4 = reader4.GetString(0);
            }
            //Close connect
            conn.Close();

            //Draw Points on chart
            chart1.Series["2011"].Points.AddXY
                //(X, Y)
                    (2012, myEvents);
            chart1.Series["2012"].Points.AddXY
                //(X, Y)
                    (2013, myEvents1);
            chart1.Series["2013"].Points.AddXY
                //(X, Y)
                    (2014, myEvents2);
            chart1.Series["2014"].Points.AddXY
                //(X, Y)
                    (2015, myEvents3);
            chart1.Series["2015"].Points.AddXY
                //(X, Y)
                    (2016, myEvents4);

            //Color of the chart, depending on how much series you have
            chart1.Series["2011"].Color = Color.Blue;
            chart1.Series["2012"].Color = Color.Red;
            chart1.Series["2013"].Color = Color.Orange;
            chart1.Series["2014"].Color = Color.Green;
            chart1.Series["2015"].Color = Color.Violet;    

            //Chart column size
            chart1.Series["2015"]["PixelPointWidth"] = "300";
            chart1.Series["2014"]["PixelPointWidth"] = "300";
            chart1.Series["2013"]["PixelPointWidth"] = "300";
            chart1.Series["2012"]["PixelPointWidth"] = "300";
            chart1.Series["2011"]["PixelPointWidth"] = "300";

            //Chart margin

            chart1.Series["2015"]["PointWidth"] = "1";
            chart1.Series["2014"]["PointWidth"] = "1";
            chart1.Series["2013"]["PointWidth"] = "1";
            chart1.Series["2012"]["PointWidth"] = "1";
            chart1.Series["2011"]["PointWidth"] = "1";

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
