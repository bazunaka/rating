using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace rating
{
    public partial class Form1 : Form
    {

        private SQLiteConnection connect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=pers_rating.db; Version=3");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            SQLiteCommand command2 = connect.CreateCommand();
            command.CommandText = "SELECT kafedra.number FROM kafedra;";
            var rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetInt32(0));
            }

            command2.CommandText = "SELECT position.name_position FROM position;";
            var rdr_position = command2.ExecuteReader();

            while (rdr_position.Read())
            {
                comboBox2.Items.Add(rdr_position.GetString(0));
            }

        }

    }
}
