namespace SQLite_EFCore
{
    partial class frmMyform
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
            dgPersons = new DataGridView();
            txtName = new TextBox();
            cmbAge = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnADD = new Button();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtState = new TextBox();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewTextBoxColumn();
            colState = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgPersons).BeginInit();
            SuspendLayout();
            // 
            // dgPersons
            // 
            dgPersons.AllowUserToAddRows = false;
            dgPersons.AllowUserToDeleteRows = false;
            dgPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPersons.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colAge, colCity, colState, colDelete });
            dgPersons.Location = new Point(22, 9);
            dgPersons.Margin = new Padding(3, 2, 3, 2);
            dgPersons.Name = "dgPersons";
            dgPersons.ReadOnly = true;
            dgPersons.RowHeadersWidth = 51;
            dgPersons.RowTemplate.Height = 29;
            dgPersons.Size = new Size(506, 170);
            dgPersons.TabIndex = 0;
            dgPersons.CellClick += dgPersons_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 230);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Person Name";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 1;
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(124, 278);
            cmbAge.Margin = new Padding(3, 2, 3, 2);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(133, 23);
            cmbAge.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 212);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 260);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "AGE:";
            // 
            // btnADD
            // 
            btnADD.Location = new Point(124, 413);
            btnADD.Margin = new Padding(3, 2, 3, 2);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(82, 22);
            btnADD.TabIndex = 5;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 304);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "CITY:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(124, 322);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(256, 23);
            txtCity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 358);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "STATE:";
            // 
            // txtState
            // 
            txtState.Location = new Point(124, 376);
            txtState.Margin = new Padding(3, 2, 3, 2);
            txtState.Name = "txtState";
            txtState.PlaceholderText = "State";
            txtState.Size = new Size(256, 23);
            txtState.TabIndex = 8;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 200;
            // 
            // colAge
            // 
            colAge.HeaderText = "Age";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            colAge.Width = 125;
            // 
            // colCity
            // 
            colCity.HeaderText = "City";
            colCity.Name = "colCity";
            colCity.ReadOnly = true;
            // 
            // colState
            // 
            colState.HeaderText = "State";
            colState.Name = "colState";
            colState.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "DELETE";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Width = 125;
            // 
            // frmMyform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 446);
            Controls.Add(label4);
            Controls.Add(txtState);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(btnADD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAge);
            Controls.Add(txtName);
            Controls.Add(dgPersons);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMyform";
            Text = "SQLite CRUD Demo";           
            Shown += frmMyform_Shown;
            ((System.ComponentModel.ISupportInitialize)dgPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPersons;
        private TextBox txtName;
        private ComboBox cmbAge;
        private Label label1;
        private Label label2;
        private Button btnADD;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtState;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colCity;
        private DataGridViewTextBoxColumn colState;
        private DataGridViewButtonColumn colDelete;
    }
}