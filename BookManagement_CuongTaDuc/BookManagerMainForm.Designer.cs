namespace BookManagement_CuongTaDuc
{
    partial class BookManagerMainForm
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
            lblHeader = new Label();
            lblCopyright = new Label();
            grbSearchCriteria = new GroupBox();
            txtDescription = new TextBox();
            btnSearch = new Button();
            txtBookName = new TextBox();
            lblDescription = new Label();
            lblBookName = new Label();
            btnCreate = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 39F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(10, 7);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(388, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.Red;
            lblCopyright.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyright.ForeColor = Color.Yellow;
            lblCopyright.Location = new Point(22, 464);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(83, 19);
            lblCopyright.TabIndex = 1;
            lblCopyright.Text = "© 2024 CJF";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(26, 95);
            grbSearchCriteria.Margin = new Padding(3, 2, 3, 2);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(3, 2, 3, 2);
            grbSearchCriteria.Size = new Size(1080, 80);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(606, 35);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 32);
            txtDescription.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(885, 33);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(144, 35);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(195, 32);
            txtBookName.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(416, 38);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(166, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Red;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(10, 38);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(116, 25);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(911, 234);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(175, 32);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Add a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(26, 234);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(837, 222);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Red;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(21, 201);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(93, 25);
            lblBookList.TabIndex = 8;
            lblBookList.Text = "Book List";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(911, 283);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(911, 333);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(911, 424);
            btnQuit.Margin = new Padding(3, 2, 3, 2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(175, 32);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1130, 492);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnCreate);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblCopyright);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "BookManagerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            Load += BookManagerMainForm_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCopyright;
        private GroupBox grbSearchCriteria;
        private TextBox txtBookName;
        private Label lblDescription;
        private Label lblBookName;
        private Button btnSearch;
        private TextBox txtDescription;
        private Button btnCreate;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
    }
}
