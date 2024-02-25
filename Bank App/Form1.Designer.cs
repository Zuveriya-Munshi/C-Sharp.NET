namespace Bank_App
{
    partial class Bank
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            name = new Label();
            balanace = new Label();
            AccType = new Label();
            bankName = new Label();
            AccNum = new Label();
            dataGridView1 = new DataGridView();
            cbAccType = new ComboBox();
            txtName = new TextBox();
            txtBalance = new TextBox();
            txtBankName = new TextBox();
            txtAccNo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orchid;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(479, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSalmon;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(620, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 45);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(479, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Turquoise;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(620, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = SystemColors.GradientActiveCaption;
            name.Font = new Font("Segoe UI", 12F);
            name.Location = new Point(71, 48);
            name.Name = "name";
            name.Size = new Size(64, 28);
            name.TabIndex = 5;
            name.Text = "Name";
            // 
            // balanace
            // 
            balanace.AutoSize = true;
            balanace.BackColor = SystemColors.GradientActiveCaption;
            balanace.Font = new Font("Segoe UI", 12F);
            balanace.Location = new Point(71, 209);
            balanace.Name = "balanace";
            balanace.Size = new Size(88, 28);
            balanace.TabIndex = 6;
            balanace.Text = "Balanace";
            // 
            // AccType
            // 
            AccType.AutoSize = true;
            AccType.BackColor = SystemColors.GradientActiveCaption;
            AccType.Font = new Font("Segoe UI", 12F);
            AccType.Location = new Point(71, 169);
            AccType.Name = "AccType";
            AccType.Size = new Size(130, 28);
            AccType.TabIndex = 7;
            AccType.Text = "Account Type";
            // 
            // bankName
            // 
            bankName.AutoSize = true;
            bankName.BackColor = SystemColors.GradientActiveCaption;
            bankName.Font = new Font("Segoe UI", 12F);
            bankName.Location = new Point(71, 85);
            bankName.Name = "bankName";
            bankName.Size = new Size(111, 28);
            bankName.TabIndex = 8;
            bankName.Text = "Bank Name";
            // 
            // AccNum
            // 
            AccNum.AutoSize = true;
            AccNum.BackColor = SystemColors.GradientActiveCaption;
            AccNum.Font = new Font("Segoe UI", 12F);
            AccNum.Location = new Point(71, 125);
            AccNum.Name = "AccNum";
            AccNum.Size = new Size(161, 28);
            AccNum.TabIndex = 9;
            AccNum.Text = "Account Number";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(684, 188);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbAccType
            // 
            cbAccType.FormattingEnabled = true;
            cbAccType.Items.AddRange(new object[] { "Savings", "Current" });
            cbAccType.Location = new Point(267, 173);
            cbAccType.Name = "cbAccType";
            cbAccType.Size = new Size(151, 28);
            cbAccType.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(267, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 12;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(267, 210);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(125, 27);
            txtBalance.TabIndex = 13;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(267, 86);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(125, 27);
            txtBankName.TabIndex = 14;
            // 
            // txtAccNo
            // 
            txtAccNo.Location = new Point(267, 129);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.Size = new Size(125, 27);
            txtAccNo.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, -1);
            label1.Name = "label1";
            label1.Size = new Size(149, 38);
            label1.TabIndex = 16;
            label1.Text = "Bank Form";
            label1.Click += label1_Click;
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(782, 450);
            Controls.Add(label1);
            Controls.Add(txtAccNo);
            Controls.Add(txtBankName);
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(cbAccType);
            Controls.Add(dataGridView1);
            Controls.Add(AccNum);
            Controls.Add(bankName);
            Controls.Add(AccType);
            Controls.Add(balanace);
            Controls.Add(name);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "Bank";
            Text = "Bank Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label name;
        private Label balanace;
        private Label AccType;
        private Label bankName;
        private Label AccNum;
        private DataGridView dataGridView1;
        private ComboBox cbAccType;
        private TextBox txtName;
        private TextBox txtBalance;
        private TextBox txtBankName;
        private TextBox txtAccNo;
        private Label label1;
    }
}
