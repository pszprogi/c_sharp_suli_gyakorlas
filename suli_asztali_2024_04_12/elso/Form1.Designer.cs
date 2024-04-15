namespace elso
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            cityTextBox = new TextBox();
            label4 = new Label();
            lastnameTextBox = new TextBox();
            label3 = new Label();
            firstnameTextBox = new TextBox();
            idTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            deleteButton = new Button();
            Editbutton = new Button();
            addButton = new Button();
            groupBox3 = new GroupBox();
            databaseGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cityTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lastnameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(firstnameTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eszközök";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(0, 216);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(244, 27);
            cityTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 193);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 7;
            label4.Text = "Lakcím";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(0, 163);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(244, 27);
            lastnameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 140);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "Keresztnév";
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(0, 110);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(244, 27);
            firstnameTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(0, 57);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(244, 27);
            idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 87);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Vezetéknév";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 34);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(Editbutton);
            groupBox2.Controls.Add(addButton);
            groupBox2.Location = new Point(12, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 264);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Műveletek";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Location = new Point(6, 163);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(232, 45);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Adat törlése";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // Editbutton
            // 
            Editbutton.BackColor = Color.Yellow;
            Editbutton.Location = new Point(6, 100);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(232, 45);
            Editbutton.TabIndex = 1;
            Editbutton.Text = "Adat szerkesztése";
            Editbutton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Lime;
            addButton.Location = new Point(6, 38);
            addButton.Name = "addButton";
            addButton.Size = new Size(232, 45);
            addButton.TabIndex = 0;
            addButton.Text = "Adat felvitele";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(databaseGridView);
            groupBox3.Location = new Point(268, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 529);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Táblázat";
            // 
            // databaseGridView
            // 
            databaseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseGridView.Columns.AddRange(new DataGridViewColumn[] { id, firstname, lastname, city });
            databaseGridView.Location = new Point(6, 26);
            databaseGridView.Name = "databaseGridView";
            databaseGridView.RowHeadersWidth = 51;
            databaseGridView.RowTemplate.Height = 29;
            databaseGridView.Size = new Size(496, 497);
            databaseGridView.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // firstname
            // 
            firstname.HeaderText = "Vezetéknév";
            firstname.MinimumWidth = 6;
            firstname.Name = "firstname";
            firstname.Width = 125;
            // 
            // lastname
            // 
            lastname.HeaderText = "Keresztnév";
            lastname.MinimumWidth = 6;
            lastname.Name = "lastname";
            lastname.Width = 125;
            // 
            // city
            // 
            city.HeaderText = "Lakcím";
            city.MinimumWidth = 6;
            city.Name = "city";
            city.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Adatbázis kezelő program";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox cityTextBox;
        private Label label4;
        private TextBox lastnameTextBox;
        private Label label3;
        private TextBox firstnameTextBox;
        private TextBox idTextBox;
        private Label label2;
        private Label label1;
        private Button deleteButton;
        private Button Editbutton;
        private Button addButton;
        private DataGridView databaseGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn city;
    }
}
