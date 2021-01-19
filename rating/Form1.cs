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
            command.CommandText = "SELECT indicators.name_indicator FROM indicators";
            Console.WriteLine(command);
        }
    }
}
