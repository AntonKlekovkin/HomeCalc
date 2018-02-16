using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFormHomeCalc
{
    public partial class Form1 : Form
    {

        private Calc calc;

        public Form1()
        {
            InitializeComponent();
            fsafa
            calc = new Calc();

            cb_Operation.Items.Clear();
            cb_Operation.Items.AddRange(calc.GetOperationsName());
            cb_Operation.Text = cb_Operation.Items[0].ToString();
        }



        private void btn_Exec_Click(object sender, EventArgs e)
        {
            var str = tb_Input.Text.Trim(' ');

            if(string.IsNullOrEmpty(str))
            {
                tb_Result.Text = "Не успех";
                return;
            }
                        
            var args = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToDouble(s)).ToArray();

            var result = calc.Exec(cb_Operation.Text, args);

            tb_Result.Text = result.ToString();
        }

        private void tb_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btn_Exec.PerformClick();
            }
        }
    }
}
