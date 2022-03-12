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
    public partial class Form1 : Form
    {
        List<Person> People = new List<Person>();
        List<Book> Books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = string.Empty;
            txt_pass.Text = string.Empty;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userNameBtn = "";
            string passwordBtn = "";
            bool control = false;

            userNameBtn = txt_username.Text;
            passwordBtn = txt_pass.Text;

            foreach (Person person in People)
            {
                if (userNameBtn.ToLower() == person.getUserName() && passwordBtn.ToLower() == person.getPassword() && person.getAuthority() == "admin")
                {
                    //go admin page
                    AdminPage adminPage = new AdminPage(People,Books);
                    adminPage.Show();
                    this.Hide();
                    control = true;
                    break;
                }

                else if (userNameBtn.ToLower() == person.getUserName() && passwordBtn.ToLower() == person.getPassword() && person.getAuthority() == "member")
                {
                    //go member page
                    MemberPage memberPage = new MemberPage(Books);
                    memberPage.Show();
                    this.Hide();
                    control = true;
                    break;
                }          
            }

            if(!control)
            {
                MessageBox.Show("There is a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            People.Add(new Person(1, "Ahmet Furkan", "KARAOGLU", DateTime.Now, "afk", "123", "admin"));
            People.Add(new Person(2, "Maria", "CIOBAN", DateTime.Now, "maria31", "1234", "member"));
            People.Add(new Person(3, "Kerem", "KIRLI", DateTime.Now, "kirli69", "12345", "member"));
            People.Add(new Person(4, "Hasan", "KESELI", DateTime.Now, "keseli11", "12345", "member"));


            Books.Add(new Book(1, "icimizdeki Seytann", "Sebahattin Ali","Turkish","Yapikredi Yayinlari","Roman",100,250,2016));
            Books.Add(new Book(2, "Tutunamayanlar", "Oguz Atay","Turkish","Iletisim Yayincilik","Roman",350,760,2015));
            Books.Add(new Book(3, "Ucurtma Avcisi", "Khaled Hosseini","English","Everest Yayinlari","Roman",100,150,2010));
            Books.Add(new Book(4, "Kucuk Prens", "Antonie de Saint-Exupery","English","Can Cocuk Yayinlari","Roman",50,60,2018));
            Books.Add(new Book(5, "Kurk Mantolu Madonna", "Sebahattin Ali","Turkish","Yapikredi Yayinlari","Roman",50,220,2015));
        }
    }
}
