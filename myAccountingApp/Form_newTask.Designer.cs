
namespace myAccountingApp
{
    partial class Form_newTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_new_task = new System.Windows.Forms.Button();
            this.cb_names = new System.Windows.Forms.ComboBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_new_task
            // 
            this.btn_new_task.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_new_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_task.Location = new System.Drawing.Point(39, 238);
            this.btn_new_task.Name = "btn_new_task";
            this.btn_new_task.Size = new System.Drawing.Size(231, 31);
            this.btn_new_task.TabIndex = 0;
            this.btn_new_task.Text = "Добавить";
            this.btn_new_task.UseVisualStyleBackColor = false;
            this.btn_new_task.Click += new System.EventHandler(this.btn_new_task_Click);
            // 
            // cb_names
            // 
            this.cb_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_names.FormattingEnabled = true;
            this.cb_names.Location = new System.Drawing.Point(39, 61);
            this.cb_names.Name = "cb_names";
            this.cb_names.Size = new System.Drawing.Size(231, 33);
            this.cb_names.TabIndex = 1;
            this.cb_names.Text = "Имя";
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_value.Location = new System.Drawing.Point(39, 174);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(231, 31);
            this.tb_value.TabIndex = 3;
            this.tb_value.Text = "Стоимость занятия";
            this.tb_value.Click += new System.EventHandler(this.tb_value_click);
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(39, 100);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(231, 31);
            this.datepicker.TabIndex = 4;
            // 
            // tb_time
            // 
            this.tb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_time.Location = new System.Drawing.Point(39, 137);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(231, 31);
            this.tb_time.TabIndex = 5;
            this.tb_time.Text = "Время";
            this.tb_time.Click += new System.EventHandler(this.tb_time_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Новое занятие";
            // 
            // Form_newTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(319, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.cb_names);
            this.Controls.Add(this.btn_new_task);
            this.Name = "Form_newTask";
            this.Text = "Form_newTask";
            this.Load += new System.EventHandler(this.Form_newTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new_task;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_names;
    }
}