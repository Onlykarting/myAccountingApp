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
    public partial class Form_newTask : Form
    {
        public Form_newTask()
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
        private void Form_newTask_Load(object sender, EventArgs e)
        {
            names_init();
        }


        private bool validator(ref string time, string value)
        {
            //MessageBox.Show("Wrong time or time format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //time_valids
            bool valtime = false;
            bool valvalue = false;
            //format[hh]
            if (time.Length == 2)
            {
                if (Int32.TryParse(time, out int itime))
                {
                    if (itime >= 0 && itime <= 23)
                    {
                        time += ":00";
                        valtime = true;
                    }
                }
            }
            //format[hh:mm]
            else if (time.Length == 5)
            {
                if (time.IndexOf(':') != -1)
                {
                    if (Int32.TryParse((time[0]).ToString() + (time[1]).ToString(), out int hours) &&
                        Int32.TryParse((time[3]).ToString() + (time[4]).ToString(), out int minutes))
                    {
                        if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                            valtime = true;
                    }
                }
                //format[hh.mm]
                else if (time.IndexOf('.') != -1)
                {
                    if (Int32.TryParse((time[0]).ToString() + (time[1]).ToString(), out int hours) &&
                        Int32.TryParse((time[3]).ToString() + (time[4]).ToString(), out int minutes))
                    {
                        time = time.Replace('.', ':');
                        if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                            valtime = true;
                    }
                }
                

            }
            //valid value
            if (Int32.TryParse(value, out int num))
            {
                valvalue = true;
            }
            if (valvalue && valtime)
                return true;
            if (valvalue && !valtime)
                MessageBox.Show("Wrong time or time format!", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!valvalue && valtime)
                MessageBox.Show("Wrong value!", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!valvalue && !valtime)
                MessageBox.Show("Wrong input!", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private string get_pupil_id(string name)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].name == name)
                    return names[i].id;
            }
            return "-1";
        }
        private int get_names_idx(string name)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (name == names[i].name)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btn_new_task_Click(object sender, EventArgs e)
        {
            string date = datepicker.Text;
            string time = tb_time.Text;
            string value = tb_value.Text;
            string name = cb_names.Text;
            string name_id = get_pupil_id(name);
            if (!validator(ref time,value))
            {
                return;
            }

            using (var connection = new SqliteConnection("Data Source=base.db"))
            {
                connection.Open();
                SqliteCommand com = new SqliteCommand();
                com.Connection = connection;
                int number;
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
                com.CommandText = "INSERT INTO lessons (pupil_id,date,time,trans_type,value) VALUES (" + name_id + ",'" + date + "','" + time + "','Списание'," + value + ")";
                number = com.ExecuteNonQuery();
                string balance = (Int32.Parse(names[get_names_idx(name)].value) - Int32.Parse(value)).ToString();
                com.CommandText = "UPDATE pupils SET balance=" + balance + " where id=" + name_id + "";
                number = com.ExecuteNonQuery();
                MessageBox.Show("Успех!");
            }
            this.Close();
        }
        private void tb_value_click(object sender, EventArgs e)
        {
            tb_value.Text = "";
        }
        private void tb_time_click(object sender, EventArgs e)
        {
            tb_time.Text = "";
        }



    }
}
