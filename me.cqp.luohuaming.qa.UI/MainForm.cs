using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveInfos;

namespace me.cqp.luohuaming.qa.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_Closing is false && MessageBox.Show("确认关闭吗？未保存的配置都将丢失"
                , "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        bool btn_Closing = false;
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认关闭吗？未保存的配置都将丢失"
                    , "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btn_Closing = true;
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (MainSave.OrderModels != null && MainSave.OrderModels.Count != 0)
            {
                foreach (var item in MainSave.OrderModels)
                {
                    OrderGridMain.Rows.Add(item.state == 0, GetMatchModeText(item.type)
                        , item.priority, item.keyword, item.answer);
                }
            }
            MatchMode.SelectedIndex = 0;
        }

        private void OrderGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = MainSave.OrderModels[e.RowIndex];
            MatchMode.SelectedIndex = item.type;
            PriorityText.Text = item.priority.ToString();
            MatchText.Text = item.keyword;
            AnswerText.Text = item.answer;
        }

        private void PriorityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                e.Handled = false;
            }
        }

        private void NewItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PriorityText.Text) || string.IsNullOrWhiteSpace(MatchText.Text)
                || string.IsNullOrWhiteSpace(AnswerText.Text))
            {
                MessageBox.Show("不可有空项目");
                return;
            }
            OrderModel model = new OrderModel
            {
                id = 0,
                answer = AnswerText.Text,
                keyword = MatchText.Text,
                priority = Convert.ToInt32(PriorityText.Text),
                type = MatchMode.SelectedIndex,
                state = 0
            };
            OrderGridMain.Rows.Add(true, GetMatchModeText(model.type)
                , model.priority, model.keyword, model.answer);            
            model.id = SQLHelper.AddItem(model);
            MainSave.OrderModels.Add(model);
            Helper.OrderListInit();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PriorityText.Text) || string.IsNullOrWhiteSpace(MatchText.Text)
                || string.IsNullOrWhiteSpace(AnswerText.Text))
            {
                MessageBox.Show("不可有空项目");
                return;
            }
            if (OrderGridMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先至少选中一项");
                return;
            }
            int index = OrderGridMain.SelectedRows[0].Index;
            OrderModel model = new OrderModel
            {
                id = MainSave.OrderModels[index].id,
                answer = AnswerText.Text,
                keyword = MatchText.Text,
                priority = Convert.ToInt32(PriorityText.Text),
                type = MatchMode.SelectedIndex,
                state = (bool)OrderGridMain.SelectedRows[0].Cells[0].Value ? 0 : 1
            };
            OrderGridMain.SelectedRows[0].Cells[1].Value = GetMatchModeText(model.type);
            OrderGridMain.SelectedRows[0].Cells[2].Value = model.priority;
            OrderGridMain.SelectedRows[0].Cells[3].Value = model.keyword;
            OrderGridMain.SelectedRows[0].Cells[4].Value = model.answer;

            MainSave.OrderModels[index] = model;
            SQLHelper.UpdateItem(model);
            Helper.OrderListInit();
        }

        private static string GetMatchModeText(int type)
        {
            string matchMode = string.Empty;
            switch (type)
            {
                case 0:
                    matchMode = "直接匹配"; break;
                case 1:
                    matchMode = "模糊匹配"; break;
                case 2:
                    matchMode = "正则匹配"; break;
            }
            return matchMode;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (OrderGridMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先至少选中一项");
                return;
            }
            int index = OrderGridMain.SelectedRows[0].Index;
            OrderGridMain.Rows.RemoveAt(index);
            SQLHelper.RemoveItem(MainSave.OrderModels[index]);
            MainSave.OrderModels.RemoveAt(index);
        }

        private void OrderGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                OrderGridMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value 
                    = !Convert.ToBoolean(OrderGridMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                MainSave.OrderModels[e.RowIndex].state
                    = (bool)OrderGridMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ? 0 : 1;
                SQLHelper.UpdateItem(MainSave.OrderModels[e.RowIndex]);
                Helper.OrderListInit();
            }
        }
    }
}
