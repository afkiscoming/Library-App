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
    public partial class MemberPage : Form
    {
        List<Book> Books;
        public MemberPage(List<Book> Books)
        {
            InitializeComponent();
            this.Books = Books;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
            MessageBox.Show("Logged Out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            foreach(Book book in Books)
            {
                dataGridView1.Rows.Add(book.getBookID(), book.getBookName(), book.getBookAuthor(), book.getBookLanguge(), book.getBookPublishHouse(), book.getBookCategory(), book.getBookTotal(), book.getBookPageNum(), book.getBookPublishDate());
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Book TargetBook = null;

            int SelectedBookID = Convert.ToInt32(txt_Search.Text);

            foreach (Book book in Books)
            {
                if (book.getBookID() == SelectedBookID)
                {
                    TargetBook = book;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(TargetBook.getBookID(), TargetBook.getBookName(), TargetBook.getBookAuthor(), TargetBook.getBookLanguge(), TargetBook.getBookPublishHouse(), TargetBook.getBookCategory(), TargetBook.getBookTotal(), TargetBook.getBookPageNum(), TargetBook.getBookPublishDate());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Book TargetBook in Books)
            {
                dataGridView1.Rows.Add(TargetBook.getBookID(), TargetBook.getBookName(), TargetBook.getBookAuthor(), TargetBook.getBookLanguge(), TargetBook.getBookPublishHouse(), TargetBook.getBookCategory(), TargetBook.getBookTotal(), TargetBook.getBookPageNum(), TargetBook.getBookPublishDate());
            }
        }
    }
}
