using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InternshipWindowsForm
{
    public partial class Fm_Journal_Actions : Form
    {
        public Fm_Journal_Actions()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       

        private void Fm_Journal_Actions_Load(object sender, EventArgs e)
        {
            //Date time 

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
            cmd.CommandText = "SELECT DATE_FORMAT(date, '%Y-%m-%d'), COUNT(*) FROM journal WHERE date between SUBDATE(curdate(), 4) and ADDDATE(curdate(), 1) GROUP BY DATE_FORMAT(date, '%Y-%m-%d')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<int> Myjournals = new List<int>();
            List<string> myJournalsText = new List<string>();
            List<Color> myColors = new List<Color>();
            myColors.Add(Color.Brown);
            myColors.Add(Color.Red);
            myColors.Add(Color.Orange);
            myColors.Add(Color.Green);
            myColors.Add(Color.Blue);
            myColors.Add(Color.BurlyWood);
            myColors.Add(Color.Orchid);
            //Events SQL variable
            //Read the data

            while (reader.Read())
            {
                Myjournals.Add(reader.GetInt32(1));
                myJournalsText.Add(reader.GetString(0));
            }

            int listRange = Myjournals.Count;

            for (int i = 0; i < listRange; i++)
            {
                //OUIOUIOUI
                chart1.Series[i].Points.AddXY("", Myjournals[i]);
                //Colors
                chart1.Series[i].Color = myColors[i];
                chart1.Series[i]["PixelPointWidth"] = "600";

            }

            label11.Text = myJournalsText[0].ToString();
            
            label12.Text = myJournalsText[1].ToString();
            label13.Text = myJournalsText[2].ToString();
            label14.Text = myJournalsText[3].ToString();
            label15.Text = myJournalsText[4].ToString();
            reader.Close();
            //Close connect
            conn.Close();
            /*
            //New request open
            MySqlCommand cmd1 = new MySqlCommand();
            conn.Open();
            cmd1.Connection = conn;
            //Getting events between date
            cmd1.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2012-01-01' AND '2013-01-01'";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            //Events SQL variable
            string myJournal1 = null;
            //Read the data
            while (reader1.Read())
            {
                myJournal1 = reader1.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd2 = new MySqlCommand();
            conn.Open();
            cmd2.Connection = conn;
            //Getting events between date
            cmd2.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2013-01-01' AND '2014-01-01'";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            //Events SQL variable
            string myJournal2 = null;
            //Read the data
            while (reader2.Read())
            {
                myJournal2 = reader2.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd3 = new MySqlCommand();
            conn.Open();
            cmd3.Connection = conn;
            //Getting events between date
            cmd3.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2014-01-01' AND '2015-01-01'";
            cmd3.CommandType = CommandType.Text;
            cmd3.ExecuteNonQuery();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            //Events SQL variable
            string myJournal3 = null;
            //Read the data
            while (reader3.Read())
            {
                myJournal3 = reader3.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd4 = new MySqlCommand();
            conn.Open();
            cmd4.Connection = conn;
            //Getting events between date
            cmd4.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2015-01-01' AND '2016-01-01'";
            cmd4.CommandType = CommandType.Text;
            cmd4.ExecuteNonQuery();
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            //Events SQL variable
            string myJournal4 = null;
            //Read the data
            while (reader4.Read())
            {
                myJournal4 = reader4.GetString(0);
            }
            //Close connect
            conn.Close();
            
            /*
            //New request open
            MySqlCommand cmd5 = new MySqlCommand();
            conn.Open();
            cmd5.Connection = conn;
            //Getting events between date
            cmd5.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2012-01-01' AND '2013-01-01'";
            cmd5.CommandType = CommandType.Text;
            cmd5.ExecuteNonQuery();
            MySqlDataReader reader5 = cmd5.ExecuteReader();
            //Events SQL variable
            string myJournal5 = null;
            //Read the data
            while (reader5.Read())
            {
                myJournal5 = reader1.GetString(0);
            }
            //Close connect
            conn.Close();

            //New request open
            MySqlCommand cmd6 = new MySqlCommand();
            conn.Open();
            cmd6.Connection = conn;
            //Getting events between date
            cmd6.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2012-01-01' AND '2013-01-01'";
            cmd6.CommandType = CommandType.Text;
            cmd6.ExecuteNonQuery();
            MySqlDataReader reader6 = cmd6.ExecuteReader();
            //Events SQL variable
            string myJournal6 = null;
            //Read the data
            while (reader6.Read())
            {
                myJournal6 = reader6.GetString(0);
            }
            //Close connect
            conn.Close();
            
            //New request open
            MySqlCommand cmd7 = new MySqlCommand();
            conn.Open();
            cmd6.Connection = conn;
            //Getting events between date
            cmd6.CommandText = "SELECT count(*) FROM journal WHERE date BETWEEN '2012-01-01' AND '2013-01-01'";
            cmd6.CommandType = CommandType.Text;
            cmd6.ExecuteNonQuery();
            MySqlDataReader reader7 = cmd7.ExecuteReader();
            //Events SQL variable
            string myJournal7 = null;
            //Read the data
            while (reader7.Read())
            {
                myJournal7 = reader7.GetString(0);
            }
            //Close connect
            conn.Close();
             */


            /*
            //Draw Points on chart
            chart1.Series["Il y a 7 jours"].Points.AddXY
                //(X, Y)
                    (2011, Myjournals[0]);
            chart1.Series["Il y a 6 jours"].Points.AddXY
                //(X, Y)
                    (2012, Myjournals[1]);
            chart1.Series["Il y a 5 jours"].Points.AddXY
                //(X, Y)
                    (2013, Myjournals[2]);
            chart1.Series["Il y a 4 jours"].Points.AddXY
                //(X, Y)
                    (2014, Myjournals[3]);
            chart1.Series["Il y a 3 jours"].Points.AddXY
                //(X, Y)
                    (2015, Myjournals[4]);
            
            /*chart1.Series["Il y a 3 jours"].Points.AddXY
                //(X, Y)
                   (2015, myJournal5);
            chart1.Series["Il y a 2 jours"].Points.AddXY
                //(X, Y)
                   (2015, myJournal5);
            chart1.Series["Hier"].Points.AddXY
                //(X, Y)
                   (2015, myJournal6);*/

            //Color of the chart, depending on how much series you have
            //chart1.Series["Il y a 7 jours"].Color = Color.DeepSkyBlue;
            //chart1.Series["Il y a 6 jours"].Color = Color.CadetBlue;
            //chart1.Series["Il y a 5 jours"].Color = Color.Chocolate;
            //chart1.Series["Il y a 4 jours"].Color = Color.Brown;
            //chart1.Series["Il y a 3 jours"].Color = Color.DimGray;
            //chart1.Series["Il y a 2 jours"].Color = Color.DimGray;
            //chart1.Series["Il y a 1 jours"].Color = Color.DimGray;  
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
