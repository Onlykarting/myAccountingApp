using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAccountingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Form_pay newForm = new Form_pay();
            newForm.Show();
        }

        private void btn_new_task_Click(object sender, EventArgs e)
        {
            Form_newTask newTask = new Form_newTask();
            newTask.Show();
        }

        private void btn_check_list_Click(object sender, EventArgs e)
        {
            Form_lists formlist = new Form_lists();
            formlist.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
