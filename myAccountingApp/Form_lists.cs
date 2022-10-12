using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace myAccountingApp
{
    public partial class Form_lists : Form
    {
        public Form_lists()
        {
            InitializeComponent();
        }
        struct Pupils
        {
            public string id;
            public string name;
            public string value;

        }

        List<Pupils> names = new List<Pupils>();

        private void Form_lists_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pupils". При необходимости она может быть перемещена или удалена.
            this.pupilsTableAdapter.Fill(this.dataSet1.pupils);
            string sqlExpression = "SELECT * FROM pupils";
            using (var connection = new SqliteConnection("Data Source=base.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pupils xra;
                            xra.id = (reader.GetValue(0).ToString());
                            xra.name = (reader.GetValue(1).ToString());
                            xra.value = (reader.GetValue(2).ToString());
                            names.Add(xra);
                        }
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                //lb_names.Items.Add(names[i].name);
                //lb_values.Items.Add(names[i].value);
            }
            

        }
    }
}
