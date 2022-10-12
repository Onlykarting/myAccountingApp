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
    
    public partial class Form_pay : Form
    {
        struct Pupils
        {
            public string id;
            public string name;
            public string value;
        
        }

        List<Pupils> names = new List<Pupils>();
        public Form_pay()
        {
            InitializeComponent();
        }
        private void tb_click(object sender, EventArgs e)
        {
            tb_value.Text = "";
        }
        private void names_init()
        {
            names.Clear();
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
                cb_names.Items.Add(names[i].name);
            }
        }
        private void Form_pay_Load(object sender, EventArgs e)
        {
            names_init();
        }

        private string get_pupil_id(string name)
        {
            for (int i =0;i<names.Count;i++)
            {
                if (names[i].name == name)
                    return names[i].id;
            }
            return "-1";
        }
        private string[] get_date_time()
        {
            string datetime = (DateTime.Now).ToString();
            int sep = 0;
            for (int i =0;i<datetime.Length;i++)
            {
                if (datetime[i]==' ')
                {
                    sep = i;
                }
            }
            string date = datetime.Substring(0, sep + 1);
            string time = datetime.Substring(sep + 1);
            if (time.IndexOf(':') != 2)
                time = "0" + time;
            time = time.Substring(0, 5);
            string[] dt = { date, time };
            return dt;
        }
        private int get_names_idx(string name)
        {
            for (int i = 0;i<names.Count;i++)
            {
                if (name == names[i].name)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {



            using (var connection = new SqliteConnection("Data Source=base.db"))
            {
                connection.Open();
                SqliteCommand com = new SqliteCommand();
                com.Connection = connection;
                int number;
                //com.CommandText = "INSERT INTO pupils (name, balance) VALUES ('Nikita', 1000)";
                string name = cb_names.Text;
                string name_id = get_pupil_id(name);
                if (name_id == "-1")
                {
                    DialogResult res = MessageBox.Show("Хотите добавить новое имя?", "Unknown name!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        com.CommandText = "INSERT INTO pupils (name, balance) VALUES ('" + name + "', 0)";
                        number = com.ExecuteNonQuery();
                        connection.Close();
                        connection.Open();
                        com = new SqliteCommand();
                        com.Connection = connection;
                        names_init();
                        name_id = get_pupil_id(name);
                    }
                }
                string[] datetime = get_date_time();
                string value = tb_value.Text;
                string balance = (Int32.Parse(names[get_names_idx(name)].value) + Int32.Parse(value)).ToString();
                com.CommandText = "INSERT INTO lessons (pupil_id,date,time,trans_type,value) VALUES ("+name_id+",'"+datetime[0]+"','"+datetime[1]+"','Пополнение'," + value + ")";
                number = com.ExecuteNonQuery();
                com.CommandText = "UPDATE pupils SET balance="+balance+" where id="+name_id+"";
                number = com.ExecuteNonQuery();
                MessageBox.Show("Успех!");
            }
            this.Close();
        }

        
    }
}
