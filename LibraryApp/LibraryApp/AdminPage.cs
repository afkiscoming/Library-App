using LibraryApp.Model;
using LibraryApp.Model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AdminPage : Form
    {
        List<Person> People;
        List<Book> Books;
        public AdminPage(List<Person> People, List<Book> Books)
        {
            InitializeComponent();
            this.People = People;
            this.Books = Books;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_Id.Text), txt_Name.Text, txt_Surname.Text, maskedTextBox1.Text, txt_Username.Text, txt_Password.Text, txt_Authority.Text);
        }


        private void AdminPage_Load(object sender, EventArgs e)
        {
            foreach (Person person in People)
            {
                dataGridView1.Rows.Add(person.getId(), person.getName(), person.getSurame(), person.getCreationDate(), person.getUserName(), person.getPassword(), person.getAuthority());
            }

            foreach (Book book in Books)
            {
                dataGridView2.Rows.Add(book.getBookID(), book.getBookName(), book.getBookAuthor(), book.getBookLanguge(), book.getBookPublishHouse(), book.getBookCategory(), book.getBookTotal(), book.getBookPageNum(), book.getBookPublishDate());
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void FillTheTexts()
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Authority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FillTheTexts();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            string name = txt_Name.Text;
            string surname = txt_Surname.Text;
            string creationDate = maskedTextBox1.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string authority = txt_Authority.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, name, surname, creationDate, username, password, authority);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_MemberOperations.Controls.Count; i++)
            {
                if (groupBox_MemberOperations.Controls[i] is TextBox || groupBox_MemberOperations.Controls[i] is MaskedTextBox)
                {
                    groupBox_MemberOperations.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_BookADD_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_BookID.Text, txt_BookName.Text, txt_BookAuthor.Text, txt_Language.Text, txt_PublishHouse.Text, txt_Category.Text, txt_Total.Text, txt_PageNumber.Text, txt_PublishDate.Text);
        }

        private void btn_BookUPDATE_Click(object sender, EventArgs e)
        {
            string bookid = txt_BookID.Text;
            string bookname = txt_BookName.Text;
            string bookauthor = txt_BookAuthor.Text;
            string booklanguage = txt_Language.Text;
            string bookpublishhouse = txt_PublishHouse.Text;
            string bookcategory = txt_Category.Text;
            string booktotal = txt_Total.Text;
            string bookpagenumber = txt_PageNumber.Text;
            string bookpublishdate = txt_PublishDate.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(bookid, bookname, bookauthor, booklanguage, bookpublishhouse, bookcategory, booktotal, bookpagenumber, bookpublishdate);
        }

        private void btn_BookDELETE_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_BookCLEAR_Click(object sender, EventArgs e)
        {
            for(int i =0;i<groupBox_Book.Controls.Count;i++)
            {
                if (groupBox_Book.Controls[i] is TextBox)
                {
                    groupBox_Book.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BookID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_BookName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_BookAuthor.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_Language.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_PublishHouse.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_Category.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_Total.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_PageNumber.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_PublishDate.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_SearchPerson_Click(object sender, EventArgs e)
        {
            Person TargetPerson = null;

            int SelectedPersonID = Convert.ToInt32(txt_SearchPerson.Text);

            foreach(Person person in People)
            {
                if(person.getId()==SelectedPersonID)
                {
                    TargetPerson = person;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(TargetPerson.getId(), TargetPerson.getName(), TargetPerson.getSurame(), TargetPerson.getCreationDate(), TargetPerson.getUserName(), TargetPerson.getPassword(), TargetPerson.getAuthority());
        }

        private void btn_ClearPerson_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Person TargetPerson in People)
            {
                dataGridView1.Rows.Add(TargetPerson.getId(), TargetPerson.getName(), TargetPerson.getSurame(), TargetPerson.getCreationDate(), TargetPerson.getUserName(), TargetPerson.getPassword(), TargetPerson.getAuthority());
            }
        }

        private void btn_SearchBook_Click(object sender, EventArgs e)
        {
            Book TargetBook = null;

            int SelectedBookID = Convert.ToInt32(txt_SearchBook.Text);

            foreach (Book book in Books)
            {
                if (book.getBookID() == SelectedBookID)
                {
                    TargetBook = book;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(TargetBook.getBookID(), TargetBook.getBookName(), TargetBook.getBookAuthor(), TargetBook.getBookLanguge(), TargetBook.getBookPublishHouse(), TargetBook.getBookCategory(), TargetBook.getBookTotal(), TargetBook.getBookPageNum(), TargetBook.getBookPublishDate());
        }

        private void btn_ClearBook_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach(Book TargetBook in Books)
            {
                dataGridView2.Rows.Add(TargetBook.getBookID(), TargetBook.getBookName(), TargetBook.getBookAuthor(), TargetBook.getBookLanguge(), TargetBook.getBookPublishHouse(), TargetBook.getBookCategory(), TargetBook.getBookTotal(), TargetBook.getBookPageNum(), TargetBook.getBookPublishDate());
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
            MessageBox.Show("Logged Out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
