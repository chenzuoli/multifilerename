using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using multifilerename.util;
using System.Linq;

namespace multifilerename
{
    public partial class rename : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private int cate_id;
        public rename()
        {
            InitializeComponent();
            folderBrowserDialog = new FolderBrowserDialog();
            // checkBox_numOrder.Checked = true;
            // 默认重命名文件
            this.rename_file.BorderStyle = BorderStyle.Fixed3D;
            cate_id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 选择文件夹
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 列出选择的文件夹内的所有文件
                listBox1.Items.Clear();
                listBox3.Items.Clear();

                if (this.cate_id == 0)
                {
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    // 列出所有更改后的文件名，按照顺序一次在文件前新增数字序号
                    for (int i = 0; i < files.Length; i++)
                    {
                        String fileName = Path.GetFileName(files[i]);
                        listBox1.Items.Add(fileName);
                        listBox3.Items.Add(fileName);
                    }
                } else if (this.cate_id == 1)
                {
                    string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(dirs[i]);
                        listBox1.Items.Add(dirInfo.Name);
                        listBox3.Items.Add(dirInfo.Name);
                    }
                }

                confirmRenameBtn.Enabled = true;

                // 隐藏btn1
                choose_btn.Visible = false;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void renameFile()
        {
            List<string> newFiles = RenameFile.renameRuleChange(
                checkBox_numOrder, checkBox_charOrder, checkBox_numOrderSubfix, checkBox_charOrderSubfix,
                listBox1, listBox3,
                customPrefixBox, customSubfixBox,
                textBeforeBox, textAfterBox);
            listBox3.Items.Clear();
            if (newFiles.Count > 0)
            {
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
            else
            {
                listBox1.Items.Cast<string>().ToList().ForEach(item => listBox3.Items.Add(item));
            }
        }

        private void checkBox_charOrder_CheckedChanged(object sender, EventArgs e)
        {
            renameFile();

            // 修改文件夹名称，按照字母前缀 添加
            //if (checkBox_charOrder.Checked)
            //{
            //    newFiles = RenameFile.renameRuleChange(listBox1,
            //        customPrefixBox, customSubfixBox,
            //        textBeforeBox, textAfterBox);
            //}
            //else
            //{
                // 通过重新命名的方式，而不是remove已有的listBox3中的文件名
                //for (int i = 0; i < listBox3.Items.Count; i++)
                //{
                //    // 将前缀字母删除
                //    char initChar = 'a';
                //    int addNum = i % 26;
                //    char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                //    // 这里有bug，当文件原名中包含了字母下划线时，可能会误替换
                //    //string newFileName =  listBox3.Items[i].ToString().Replace(b.ToString() + "_", "");
                //    string item = listBox3.Items[i].ToString();
                //    string prefix = b.ToString() + "_";
                //    if (item.StartsWith(prefix))
                //    {
                //        string newFileName = item.Substring(prefix.Length);
                //        newFiles.Add(newFileName);
                //    } else
                //    {
                //        newFiles.Add(item);
                //    }
                //}
                //listBox3.Items.Clear();
                //newFiles.ForEach(item => listBox3.Items.Add(item));
            //}
        }

        private void checkBox_numOrder_CheckedChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 修改了数字前缀 checkbox
            //List<string> newFiles = new List<string>();

            //// 修改文件夹名称，按照数字前缀 添加
            //int initNum = 1;
            //if (checkBox_numOrder.Checked)
            //{
            //    newFiles = RenameFile.renameNumPrefix(listBox1, listBox3);
            //}
            //else
            //{
            //    for (int i = 0; i < listBox3.Items.Count; i++)
            //    {
            //        // 将数字前缀删除
            //        string item = listBox3.Items[i].ToString();
            //        string prefix = (i + initNum) + "_";
            //        if (item.StartsWith(prefix))
            //        {
            //            string newFileName = item.Substring(prefix.Length);
            //            newFiles.Add(newFileName);
            //        } else
            //        {
            //            newFiles.Add(item);
            //        }
            //    }
            //    listBox3.Items.Clear();
            //    newFiles.ForEach(item => listBox3.Items.Add(item));
            //}
        }

