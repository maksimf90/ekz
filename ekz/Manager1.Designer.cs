namespace ekz
{
    partial class Manager1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.write_up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxWrite_up = new System.Windows.Forms.RichTextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxMaster = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user_name,
            this.device_type,
            this.device_name,
            this.problem,
            this.phone_number,
            this.status,
            this.write_up,
            this.master});
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 409);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Номер заявки";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Имя клиента";
            this.user_name.Name = "user_name";
            this.user_name.Width = 150;
            // 
            // device_type
            // 
            this.device_type.HeaderText = "Тип устройства";
            this.device_type.Name = "device_type";
            // 
            // device_name
            // 
            this.device_name.HeaderText = "Название устройства";
            this.device_name.Name = "device_name";
            this.device_name.Width = 120;
            // 
            // problem
            // 
            this.problem.HeaderText = "Проблема";
            this.problem.Name = "problem";
            this.problem.Width = 150;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.Name = "phone_number";
            // 
            // status
            // 
            this.status.HeaderText = "Статус заявки";
            this.status.Name = "status";
            // 
            // write_up
            // 
            this.write_up.HeaderText = "Описание работы";
            this.write_up.Name = "write_up";
            this.write_up.Width = 150;
            // 
            // master
            // 
            this.master.HeaderText = "Мастер";
            this.master.Name = "master";
            this.master.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Что требуется сделать";
            // 
            // richTextBoxWrite_up
            // 
            this.richTextBoxWrite_up.Location = new System.Drawing.Point(12, 435);
            this.richTextBoxWrite_up.Name = "richTextBoxWrite_up";
            this.richTextBoxWrite_up.Size = new System.Drawing.Size(292, 106);
            this.richTextBoxWrite_up.TabIndex = 5;
            this.richTextBoxWrite_up.Text = "";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(930, 552);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(121, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxMaster
            // 
            this.textBoxMaster.Location = new System.Drawing.Point(391, 435);
            this.textBoxMaster.Name = "textBoxMaster";
            this.textBoxMaster.Size = new System.Drawing.Size(181, 20);
            this.textBoxMaster.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назначить работника";
            // 
            // Manager1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaster);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.richTextBoxWrite_up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manager1";
            this.Text = "Manager1";
            this.Load += new System.EventHandler(this.Manager1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxWrite_up;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn write_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn master;
    }
}