using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Model
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime creationDate { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string authority { get; set; }

        public Person()
        {

        }

        public Person(int id, string name, string surname, DateTime creationDate, string userName, string password, string authority)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.creationDate = creationDate;
            this.userName = userName;
            this.password = password;
            this.authority = authority;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void setSurame(string surname)
        {
            this.surname = surname;
        }
        public string getSurame()
        {
            return this.surname;
        }

        public void setCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
        }
        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        public string getUserName()
        {
            return this.userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return this.password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }
        public string getAuthority()
        {
            return this.authority;
        }


        public override string ToString()
        {
            return "Name - Surname: " + this.name + " " + this.surname;
        }
    }
}
