using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Net.Http;

namespace multifilerename
{
    public partial class rename : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        public rename()
        {
            InitializeComponent();
            folderBrowserDialog = new FolderBrowserDialog();
            checkBox_numOrder.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 选择文件夹
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 列出选择的文件夹内的所有文件
                listBox1.Items.Clear();
                listBox3.Items.Clear();

                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                //listBox1.Items.AddRange(files);

                // 列出所有更改后的文件名，按照顺序一次在文件前新增数字序号
                for (int i = 0; i < files.Length; i++)
                {
                    String fileDirectory= Path.GetDirectoryName(files[i]);
                    String fileName = Path.GetFileName(files[i]);
                    String newFileName = (i + 1) + "_" + fileName;
                    String newFilePath = Path.Combine(fileDirectory, newFileName);
                    //listBox3.Items.Add(newFilePath);
                    listBox1.Items.Add(fileName);
                    listBox3.Items.Add(newFileName);
                    //listBox1.Items.Add("-----------------------------------------------------------------");
                    //listBox3.Items.Add("-----------------------------------------------------------------");
                }
                button3.Enabled = true;

                // 隐藏btn1
                button1.Visible = false;

                // 默认数字前缀
                this.checkBox_numOrder.Checked = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_charOrder_CheckedChanged(object sender, EventArgs e)
        {
            List<string> newFiles = new List<string>();

            // 修改文件夹名称，按照字母前缀 添加
            if (checkBox_charOrder.Checked)
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 按照字母顺序，如果超过26个字母，字母循环
                    char initChar = 'a';
                    int addNum = i % 26;
                    char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                    string newFileName = b.ToString() + "_" + listBox3.Items[i].ToString();
                    newFiles.Add(newFileName);
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
            else
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 将前缀字母删除
                    char initChar = 'a';
                    int addNum = i % 26;
                    char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                    // 这里有bug，当文件原名中包含了字母下划线时，可能会误替换
                    //string newFileName =  listBox3.Items[i].ToString().Replace(b.ToString() + "_", "");
                    string item = listBox3.Items[i].ToString();
                    string prefix = b.ToString() + "_";
                    if (item.StartsWith(prefix))
                    {
                        string newFileName = item.Substring(prefix.Length);
                        newFiles.Add(newFileName);
                    }
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
        }

        private void checkBox_numOrder_CheckedChanged(object sender, EventArgs e)
        {
            // 修改了数字前缀 checkbox
            List<string> newFiles = new List<string>();

            // 修改文件夹名称，按照数字前缀 添加
            int initNum = 1;
            if (checkBox_numOrder.Checked)
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    string newFileName = (i+initNum) + "_" + listBox3.Items[i].ToString();
                    newFiles.Add(newFileName);
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
            else
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 将数字前缀删除
                    string item = listBox3.Items[i].ToString();
                    string prefix = (i + initNum) + "_";
                    if (item.StartsWith(prefix))
                    {
                        string newFileName = item.Substring(prefix.Length);
                        newFiles.Add(newFileName);
                    }
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 选中了其中一个，
            List<object> inds = new List<object>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    inds.Add(checkedListBox1.Items[i]);
                }
            }

            // 变更文件名
            List<string> newFiles = new List<string>();
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                // 按照选择的字符，从文件名中替换掉
                string fileName = listBox3.Items[i].ToString();
                for (int j = 0; j < inds.Count(); j++)
                {
                    string charItem = inds[j].ToString();
                    Console.WriteLine("替换字符：" + charItem);

                    if (charItem == "空格") charItem = " ";
                    if (charItem == "?英文") charItem = "?";
                    if (charItem == "？中文") charItem="？";
                    fileName = fileName.Replace(charItem, "");
                }
                newFiles.Add(fileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 检查文件是否有更改
            if (!checkBox_numOrder.Checked && !checkBox_charOrder.Checked && checkedListBox1.CheckedItems.Count == 0)
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
                    string fileOriPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox1.Items[i].ToString());
                    string fileAbsPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox3.Items[i].ToString());
                    Console.WriteLine(fileOriPath);
                    Console.WriteLine(fileAbsPath);

                    // 如果删除目标文件，当文件名没有更改时，会把源文件删除
                    //MessageBox.Show(fileOriPath + fileAbsPath);
                    //if (File.Exists(fileAbsPath))
                    //{
                    //    File.Delete(fileAbsPath);
                    //}

                    // move
                    if (fileOriPath != fileAbsPath)
                    {
                        File.Move(fileOriPath, fileAbsPath);
                    }
                }
                MessageBox.Show("修改成功。");

                // 将修改置为失效，直到重新选择了文件夹
                button3.Enabled = false;

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
            this.button1.Visible = true;
        }
    }
}