        //private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // 选中了其中一个，
        //    List<object> inds = new List<object>();
        //    for (int i = 0; i < checkedListBox1.Items.Count; i++)
        //    {
        //        if (checkedListBox1.GetItemChecked(i))
        //        {
        //            inds.Add(checkedListBox1.Items[i]);
        //        }
        //    }

        //    // 变更文件名
        //    List<string> newFiles = new List<string>();
        //    for (int i = 0; i < listBox3.Items.Count; i++)
        //    {
        //        // 按照选择的字符，从文件名中替换掉
        //        string fileName = listBox3.Items[i].ToString();
        //        for (int j = 0; j < inds.Count(); j++)
        //        {
        //            string charItem = inds[j].ToString();
        //            Console.WriteLine("替换字符：" + charItem);

        //            if (charItem == "空格") charItem = " ";
        //            if (charItem == "?英文") charItem = "?";
        //            if (charItem == "？中文") charItem="？";
        //            fileName = fileName.Replace(charItem, "");
        //        }
        //        newFiles.Add(fileName);
        //    }
        //    listBox3.Items.Clear();
        //    newFiles.ForEach(item => listBox3.Items.Add(item));
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            // 检查文件是否有更改
            // if (!checkBox_numOrder.Checked && !checkBox_charOrder.Checked && checkedListBox1.CheckedItems.Count == 0)
            if (!checkBox_numOrder.Checked && !checkBox_charOrder.Checked && !checkBox_numOrderSubfix.Checked && !checkBox_charOrderSubfix.Checked && (customPrefixBox.Text.Length == 0) && (customSubfixBox.Text.Length == 0) && (textBeforeBox.Text.Length == 0) )
            {
                MessageBox.Show("未选择任何文件更改策略。");
                return;
            }

