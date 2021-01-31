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
    public partial class Form2 : Form
    {

        private SQLiteConnection connect;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=pers_rating.db; Version=3");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = "SELECT sections.name_section FROM sections WHERE id = 1;";
            var rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                string name_box = rdr.GetString(0);
                name_box = char.ToUpper(name_box[0]) + name_box.Substring(1);
                groupBox1.Text = name_box;
            }
        }
    }
}
