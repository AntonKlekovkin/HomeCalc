namespace WFormHomeCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Operation = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exec = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Operation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(324, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операция";
            // 
            // cb_Operation
            // 
            this.cb_Operation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Operation.FormattingEnabled = true;
            this.cb_Operation.Items.AddRange(new object[] {
            "sum",
            "sub",
            "mul",
            "div"});
            this.cb_Operation.Location = new System.Drawing.Point(10, 23);
            this.cb_Operation.Name = "cb_Operation";
            this.cb_Operation.Size = new System.Drawing.Size(304, 21);
            this.cb_Operation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Input);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(324, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аргументы";
            // 
            // tb_Input
            // 
            this.tb_Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Input.Location = new System.Drawing.Point(10, 23);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(304, 20);
            this.tb_Input.TabIndex = 0;
            this.tb_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Input_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 70);
            this.panel1.TabIndex = 3;
            // 
            // btn_Exec
            // 
            this.btn_Exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exec.Location = new System.Drawing.Point(223, 16);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(91, 48);
            this.btn_Exec.TabIndex = 0;
            this.btn_Exec.Text = "Вычислить";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_Result);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(324, 116);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // tb_Result
            // 
            this.tb_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Result.Location = new System.Drawing.Point(10, 23);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(304, 20);
            this.tb_Result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Operation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Result;
    }
}

