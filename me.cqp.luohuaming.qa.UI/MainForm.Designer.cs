
namespace me.cqp.luohuaming.qa.UI
{
    partial class MainForm
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
            this.OrderGridMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatchMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriorityText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatchText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.RichTextBox();
            this.NewItem = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderGridMain
            // 
            this.OrderGridMain.AllowUserToAddRows = false;
            this.OrderGridMain.AllowUserToDeleteRows = false;
            this.OrderGridMain.AllowUserToResizeColumns = false;
            this.OrderGridMain.AllowUserToResizeRows = false;
            this.OrderGridMain.BackgroundColor = System.Drawing.Color.White;
            this.OrderGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.OrderGridMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrderGridMain.Location = new System.Drawing.Point(14, 17);
            this.OrderGridMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderGridMain.MultiSelect = false;
            this.OrderGridMain.Name = "OrderGridMain";
            this.OrderGridMain.ReadOnly = true;
            this.OrderGridMain.RowHeadersVisible = false;
            this.OrderGridMain.RowTemplate.Height = 23;
            this.OrderGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridMain.ShowCellErrors = false;
            this.OrderGridMain.ShowCellToolTips = false;
            this.OrderGridMain.ShowEditingIcon = false;
            this.OrderGridMain.ShowRowErrors = false;
            this.OrderGridMain.Size = new System.Drawing.Size(503, 256);
            this.OrderGridMain.TabIndex = 0;
            this.OrderGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridMain_CellClick);
            this.OrderGridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridMain_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "启用";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "匹配方式";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "优先级";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "关键字";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "回答";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteItem);
            this.groupBox1.Controls.Add(this.EditItem);
            this.groupBox1.Controls.Add(this.NewItem);
            this.groupBox1.Controls.Add(this.AnswerText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MatchText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PriorityText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MatchMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑或者新增";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "匹配方式";
            // 
            // MatchMode
            // 
            this.MatchMode.FormattingEnabled = true;
            this.MatchMode.Items.AddRange(new object[] {
            "直接匹配",
            "模糊匹配",
            "正则匹配"});
            this.MatchMode.Location = new System.Drawing.Point(9, 58);
            this.MatchMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MatchMode.Name = "MatchMode";
            this.MatchMode.Size = new System.Drawing.Size(103, 25);
            this.MatchMode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "优先级 (越小越高)";
            // 
            // PriorityText
            // 
            this.PriorityText.Location = new System.Drawing.Point(9, 116);
            this.PriorityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriorityText.Name = "PriorityText";
            this.PriorityText.Size = new System.Drawing.Size(103, 23);
            this.PriorityText.TabIndex = 3;
            this.PriorityText.Text = "100";
            this.PriorityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriorityText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "匹配关键字 (正则模式)";
            // 
            // MatchText
            // 
            this.MatchText.Location = new System.Drawing.Point(10, 178);
            this.MatchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MatchText.Name = "MatchText";
            this.MatchText.Size = new System.Drawing.Size(102, 23);
            this.MatchText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "回答文本";
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(136, 58);
            this.AnswerText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(251, 148);
            this.AnswerText.TabIndex = 7;
            this.AnswerText.Text = "";
            // 
            // NewItem
            // 
            this.NewItem.Location = new System.Drawing.Point(395, 55);
            this.NewItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(98, 33);
            this.NewItem.TabIndex = 8;
            this.NewItem.Text = "新增一项";
            this.NewItem.UseVisualStyleBackColor = true;
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(395, 113);
            this.EditItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(98, 33);
            this.EditItem.TabIndex = 9;
            this.EditItem.Text = "编辑选中";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(395, 173);
            this.DeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(98, 33);
            this.DeleteItem.TabIndex = 10;
            this.DeleteItem.Text = "删除选中";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(434, 507);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(73, 37);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 559);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderGridMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "词库设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderGridMain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PriorityText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MatchMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button NewItem;
        private System.Windows.Forms.RichTextBox AnswerText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MatchText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
    }
}

