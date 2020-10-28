using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call
{
    public partial class Form1 : Form
    {
        List<User> listUser = new List<User>();
        public Form1()
        {
            InitializeComponent();
            listUser.Add(new User() { ID = 1, userName = "pham tan dat", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 2, userName = "tran quoc dai", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 3, userName = "duong quoc huy", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 4, userName = "dao hong vinh", dept = "ktmt", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 5, userName = "phung vinh duc", dept = "ktdl", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 6, userName = "huynh thanh tam", dept = "abcd", numberPhone = "12315645" });
            listUser.Add(new User() { ID = 10, userName = "phung cong chien", dept = "edgh", numberPhone = "12315645" });
            
            
        }


        private void searchUser_TextChanged(object sender, EventArgs e)
        {
            List<User> listUser2 = new List<User>();
            if (string.IsNullOrEmpty(searchUser.Text) == false)
            {
                foreach(User user in listUser)
                {
                    if (user.dept.StartsWith(searchUser.Text))
                    {
                        listUser2.Add(user);
                    }
                }
                dataGridView1.DataSource = listUser2;
            }
            else if (searchUser.Text == "")
            {
                foreach(User user in listUser)
                {
                    listUser2.Add(user);
                }
                dataGridView1.DataSource = listUser2;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listUser;

        }
    }
    class User
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string dept { get; set; }
        public string numberPhone { get; set; }
    }
}
