
namespace myAccountingApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_new_task = new System.Windows.Forms.Button();
            this.btn_check_list = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pay.Location = new System.Drawing.Point(12, 12);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(233, 50);
            this.btn_pay.TabIndex = 0;
            this.btn_pay.Text = "Оплатить занятие";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_new_task
            // 
            this.btn_new_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_new_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_task.Location = new System.Drawing.Point(12, 68);
            this.btn_new_task.Name = "btn_new_task";
            this.btn_new_task.Size = new System.Drawing.Size(233, 55);
            this.btn_new_task.TabIndex = 1;
            this.btn_new_task.Text = "Провести занятие";
            this.btn_new_task.UseVisualStyleBackColor = false;
            this.btn_new_task.Click += new System.EventHandler(this.btn_new_task_Click);
            // 
            // btn_check_list
            // 
            this.btn_check_list.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_check_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_check_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_check_list.Location = new System.Drawing.Point(12, 130);
            this.btn_check_list.Name = "btn_check_list";
            this.btn_check_list.Size = new System.Drawing.Size(233, 52);
            this.btn_check_list.TabIndex = 2;
            this.btn_check_list.Text = "чек-лист";
            this.btn_check_list.UseVisualStyleBackColor = false;
            this.btn_check_list.Click += new System.EventHandler(this.btn_check_list_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.LightCoral;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_exit.Location = new System.Drawing.Point(12, 188);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(233, 52);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Выход";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(259, 263);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.btn_check_list);
            this.Controls.Add(this.btn_new_task);
            this.Controls.Add(this.btn_pay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_new_task;
        private System.Windows.Forms.Button btn_check_list;
        private System.Windows.Forms.Button bt_exit;
    }
}

