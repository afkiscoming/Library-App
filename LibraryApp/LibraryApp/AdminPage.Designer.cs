
namespace LibraryApp
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_MemberOperations = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Authority = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booklanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublishouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagenumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Book = new System.Windows.Forms.GroupBox();
            this.btn_BookCLEAR = new System.Windows.Forms.Button();
            this.btn_BookDELETE = new System.Windows.Forms.Button();
            this.btn_BookUPDATE = new System.Windows.Forms.Button();
            this.btn_BookADD = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_PublishHouse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_PublishDate = new System.Windows.Forms.TextBox();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            this.txt_Language = new System.Windows.Forms.TextBox();
            this.txt_BookAuthor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ClearPerson = new System.Windows.Forms.Button();
            this.txt_SearchPerson = new System.Windows.Forms.TextBox();
            this.btn_SearchPerson = new System.Windows.Forms.Button();
            this.btn_ClearBook = new System.Windows.Forms.Button();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.txt_SearchBook = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.groupBox_MemberOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_Book.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_MemberOperations
            // 
            this.groupBox_MemberOperations.Controls.Add(this.maskedTextBox1);
            this.groupBox_MemberOperations.Controls.Add(this.btn_Clear);
            this.groupBox_MemberOperations.Controls.Add(this.btn_Delete);
            this.groupBox_MemberOperations.Controls.Add(this.btn_Update);
            this.groupBox_MemberOperations.Controls.Add(this.btn_Add);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Authority);
            this.groupBox_MemberOperations.Controls.Add(this.label7);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Password);
            this.groupBox_MemberOperations.Controls.Add(this.label6);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Username);
            this.groupBox_MemberOperations.Controls.Add(this.label5);
            this.groupBox_MemberOperations.Controls.Add(this.label4);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Surname);
            this.groupBox_MemberOperations.Controls.Add(this.label3);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Name);
            this.groupBox_MemberOperations.Controls.Add(this.label2);
            this.groupBox_MemberOperations.Controls.Add(this.txt_Id);
            this.groupBox_MemberOperations.Controls.Add(this.label1);
            this.groupBox_MemberOperations.Location = new System.Drawing.Point(15, 283);
            this.groupBox_MemberOperations.Name = "groupBox_MemberOperations";
            this.groupBox_MemberOperations.Size = new System.Drawing.Size(558, 297);
            this.groupBox_MemberOperations.TabIndex = 0;
            this.groupBox_MemberOperations.TabStop = false;
            this.groupBox_MemberOperations.Text = "Member Options";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 108);
            this.maskedTextBox1.Mask = "00/00/0000 90:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(99, 262);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(360, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(99, 233);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(360, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(99, 204);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(360, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(99, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(360, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txt_Authority
            // 
            this.txt_Authority.Location = new System.Drawing.Point(371, 95);
            this.txt_Authority.Name = "txt_Authority";
            this.txt_Authority.Size = new System.Drawing.Size(115, 20);
            this.txt_Authority.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Authority: ";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(371, 69);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(115, 20);
            this.txt_Password.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(371, 43);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(115, 20);
            this.txt_Username.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Creation Date:";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(112, 82);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(115, 20);
            this.txt_Surname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(112, 56);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(115, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // txt_Id
            // 
            this.txt_Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Id.Location = new System.Drawing.Point(112, 30);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(115, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "MEMBERS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.creationDate,
            this.username,
            this.password,
            this.authority});
            this.dataGridView1.Location = new System.Drawing.Point(15, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 238);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "SURNAME";
            this.surname.Name = "surname";
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "CREATION DATE";
            this.creationDate.Name = "creationDate";
            // 
            // username
            // 
            this.username.HeaderText = "USERNAME";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "PASSWORD";
            this.password.Name = "password";
            // 
            // authority
            // 
            this.authority.HeaderText = "AUTHORITY";
            this.authority.Name = "authority";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(840, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "BOOKS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookid,
            this.bookname,
            this.bookauthor,
            this.booklanguage,
            this.bookpublishouse,
            this.category,
            this.total,
            this.pagenumbers,
            this.publishdate});
            this.dataGridView2.Location = new System.Drawing.Point(596, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(558, 238);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bookid
            // 
            this.bookid.HeaderText = "BOOK ID";
            this.bookid.Name = "bookid";
            this.bookid.Width = 75;
            // 
            // bookname
            // 
            this.bookname.HeaderText = "BOOK NAME";
            this.bookname.Name = "bookname";
            this.bookname.Width = 75;
            // 
            // bookauthor
            // 
            this.bookauthor.HeaderText = "BOOK AUTHOR";
            this.bookauthor.Name = "bookauthor";
            this.bookauthor.Width = 75;
            // 
            // booklanguage
            // 
            this.booklanguage.HeaderText = "LANGUAGE";
            this.booklanguage.Name = "booklanguage";
            this.booklanguage.Width = 75;
            // 
            // bookpublishouse
            // 
            this.bookpublishouse.HeaderText = "PUBLISH HOUSE";
            this.bookpublishouse.Name = "bookpublishouse";
            this.bookpublishouse.Width = 75;
            // 
            // category
            // 
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.Width = 75;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.Width = 75;
            // 
            // pagenumbers
            // 
            this.pagenumbers.HeaderText = "PAGE NUMBERS";
            this.pagenumbers.Name = "pagenumbers";
            this.pagenumbers.Width = 75;
            // 
            // publishdate
            // 
            this.publishdate.HeaderText = "PUBLISH DATE";
            this.publishdate.Name = "publishdate";
            this.publishdate.Width = 75;
            // 
            // groupBox_Book
            // 
            this.groupBox_Book.Controls.Add(this.btn_BookCLEAR);
            this.groupBox_Book.Controls.Add(this.btn_BookDELETE);
            this.groupBox_Book.Controls.Add(this.btn_BookUPDATE);
            this.groupBox_Book.Controls.Add(this.btn_BookADD);
            this.groupBox_Book.Controls.Add(this.txt_Total);
            this.groupBox_Book.Controls.Add(this.label10);
            this.groupBox_Book.Controls.Add(this.txt_Category);
            this.groupBox_Book.Controls.Add(this.label11);
            this.groupBox_Book.Controls.Add(this.txt_PublishHouse);
            this.groupBox_Book.Controls.Add(this.label12);
            this.groupBox_Book.Controls.Add(this.label18);
            this.groupBox_Book.Controls.Add(this.label17);
            this.groupBox_Book.Controls.Add(this.label13);
            this.groupBox_Book.Controls.Add(this.txt_PublishDate);
            this.groupBox_Book.Controls.Add(this.txt_PageNumber);
            this.groupBox_Book.Controls.Add(this.txt_Language);
            this.groupBox_Book.Controls.Add(this.txt_BookAuthor);
            this.groupBox_Book.Controls.Add(this.label14);
            this.groupBox_Book.Controls.Add(this.txt_BookName);
            this.groupBox_Book.Controls.Add(this.label15);
            this.groupBox_Book.Controls.Add(this.txt_BookID);
            this.groupBox_Book.Controls.Add(this.label16);
            this.groupBox_Book.Location = new System.Drawing.Point(596, 283);
            this.groupBox_Book.Name = "groupBox_Book";
            this.groupBox_Book.Size = new System.Drawing.Size(558, 297);
            this.groupBox_Book.TabIndex = 1;
            this.groupBox_Book.TabStop = false;
            this.groupBox_Book.Text = "Book Options";
            // 
            // btn_BookCLEAR
            // 
            this.btn_BookCLEAR.Location = new System.Drawing.Point(99, 262);
            this.btn_BookCLEAR.Name = "btn_BookCLEAR";
            this.btn_BookCLEAR.Size = new System.Drawing.Size(360, 23);
            this.btn_BookCLEAR.TabIndex = 12;
            this.btn_BookCLEAR.Text = "Clear";
            this.btn_BookCLEAR.UseVisualStyleBackColor = true;
            this.btn_BookCLEAR.Click += new System.EventHandler(this.btn_BookCLEAR_Click);
            // 
            // btn_BookDELETE
            // 
            this.btn_BookDELETE.Location = new System.Drawing.Point(99, 233);
            this.btn_BookDELETE.Name = "btn_BookDELETE";
            this.btn_BookDELETE.Size = new System.Drawing.Size(360, 23);
            this.btn_BookDELETE.TabIndex = 11;
            this.btn_BookDELETE.Text = "Delete";
            this.btn_BookDELETE.UseVisualStyleBackColor = true;
            this.btn_BookDELETE.Click += new System.EventHandler(this.btn_BookDELETE_Click);
            // 
            // btn_BookUPDATE
            // 
            this.btn_BookUPDATE.Location = new System.Drawing.Point(99, 204);
            this.btn_BookUPDATE.Name = "btn_BookUPDATE";
            this.btn_BookUPDATE.Size = new System.Drawing.Size(360, 23);
            this.btn_BookUPDATE.TabIndex = 10;
            this.btn_BookUPDATE.Text = "Update";
            this.btn_BookUPDATE.UseVisualStyleBackColor = true;
            this.btn_BookUPDATE.Click += new System.EventHandler(this.btn_BookUPDATE_Click);
            // 
            // btn_BookADD
            // 
            this.btn_BookADD.Location = new System.Drawing.Point(99, 175);
            this.btn_BookADD.Name = "btn_BookADD";
            this.btn_BookADD.Size = new System.Drawing.Size(360, 23);
            this.btn_BookADD.TabIndex = 9;
            this.btn_BookADD.Text = "Add";
            this.btn_BookADD.UseVisualStyleBackColor = true;
            this.btn_BookADD.Click += new System.EventHandler(this.btn_BookADD_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(387, 119);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(115, 20);
            this.txt_Total.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total:";
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(387, 41);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(115, 20);
            this.txt_Category.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Category:";
            // 
            // txt_PublishHouse
            // 
            this.txt_PublishHouse.Location = new System.Drawing.Point(112, 108);
            this.txt_PublishHouse.Name = "txt_PublishHouse";
            this.txt_PublishHouse.Size = new System.Drawing.Size(115, 20);
            this.txt_PublishHouse.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Publish House:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(292, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Publish Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Page Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Language:";
            // 
            // txt_PublishDate
            // 
            this.txt_PublishDate.Location = new System.Drawing.Point(387, 93);
            this.txt_PublishDate.Name = "txt_PublishDate";
            this.txt_PublishDate.Size = new System.Drawing.Size(115, 20);
            this.txt_PublishDate.TabIndex = 7;
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.Location = new System.Drawing.Point(387, 67);
            this.txt_PageNumber.Name = "txt_PageNumber";
            this.txt_PageNumber.Size = new System.Drawing.Size(115, 20);
            this.txt_PageNumber.TabIndex = 6;
            // 
            // txt_Language
            // 
            this.txt_Language.Location = new System.Drawing.Point(112, 134);
            this.txt_Language.Name = "txt_Language";
            this.txt_Language.Size = new System.Drawing.Size(115, 20);
            this.txt_Language.TabIndex = 4;
            // 
            // txt_BookAuthor
            // 
            this.txt_BookAuthor.Location = new System.Drawing.Point(112, 82);
            this.txt_BookAuthor.Name = "txt_BookAuthor";
            this.txt_BookAuthor.Size = new System.Drawing.Size(115, 20);
            this.txt_BookAuthor.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Author Name:";
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(112, 56);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(115, 20);
            this.txt_BookName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Book Name: ";
            // 
            // txt_BookID
            // 
            this.txt_BookID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_BookID.Location = new System.Drawing.Point(112, 30);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(115, 20);
            this.txt_BookID.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Id: ";
            // 
            // btn_ClearPerson
            // 
            this.btn_ClearPerson.Location = new System.Drawing.Point(138, 9);
            this.btn_ClearPerson.Name = "btn_ClearPerson";
            this.btn_ClearPerson.Size = new System.Drawing.Size(58, 21);
            this.btn_ClearPerson.TabIndex = 4;
            this.btn_ClearPerson.Text = "Clear";
            this.btn_ClearPerson.UseVisualStyleBackColor = true;
            this.btn_ClearPerson.Click += new System.EventHandler(this.btn_ClearPerson_Click);
            // 
            // txt_SearchPerson
            // 
            this.txt_SearchPerson.Location = new System.Drawing.Point(15, 10);
            this.txt_SearchPerson.Name = "txt_SearchPerson";
            this.txt_SearchPerson.Size = new System.Drawing.Size(53, 20);
            this.txt_SearchPerson.TabIndex = 5;
            // 
            // btn_SearchPerson
            // 
            this.btn_SearchPerson.Location = new System.Drawing.Point(74, 9);
            this.btn_SearchPerson.Name = "btn_SearchPerson";
            this.btn_SearchPerson.Size = new System.Drawing.Size(58, 21);
            this.btn_SearchPerson.TabIndex = 4;
            this.btn_SearchPerson.Text = "Search";
            this.btn_SearchPerson.UseVisualStyleBackColor = true;
            this.btn_SearchPerson.Click += new System.EventHandler(this.btn_SearchPerson_Click);
            // 
            // btn_ClearBook
            // 
            this.btn_ClearBook.Location = new System.Drawing.Point(719, 10);
            this.btn_ClearBook.Name = "btn_ClearBook";
            this.btn_ClearBook.Size = new System.Drawing.Size(58, 21);
            this.btn_ClearBook.TabIndex = 4;
            this.btn_ClearBook.Text = "Clear";
            this.btn_ClearBook.UseVisualStyleBackColor = true;
            this.btn_ClearBook.Click += new System.EventHandler(this.btn_ClearBook_Click);
            // 
            // btn_SearchBook
            // 
            this.btn_SearchBook.Location = new System.Drawing.Point(655, 10);
            this.btn_SearchBook.Name = "btn_SearchBook";
            this.btn_SearchBook.Size = new System.Drawing.Size(58, 21);
            this.btn_SearchBook.TabIndex = 4;
            this.btn_SearchBook.Text = "Search";
            this.btn_SearchBook.UseVisualStyleBackColor = true;
            this.btn_SearchBook.Click += new System.EventHandler(this.btn_SearchBook_Click);
            // 
            // txt_SearchBook
            // 
            this.txt_SearchBook.Location = new System.Drawing.Point(596, 11);
            this.txt_SearchBook.Name = "txt_SearchBook";
            this.txt_SearchBook.Size = new System.Drawing.Size(53, 20);
            this.txt_SearchBook.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(1078, 7);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 592);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.txt_SearchBook);
            this.Controls.Add(this.txt_SearchPerson);
            this.Controls.Add(this.btn_SearchBook);
            this.Controls.Add(this.btn_SearchPerson);
            this.Controls.Add(this.btn_ClearBook);
            this.Controls.Add(this.btn_ClearPerson);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox_Book);
            this.Controls.Add(this.groupBox_MemberOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.groupBox_MemberOperations.ResumeLayout(false);
            this.groupBox_MemberOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_Book.ResumeLayout(false);
            this.groupBox_Book.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_MemberOperations;
        private System.Windows.Forms.TextBox txt_Authority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox_Book;
        private System.Windows.Forms.Button btn_BookCLEAR;
        private System.Windows.Forms.Button btn_BookDELETE;
        private System.Windows.Forms.Button btn_BookUPDATE;
        private System.Windows.Forms.Button btn_BookADD;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_PublishHouse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_BookAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn booklanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublishouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagenumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishdate;
        private System.Windows.Forms.TextBox txt_Language;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_PageNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_PublishDate;
        private System.Windows.Forms.Button btn_ClearPerson;
        private System.Windows.Forms.TextBox txt_SearchPerson;
        private System.Windows.Forms.Button btn_SearchPerson;
        private System.Windows.Forms.Button btn_ClearBook;
        private System.Windows.Forms.Button btn_SearchBook;
        private System.Windows.Forms.TextBox txt_SearchBook;
        private System.Windows.Forms.Button btn_Logout;
    }
}