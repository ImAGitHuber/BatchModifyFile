namespace BatchModify
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.text_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raBtn_Yes = new System.Windows.Forms.RadioButton();
            this.raBtn_No = new System.Windows.Forms.RadioButton();
            this.comb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comb2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comb3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(20, 50);
            this.text_input.Name = "text_input";
            this.text_input.ReadOnly = true;
            this.text_input.Size = new System.Drawing.Size(328, 25);
            this.text_input.TabIndex = 0;
            this.text_input.TabStop = false;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(372, 49);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(53, 25);
            this.btn_input.TabIndex = 1;
            this.btn_input.Text = "...";
            this.btn_input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择需要批量修改的文件所在文件夹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "是否按文件类型分开进行重命名";
            // 
            // raBtn_Yes
            // 
            this.raBtn_Yes.AutoSize = true;
            this.raBtn_Yes.Checked = true;
            this.raBtn_Yes.Location = new System.Drawing.Point(277, 32);
            this.raBtn_Yes.Name = "raBtn_Yes";
            this.raBtn_Yes.Size = new System.Drawing.Size(43, 19);
            this.raBtn_Yes.TabIndex = 4;
            this.raBtn_Yes.TabStop = true;
            this.raBtn_Yes.Text = "是";
            this.raBtn_Yes.UseVisualStyleBackColor = true;
            this.raBtn_Yes.CheckedChanged += new System.EventHandler(this.raBtn_Yes_CheckedChanged);
            // 
            // raBtn_No
            // 
            this.raBtn_No.AutoSize = true;
            this.raBtn_No.Location = new System.Drawing.Point(350, 32);
            this.raBtn_No.Name = "raBtn_No";
            this.raBtn_No.Size = new System.Drawing.Size(43, 19);
            this.raBtn_No.TabIndex = 5;
            this.raBtn_No.Text = "否";
            this.raBtn_No.UseVisualStyleBackColor = true;
            this.raBtn_No.CheckedChanged += new System.EventHandler(this.raBtn_No_CheckedChanged);
            // 
            // comb1
            // 
            this.comb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb1.FormattingEnabled = true;
            this.comb1.Items.AddRange(new object[] {
            "无",
            "原文件名称",
            "数字递增（不补0）",
            "数字递增（补0）"});
            this.comb1.Location = new System.Drawing.Point(23, 96);
            this.comb1.Name = "comb1";
            this.comb1.Size = new System.Drawing.Size(164, 23);
            this.comb1.TabIndex = 6;
            this.comb1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "前部分构成";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "连接符号";
            // 
            // comb2
            // 
            this.comb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb2.FormattingEnabled = true;
            this.comb2.Items.AddRange(new object[] {
            "无",
            ".",
            "_",
            "-"});
            this.comb2.Location = new System.Drawing.Point(193, 96);
            this.comb2.Name = "comb2";
            this.comb2.Size = new System.Drawing.Size(64, 23);
            this.comb2.TabIndex = 8;
            this.comb2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "后部分构成";
            // 
            // comb3
            // 
            this.comb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb3.FormattingEnabled = true;
            this.comb3.Items.AddRange(new object[] {
            "无",
            "原文件名称",
            "数字递增（不补0）",
            "数字递增（补0）"});
            this.comb3.Location = new System.Drawing.Point(264, 97);
            this.comb3.Name = "comb3";
            this.comb3.Size = new System.Drawing.Size(164, 23);
            this.comb3.TabIndex = 10;
            this.comb3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(20, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(405, 151);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_input);
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 92);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.raBtn_Yes);
            this.groupBox2.Controls.Add(this.raBtn_No);
            this.groupBox2.Controls.Add(this.comb3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comb1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comb2);
            this.groupBox2.Location = new System.Drawing.Point(9, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 126);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重命名设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_withdraw);
            this.groupBox3.Controls.Add(this.btn_execute);
            this.groupBox3.Controls.Add(this.btn_preview);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 226);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(347, 25);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(75, 39);
            this.btn_withdraw.TabIndex = 15;
            this.btn_withdraw.Text = "撤回";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(179, 24);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 39);
            this.btn_execute.TabIndex = 14;
            this.btn_execute.Text = "执行";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(20, 25);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 38);
            this.btn_preview.TabIndex = 13;
            this.btn_preview.Text = "预览";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "旧名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 179;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "新名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 179;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "批量修改工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton raBtn_Yes;
        private System.Windows.Forms.RadioButton raBtn_No;
        private System.Windows.Forms.ComboBox comb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

