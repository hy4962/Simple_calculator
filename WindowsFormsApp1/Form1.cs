using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
    
    
        //点击计算按钮时，执行相应的运算，同时将计算过程添加到历史记录列表框中
        private void btn_count_Click(object sender, EventArgs e)
        {
            //.Trim()去除首尾空格
            //double.TryParse(需要转换的值,值转换后存放的地方)，执行后返回布尔值
            bool bool_input1 = double.TryParse(txt_input1.Text.Trim(), out double input1);
            bool bool_input2 = double.TryParse(txt_input2.Text.Trim(), out double input2);

            //如果输入的值都能成功转换为数字，则根据选择的运算符执行相应的运算，并将结果显示在结果文本框中
            if (bool_input1 == true && bool_input2 == true)
            {
                switch (cbx_operator.Text.Trim())
                { 
                    case "+":
                        double output_add = input1 + input2;
                        txt_result.Text = output_add.ToString();
                        break;
                    case "-":
                        double output_minus = input1 - input2;
                        txt_result.Text = output_minus.ToString();
                        break;
                    case "×":
                        double output_mult = input1 * input2;
                        txt_result.Text = output_mult.ToString();
                        break;
                    case "x":
                        double output_mult1 = input1 * input2;
                        txt_result.Text = output_mult1.ToString();
                        break;
                    case "÷":
                        if (input2 != 0)
                        {
                            double output_div = input1 / input2;
                            txt_result.Text = output_div.ToString();
                        }
                        else
                        {
                            MessageBox.Show("除数不能为0");
                        }
                        break;
                    default:
                        MessageBox.Show("请选择运算符");
                        break;
                }
            }
            else
            {
                txt_result.Text = "请在上面两个输入框中输入数字并选择运算符".Trim();
                MessageBox.Show("请输入数字");
            }


            //将计算结果添加到历史记录列表框中
            void AddToHistory()
            {
                string history_entry = $"{input1} {cbx_operator.Text.Trim()} {input2} = {txt_result.Text.Trim()}";
                try
                {
                    if (!string.IsNullOrEmpty(history_entry))
                    {
                        lbx_history.Items.Add(history_entry);
                    }
                }
                catch { }
            }
            AddToHistory();

        }



        //选择列表框中的运算符时，将其显示在组合框中
        private void lbx_operatore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedItem获取当前选中项的值，ToString()将其转换为字符串
            cbx_operator.Text = lbx_operatore.SelectedItem.ToString();
        }


        //选择历史记录列表框中的某一项时，将其结果显示在结果文本框中，并将该历史记录复制到剪贴板
        private void lbx_history_SelectedIndexChanged(object sender, EventArgs e)
        {
           string history_result = lbx_history.SelectedItem.ToString();
            txt_result.Text = history_result.Split('=')[1].Trim();

            void copy_history()
            {
                try
                {
                    // 判断结果框是否为空，避免复制空内容报错
                    if (!string.IsNullOrEmpty(txt_result.Text))
                    {
                        Clipboard.SetText(lbx_history.SelectedItem.ToString());
                        //MessageBox.Show("复制成功！");
                    }
                }
                catch (Exception ex)
                {
                    // 如果剪切板被占用或其他错误，捕获异常防止程序崩溃
                    MessageBox.Show("复制失败，剪切板可能被其他程序占用。");
                }
                
            }
            copy_history();

        }

        //点击清除按钮时，清空输入框、结果框，并将输入焦点设置到第一个输入框中，方便用户继续输入
        private void but_clear_Click(object sender, EventArgs e)
        {
            txt_input1.Clear();txt_input2.Clear();txt_result.Clear();

            //Focus()方法将输入焦点设置到指定的控件上，这样用户就可以直接开始输入而不需要再点击一次输入框
            txt_input1.Focus();

        }

        //点击历史记录清除按钮时，清空历史记录列表框
        private void btn_his_clear_Click(object sender, EventArgs e){lbx_history.Items.Clear();}

        /*
        //在窗体加载时，将输入焦点设置到第一个输入框中，方便用户开始输入
        private void Form_Load(object sender, EventArgs e)
        {
            Task.Delay(1000);
            txt_input1.Focus();
        }
        */

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_count_Click(sender,e); }
            if (e.KeyCode == Keys.Delete) { but_clear_Click(sender,e); }

        }
    }
}