            // 确认修改按钮
            try
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    // 如果目标文件存在，则删除
                    string originalPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox1.Items[i].ToString());
                    string targetPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox3.Items[i].ToString());
                    Console.WriteLine(originalPath);
                    Console.WriteLine(targetPath);

                    // 如果删除目标文件，当文件名没有更改时，会把源文件删除
                    //MessageBox.Show(fileOriPath + fileAbsPath);
                    //if (File.Exists(originalPath))
                    //{
                    //    File.Delete(targetPath);
                    //}

                    // move
                    if (originalPath != targetPath)
                    {
                        if (this.cate_id == 0)
                        {
                            File.Move(originalPath, targetPath);
                        } else if (this.cate_id == 1)
                        {
                            Directory.Move(originalPath, targetPath);
                        }
                    }
                }
                MessageBox.Show("修改成功。");

                // 将修改置为失效，直到重新选择了文件夹
                confirmRenameBtn.Enabled = false;

                // 使用记录
                // string lezhisoft_statistic_url = "http://localhost:5000/admin/batch_rename";
                string lezhisoft_statistic_url = "https://lezhifu.cc/admin/batch_rename";
                using (var httpclient = new HttpClient())
                {
                    httpclient.GetAsync(lezhisoft_statistic_url).Wait();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex + " 修改失败，请重试。");
            }
        }

        private void rechoose_btn_Click(object sender, EventArgs e)
        {
            // 重新选择文件夹
            this.button1_Click(sender, e);
        }

        private void renamefile_Click(object sender, EventArgs e)
        {
            // 选择重命名文件 
            this.listBox1.Items.Clear();
            this.listBox3.Items.Clear();
            this.choose_btn.Visible = true;
            this.rename_file.BorderStyle = BorderStyle.Fixed3D;
            this.rename_folder.BorderStyle = BorderStyle.None;
            clearRule();
            this.cate_id = 0;
        }

        private void renamefolder_Click(object sender, EventArgs e)
        {
            // 重命名文件夹点击事件
            this.listBox1.Items.Clear();
            this.listBox3.Items.Clear();
            this.choose_btn.Visible = true;
            this.rename_file.BorderStyle = BorderStyle.None;
            this.rename_folder.BorderStyle = BorderStyle.Fixed3D;
            clearRule();
            this.cate_id = 1;
        }

        private void delete_cate_Click(object sender, EventArgs e)
        {
            // 重命名文件夹点击事件
            this.listBox1.Items.Clear();
            this.listBox3.Items.Clear();
            this.choose_btn.Visible = true;
            this.rename_file.BorderStyle = BorderStyle.None;
            this.rename_folder.BorderStyle = BorderStyle.None;
            clearRule();
            this.cate_id = 2;
        }

        private void clearRule()
        {
            this.checkBox_numOrder.Checked = false;
            this.checkBox_charOrder.Checked = false;
            this.customPrefixBox.Text = string.Empty;
            this.checkBox_numOrderSubfix.Checked = false;
            this.checkBox_charOrderSubfix.Checked = false;
            this.customSubfixBox.Text = string.Empty;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customSubfixBox_TextChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 自定义后缀
            //if (customSubfixBox.Text.Length > 0)
            //{
            //    RenameFile.renameCustomSubfix(listBox1, listBox3, customSubfixBox);
            //}
        }

        private void customPrefixBox_TextChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 自定义前缀
            //RenameFile.renameCustomPrefix(listBox1, listBox3, customPrefixBox);
        }

        private void textBefore_TextChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 自定义替换
            //RenameFile.replaceCustomBefore(listBox1, listBox3, textBeforeBox);
        }

        private void textAfter_TextChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 自定义替换
            //if (textAfterBox.Text.Length > 0)
            //{
            //    RenameFile.replaceCustomAfter(listBox1, listBox3, textBeforeBox, textAfterBox);
            //}
        }

        private void checkBox_charOrderSubfix_CheckedChanged(object sender, EventArgs e)
        {
            renameFile();

            //List<string> newFiles = new List<string>();

            //// 修改文件夹名称，按照字母后缀 添加
            //if (checkBox_charOrderSubfix.Checked)
            //{
            //    newFiles = RenameFile.renameCharSubfix(listBox1, listBox3);
            //}
            //else
            //{
            //    for (int i = 0; i < listBox3.Items.Count; i++)
            //    {
            //        // 将前缀字母删除
            //        char initChar = 'a';
            //        int addNum = i % 26;
            //        char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

            //        // 这里有bug，当文件原名中包含了字母下划线时，可能会误替换
            //        //string newFileName =  listBox3.Items[i].ToString().Replace(b.ToString() + "_", "");
            //        string item = listBox3.Items[i].ToString();
            //        string prefix = "_" + b.ToString();
            //        if (item.EndsWith(prefix))
            //        {
            //            string newFileName = item.Substring(0, item.Length- prefix.Length);
            //            newFiles.Add(newFileName);
            //        } else
            //        {
            //            newFiles.Add(item);
            //        }
            //    }
            //    listBox3.Items.Clear();
            //    newFiles.ForEach(item => listBox3.Items.Add(item));
            //}
        }

        private void checkBox_numOrderSubfix_CheckedChanged(object sender, EventArgs e)
        {
            renameFile();

            //// 修改了数字后缀 checkbox
            //List<string> newFiles = new List<string>();

            //// 修改文件夹名称，按照数字后缀 添加
            //int initNum = 1;
            //if (checkBox_numOrderSubfix.Checked)
            //{
            //    newFiles = RenameFile.renameNumSubfix(listBox1, listBox3);
            //}
            //else
            //{
            //    for (int i = 0; i < listBox3.Items.Count; i++)
            //    {
            //        // 将数字后缀删除
            //        string item = listBox3.Items[i].ToString();
            //        string prefix =  "_" + (i + initNum);
            //        if (item.EndsWith(prefix))
            //        {
            //            string newFileName = item.Substring(0, item.Length - prefix.Length);
            //            newFiles.Add(newFileName);
            //        } else
            //        {
            //            newFiles.Add(item);
            //        }
            //    }
            //    listBox3.Items.Clear();
            //    newFiles.ForEach(item => listBox3.Items.Add(item));
            //}
        }

    }
}
