namespace WindowsFormsApp1
{
    partial class Form
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
            this.btn_count = new System.Windows.Forms.Button();
            this.txt_input1 = new System.Windows.Forms.TextBox();
            this.txt_input2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.cbx_operator = new System.Windows.Forms.ComboBox();
            this.lbx_operatore = new System.Windows.Forms.ListBox();
            this.lbx_history = new System.Windows.Forms.ListBox();
            this.tcl_1 = new System.Windows.Forms.TabControl();
            this.tabPage_count = new System.Windows.Forms.TabPage();
            this.but_clear = new System.Windows.Forms.Button();
            this.tabPage_history = new System.Windows.Forms.TabPage();
            this.btn_his_clear = new System.Windows.Forms.Button();
            this.tcl_1.SuspendLayout();
            this.tabPage_count.SuspendLayout();
            this.tabPage_history.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(482, 298);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(121, 64);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "计算";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // txt_input1
            // 
            this.txt_input1.Location = new System.Drawing.Point(35, 52);
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.Size = new System.Drawing.Size(152, 28);
            this.txt_input1.TabIndex = 1;
            // 
            // txt_input2
            // 
            this.txt_input2.Location = new System.Drawing.Point(482, 52);
            this.txt_input2.Name = "txt_input2";
            this.txt_input2.Size = new System.Drawing.Size(152, 28);
            this.txt_input2.TabIndex = 2;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(26, 191);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(608, 28);
            this.txt_result.TabIndex = 3;
            // 
            // cbx_operator
            // 
            this.cbx_operator.FormattingEnabled = true;
            this.cbx_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "×",
            "÷"});
            this.cbx_operator.Location = new System.Drawing.Point(261, 54);
            this.cbx_operator.Name = "cbx_operator";
            this.cbx_operator.Size = new System.Drawing.Size(121, 26);
            this.cbx_operator.TabIndex = 4;
            // 
            // lbx_operatore
            // 
            this.lbx_operatore.FormattingEnabled = true;
            this.lbx_operatore.ItemHeight = 18;
            this.lbx_operatore.Items.AddRange(new object[] {
            "+",
            "-",
            "×",
            "÷"});
            this.lbx_operatore.Location = new System.Drawing.Point(261, 109);
            this.lbx_operatore.Name = "lbx_operatore";
            this.lbx_operatore.Size = new System.Drawing.Size(120, 76);
            this.lbx_operatore.TabIndex = 5;
            this.lbx_operatore.SelectedIndexChanged += new System.EventHandler(this.lbx_operatore_SelectedIndexChanged);
            // 
            // lbx_history
            // 
            this.lbx_history.FormattingEnabled = true;
            this.lbx_history.ItemHeight = 18;
            this.lbx_history.Location = new System.Drawing.Point(29, 22);
            this.lbx_history.Name = "lbx_history";
            this.lbx_history.Size = new System.Drawing.Size(486, 310);
            this.lbx_history.TabIndex = 6;
            this.lbx_history.SelectedIndexChanged += new System.EventHandler(this.lbx_history_SelectedIndexChanged);
            // 
            // tcl_1
            // 
            this.tcl_1.Controls.Add(this.tabPage_count);
            this.tcl_1.Controls.Add(this.tabPage_history);
            this.tcl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcl_1.Location = new System.Drawing.Point(0, 0);
            this.tcl_1.Name = "tcl_1";
            this.tcl_1.SelectedIndex = 0;
            this.tcl_1.Size = new System.Drawing.Size(733, 418);
            this.tcl_1.TabIndex = 7;
            // 
            // tabPage_count
            // 
            this.tabPage_count.Controls.Add(this.but_clear);
            this.tabPage_count.Controls.Add(this.txt_input1);
            this.tabPage_count.Controls.Add(this.cbx_operator);
            this.tabPage_count.Controls.Add(this.txt_result);
            this.tabPage_count.Controls.Add(this.lbx_operatore);
            this.tabPage_count.Controls.Add(this.btn_count);
            this.tabPage_count.Controls.Add(this.txt_input2);
            this.tabPage_count.Location = new System.Drawing.Point(4, 28);
            this.tabPage_count.Name = "tabPage_count";
            this.tabPage_count.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_count.Size = new System.Drawing.Size(725, 386);
            this.tabPage_count.TabIndex = 0;
            this.tabPage_count.Text = "计算器";
            this.tabPage_count.UseVisualStyleBackColor = true;
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(482, 225);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(121, 53);
            this.but_clear.TabIndex = 6;
            this.but_clear.Text = "清空";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // tabPage_history
            // 
            this.tabPage_history.Controls.Add(this.btn_his_clear);
            this.tabPage_history.Controls.Add(this.lbx_history);
            this.tabPage_history.Location = new System.Drawing.Point(4, 28);
            this.tabPage_history.Name = "tabPage_history";
            this.tabPage_history.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_history.Size = new System.Drawing.Size(725, 386);
            this.tabPage_history.TabIndex = 1;
            this.tabPage_history.Text = "历史记录";
            this.tabPage_history.UseVisualStyleBackColor = true;
            // 
            // btn_his_clear
            // 
            this.btn_his_clear.Location = new System.Drawing.Point(558, 22);
            this.btn_his_clear.Name = "btn_his_clear";
            this.btn_his_clear.Size = new System.Drawing.Size(142, 45);
            this.btn_his_clear.TabIndex = 7;
            this.btn_his_clear.Text = "清空历史记录";
            this.btn_his_clear.UseVisualStyleBackColor = true;
            this.btn_his_clear.Click += new System.EventHandler(this.btn_his_clear_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 418);
            this.Controls.Add(this.tcl_1);
            this.KeyPreview = true;
            this.Name = "Form";
            this.Text = "计算器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.tcl_1.ResumeLayout(false);
            this.tabPage_count.ResumeLayout(false);
            this.tabPage_count.PerformLayout();
            this.tabPage_history.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.TextBox txt_input2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.ComboBox cbx_operator;
        private System.Windows.Forms.ListBox lbx_operatore;
        private System.Windows.Forms.ListBox lbx_history;
        private System.Windows.Forms.TabControl tcl_1;
        private System.Windows.Forms.TabPage tabPage_count;
        private System.Windows.Forms.TabPage tabPage_history;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button btn_his_clear;
    }
}

