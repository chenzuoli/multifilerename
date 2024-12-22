namespace multifilerename
{
    partial class rename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rename));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rename_file = new System.Windows.Forms.Label();
            this.checkBox_numOrder = new System.Windows.Forms.CheckBox();
            this.checkBox_charOrder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rechoose_btn = new System.Windows.Forms.Button();
            this.custom_prefix = new System.Windows.Forms.Label();
            this.custom_subfix = new System.Windows.Forms.Label();
            this.customPrefixBox = new System.Windows.Forms.TextBox();
            this.customSubfixBox = new System.Windows.Forms.TextBox();
            this.textBeforeBox = new System.Windows.Forms.TextBox();
            this.textAfterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_charOrderSubfix = new System.Windows.Forms.CheckBox();
            this.checkBox_numOrderSubfix = new System.Windows.Forms.CheckBox();
            this.rename_folder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(242, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件夹";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(35, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 522);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Location = new System.Drawing.Point(601, 86);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(507, 522);
            this.listBox3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(1135, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "确认修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rename_file
            // 
            this.rename_file.AutoSize = true;
            this.rename_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rename_file.Font = new System.Drawing.Font("宋体", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rename_file.Location = new System.Drawing.Point(32, 20);
            this.rename_file.Name = "rename_file";
            this.rename_file.Padding = new System.Windows.Forms.Padding(2);
            this.rename_file.Size = new System.Drawing.Size(93, 21);
            this.rename_file.TabIndex = 6;
            this.rename_file.Text = "重命名文件";
            this.rename_file.Click += new System.EventHandler(this.renamefile_Click);
            // 
            // checkBox_numOrder
            // 
            this.checkBox_numOrder.AutoSize = true;
            this.checkBox_numOrder.Location = new System.Drawing.Point(1139, 86);
            this.checkBox_numOrder.Name = "checkBox_numOrder";
            this.checkBox_numOrder.Size = new System.Drawing.Size(131, 19);
            this.checkBox_numOrder.TabIndex = 10;
            this.checkBox_numOrder.Text = "按数字顺序前缀";
            this.checkBox_numOrder.UseVisualStyleBackColor = true;
            this.checkBox_numOrder.CheckedChanged += new System.EventHandler(this.checkBox_numOrder_CheckedChanged);
            // 
            // checkBox_charOrder
            // 
            this.checkBox_charOrder.AutoSize = true;
            this.checkBox_charOrder.Location = new System.Drawing.Point(1139, 111);
            this.checkBox_charOrder.Name = "checkBox_charOrder";
            this.checkBox_charOrder.Size = new System.Drawing.Size(131, 19);
            this.checkBox_charOrder.TabIndex = 11;
            this.checkBox_charOrder.Text = "按字母顺序前缀";
            this.checkBox_charOrder.UseVisualStyleBackColor = true;
            this.checkBox_charOrder.CheckedChanged += new System.EventHandler(this.checkBox_charOrder_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "原文件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "新文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1133, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "任意字符替换";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "->";
            // 
            // rechoose_btn
            // 
            this.rechoose_btn.Font = new System.Drawing.Font("宋体", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rechoose_btn.Location = new System.Drawing.Point(35, 626);
            this.rechoose_btn.Name = "rechoose_btn";
            this.rechoose_btn.Size = new System.Drawing.Size(125, 23);
            this.rechoose_btn.TabIndex = 18;
            this.rechoose_btn.Text = "重新选择文件夹";
            this.rechoose_btn.UseVisualStyleBackColor = true;
            this.rechoose_btn.Click += new System.EventHandler(this.rechoose_btn_Click);
            // 
            // custom_prefix
            // 
            this.custom_prefix.AutoSize = true;
            this.custom_prefix.Location = new System.Drawing.Point(1135, 136);
            this.custom_prefix.Name = "custom_prefix";
            this.custom_prefix.Size = new System.Drawing.Size(82, 15);
            this.custom_prefix.TabIndex = 19;
            this.custom_prefix.Text = "自定义前缀";
            // 
            // custom_subfix
            // 
            this.custom_subfix.AutoSize = true;
            this.custom_subfix.Location = new System.Drawing.Point(1132, 263);
            this.custom_subfix.Name = "custom_subfix";
            this.custom_subfix.Size = new System.Drawing.Size(82, 15);
            this.custom_subfix.TabIndex = 20;
            this.custom_subfix.Text = "自定义后缀";
            // 
            // customPrefixBox
            // 
            this.customPrefixBox.Location = new System.Drawing.Point(1135, 154);
            this.customPrefixBox.Name = "customPrefixBox";
            this.customPrefixBox.Size = new System.Drawing.Size(100, 23);
            this.customPrefixBox.TabIndex = 21;
            this.customPrefixBox.TextChanged += new System.EventHandler(this.customPrefixBox_TextChanged);
            // 
            // customSubfixBox
            // 
            this.customSubfixBox.Location = new System.Drawing.Point(1136, 281);
            this.customSubfixBox.Name = "customSubfixBox";
            this.customSubfixBox.Size = new System.Drawing.Size(100, 23);
            this.customSubfixBox.TabIndex = 22;
            this.customSubfixBox.TextChanged += new System.EventHandler(this.customSubfixBox_TextChanged);
            // 
            // textBeforeBox
            // 
            this.textBeforeBox.Location = new System.Drawing.Point(1135, 362);
            this.textBeforeBox.Name = "textBeforeBox";
            this.textBeforeBox.Size = new System.Drawing.Size(100, 23);
            this.textBeforeBox.TabIndex = 23;
            this.textBeforeBox.TextChanged += new System.EventHandler(this.textBefore_TextChanged);
            // 
            // textAfterBox
            // 
            this.textAfterBox.Location = new System.Drawing.Point(1259, 362);
            this.textAfterBox.Name = "textAfterBox";
            this.textAfterBox.Size = new System.Drawing.Size(86, 23);
            this.textAfterBox.TabIndex = 24;
            this.textAfterBox.TextChanged += new System.EventHandler(this.textAfter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1235, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "->";
            // 
            // checkBox_charOrderSubfix
            // 
            this.checkBox_charOrderSubfix.AutoSize = true;
            this.checkBox_charOrderSubfix.Location = new System.Drawing.Point(1135, 241);
            this.checkBox_charOrderSubfix.Name = "checkBox_charOrderSubfix";
            this.checkBox_charOrderSubfix.Size = new System.Drawing.Size(131, 19);
            this.checkBox_charOrderSubfix.TabIndex = 27;
            this.checkBox_charOrderSubfix.Text = "按字母顺序后缀";
            this.checkBox_charOrderSubfix.UseVisualStyleBackColor = true;
            this.checkBox_charOrderSubfix.CheckedChanged += new System.EventHandler(this.checkBox_charOrderSubfix_CheckedChanged);
            // 
            // checkBox_numOrderSubfix
            // 
            this.checkBox_numOrderSubfix.AutoSize = true;
            this.checkBox_numOrderSubfix.Location = new System.Drawing.Point(1135, 216);
            this.checkBox_numOrderSubfix.Name = "checkBox_numOrderSubfix";
            this.checkBox_numOrderSubfix.Size = new System.Drawing.Size(131, 19);
            this.checkBox_numOrderSubfix.TabIndex = 26;
            this.checkBox_numOrderSubfix.Text = "按数字顺序后缀";
            this.checkBox_numOrderSubfix.UseVisualStyleBackColor = true;
            this.checkBox_numOrderSubfix.CheckedChanged += new System.EventHandler(this.checkBox_numOrderSubfix_CheckedChanged);
            // 
            // rename_folder
            // 
            this.rename_folder.AutoSize = true;
            this.rename_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rename_folder.Font = new System.Drawing.Font("宋体", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rename_folder.Location = new System.Drawing.Point(153, 20);
            this.rename_folder.Name = "rename_folder";
            this.rename_folder.Padding = new System.Windows.Forms.Padding(2);
            this.rename_folder.Size = new System.Drawing.Size(109, 21);
            this.rename_folder.TabIndex = 28;
            this.rename_folder.Text = "重命名文件夹";
            this.rename_folder.Click += new System.EventHandler(this.renamefolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("宋体", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(290, 20);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2);
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "批量删除";
            // 
            // rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rename_folder);
            this.Controls.Add(this.checkBox_charOrderSubfix);
            this.Controls.Add(this.checkBox_numOrderSubfix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAfterBox);
            this.Controls.Add(this.textBeforeBox);
            this.Controls.Add(this.customSubfixBox);
            this.Controls.Add(this.customPrefixBox);
            this.Controls.Add(this.custom_subfix);
            this.Controls.Add(this.custom_prefix);
            this.Controls.Add(this.rechoose_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_charOrder);
            this.Controls.Add(this.checkBox_numOrder);
            this.Controls.Add(this.rename_file);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rename";
            this.Text = "乐知软件-批量重命名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label rename_file;
        private System.Windows.Forms.CheckBox checkBox_numOrder;
        private System.Windows.Forms.CheckBox checkBox_charOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rechoose_btn;
        private System.Windows.Forms.Label custom_prefix;
        private System.Windows.Forms.Label custom_subfix;
        private System.Windows.Forms.TextBox customPrefixBox;
        private System.Windows.Forms.TextBox customSubfixBox;
        private System.Windows.Forms.TextBox textBeforeBox;
        private System.Windows.Forms.TextBox textAfterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_charOrderSubfix;
        private System.Windows.Forms.CheckBox checkBox_numOrderSubfix;
        private System.Windows.Forms.Label rename_folder;
        private System.Windows.Forms.Label label6;
    }
}

