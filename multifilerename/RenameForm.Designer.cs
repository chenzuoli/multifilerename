﻿namespace multifilerename
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rechoose_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(356, 307);
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
            this.listBox1.Location = new System.Drawing.Point(149, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 550);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Location = new System.Drawing.Point(710, 45);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(494, 550);
            this.listBox3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1235, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "确认修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rename_file
            // 
            this.rename_file.AutoSize = true;
            this.rename_file.Location = new System.Drawing.Point(27, 72);
            this.rename_file.Name = "rename_file";
            this.rename_file.Size = new System.Drawing.Size(82, 15);
            this.rename_file.TabIndex = 6;
            this.rename_file.Text = "重命名文件";
            this.rename_file.Click += new System.EventHandler(this.renamefile_Click);
            // 
            // checkBox_numOrder
            // 
            this.checkBox_numOrder.AutoSize = true;
            this.checkBox_numOrder.Location = new System.Drawing.Point(1235, 68);
            this.checkBox_numOrder.Name = "checkBox_numOrder";
            this.checkBox_numOrder.Size = new System.Drawing.Size(101, 19);
            this.checkBox_numOrder.TabIndex = 10;
            this.checkBox_numOrder.Text = "按数字前缀";
            this.checkBox_numOrder.UseVisualStyleBackColor = true;
            this.checkBox_numOrder.CheckedChanged += new System.EventHandler(this.checkBox_numOrder_CheckedChanged);
            // 
            // checkBox_charOrder
            // 
            this.checkBox_charOrder.AutoSize = true;
            this.checkBox_charOrder.Location = new System.Drawing.Point(1235, 114);
            this.checkBox_charOrder.Name = "checkBox_charOrder";
            this.checkBox_charOrder.Size = new System.Drawing.Size(101, 19);
            this.checkBox_charOrder.TabIndex = 11;
            this.checkBox_charOrder.Text = "按字母前缀";
            this.checkBox_charOrder.UseVisualStyleBackColor = true;
            this.checkBox_charOrder.CheckedChanged += new System.EventHandler(this.checkBox_charOrder_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "原文件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "新文件";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "-",
            "=",
            "?英文",
            "？中文",
            "《",
            "》",
            ">",
            "<",
            "，",
            "。",
            "、",
            "空格"});
            this.checkedListBox1.Location = new System.Drawing.Point(1238, 192);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(100, 400);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1235, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "特殊字符删除";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "->";
            // 
            // rechoose_btn
            // 
            this.rechoose_btn.Location = new System.Drawing.Point(149, 613);
            this.rechoose_btn.Name = "rechoose_btn";
            this.rechoose_btn.Size = new System.Drawing.Size(125, 23);
            this.rechoose_btn.TabIndex = 18;
            this.rechoose_btn.Text = "重新选择文件夹";
            this.rechoose_btn.UseVisualStyleBackColor = true;
            this.rechoose_btn.Click += new System.EventHandler(this.rechoose_btn_Click);
            // 
            // rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 674);
            this.Controls.Add(this.rechoose_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBox1);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rechoose_btn;
    }
}

