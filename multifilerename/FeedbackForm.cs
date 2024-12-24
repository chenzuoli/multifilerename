using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace multifilerename
{
    public partial class FeedbackForm : Form
    {
        private TextBox titleTextBox;
        private TextBox contentTextBox;
        private Button submitButton;
        private Label titleLabel;
        private Label contentLabel;

        public FeedbackForm()
        {
            InitializeComponent();
            InitializeFeedbackForm();
        }

        private void InitializeFeedbackForm()
        {
            // 设置窗体属性
            this.Text = "用户反馈";
            this.Size = new Size(500, 400);

            // 创建标题标签和文本框
            titleLabel = new Label();
            titleLabel.Text = "标题:";
            titleLabel.Location = new Point(20, 20);
            titleLabel.AutoSize = true;

            titleTextBox = new TextBox();
            titleTextBox.Location = new Point(20, 40);
            titleTextBox.Size = new Size(440, 25);

            // 创建内容标签和文本框
            contentLabel = new Label();
            contentLabel.Text = "反馈内容:";
            contentLabel.Location = new Point(20, 80);
            contentLabel.AutoSize = true;

            contentTextBox = new TextBox();
            contentTextBox.Location = new Point(20, 100);
            contentTextBox.Size = new Size(440, 180);
            contentTextBox.Multiline = true;
            contentTextBox.ScrollBars = ScrollBars.Vertical;

            // 创建提交按钮
            submitButton = new Button();
            submitButton.Text = "提交反馈";
            submitButton.Location = new Point(200, 300);
            submitButton.Size = new Size(100, 30);
            submitButton.Click += SubmitButton_Click;

            // 添加控件到窗体
            this.Controls.Add(titleLabel);
            this.Controls.Add(titleTextBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(contentTextBox);
            this.Controls.Add(submitButton);
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(contentTextBox.Text))
            {
                MessageBox.Show("请填写标题和反馈内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var feedback = new
                    {
                        title = titleTextBox.Text,
                        content = contentTextBox.Text
                    };
                    var json = JsonConvert.SerializeObject(feedback);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // TODO: 替换为实际的API地址
                    //var response = await client.PostAsync("http://localhost:5000/admin/common_feedback", content);
                    var response = await client.PostAsync("https://lezhifu.cc/admin/common_feedback", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("反馈提交成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("反馈提交失败，请稍后重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }
    }
}
