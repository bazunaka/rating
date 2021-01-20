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
        private List<Kafedra> _list;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=pers_rating.db; Version=3");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = "SELECT kafedra.number FROM kafedra;";
            var rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetInt32(0));
            }
            

        }

    }

    internal class Kafedra
    {
        public int name { get; internal set; }
    }
}
