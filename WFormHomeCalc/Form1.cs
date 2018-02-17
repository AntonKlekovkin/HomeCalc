using DataBase.Models;
using DataBase.NHibernate.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFormHomeCalc
{
    public partial class Form1 : Form
    {

        private Calc calc;

        private NHBaseRepository Repository;

        public Form1()
        {
            InitializeComponent();
            
            calc = new Calc();
            Repository = new NHBaseRepository();

            cb_Operation.Items.Clear();
            cb_Operation.Items.AddRange(calc.GetOperationsName());
            cb_Operation.Text = cb_Operation.Items[0].ToString();

            // получаем из базы всю историю
            var history = Repository.GetAll();

            foreach (var historyItem in history)
            {
                tb_History.AppendText($"{historyItem.NameOperation}({historyItem.Args})={historyItem.Result} | {historyItem.Time}\r\n");
            }
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

            // сохраняем в базу
            HistoryItem item = new HistoryItem();
            item.Args = str;
            item.NameOperation = cb_Operation.Text;
            item.Time = DateTime.Now;
            item.Result = (float)result;
            item.Id = 10;

            Repository.Save(item);

            // получаем из базы всю историю
            var history = Repository.GetAll();
            tb_History.Clear();
            foreach (var historyItem in history)
            {
                tb_History.AppendText($"{historyItem.NameOperation}({historyItem.Args})={historyItem.Result} | {historyItem.Time}\r\n");
            }
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
