
namespace myAccountingApp
{
    partial class Form_pay
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
            this.btn_pay = new System.Windows.Forms.Button();
            this.cb_names = new System.Windows.Forms.ComboBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_pay.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_pay.FlatAppearance.BorderSize = 0;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pay.Location = new System.Drawing.Point(22, 153);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pay.Size = new System.Drawing.Size(231, 31);
            this.btn_pay.TabIndex = 0;
            this.btn_pay.Text = "Внести";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // cb_names
            // 
            this.cb_names.BackColor = System.Drawing.SystemColors.Window;
            this.cb_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_names.FormattingEnabled = true;
            this.cb_names.Location = new System.Drawing.Point(22, 57);
            this.cb_names.Name = "cb_names";
            this.cb_names.Size = new System.Drawing.Size(231, 33);
            this.cb_names.TabIndex = 1;
            this.cb_names.Text = "Имя";
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_value.Location = new System.Drawing.Point(22, 96);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(231, 31);
            this.tb_value.TabIndex = 2;
            this.tb_value.Text = "Сумма для внесения";
            this.tb_value.Click += new System.EventHandler(this.tb_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оплата";
            // 
            // Form_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(289, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.cb_names);
            this.Controls.Add(this.btn_pay);
            this.Name = "Form_pay";
            this.Text = "Оплата занятия";
            this.Load += new System.EventHandler(this.Form_pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ComboBox cb_names;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label label1;
    }
}