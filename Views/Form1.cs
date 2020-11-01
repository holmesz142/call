using call.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.IO;
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


            listUser.Add(new User() { urlToImage = @"C:\Users\Admin\source\repos\call\call\2.png", userName = "pham tan dat", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "tran quoc dai", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "duong quoc huy", dept = "cntt", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "dao hong vinh", dept = "ktmt", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "phung vinh duc", dept = "ktdl", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "huynh thanh tam", dept = "abcd", numberPhone = "12315645" });
            listUser.Add(new User() { urlToImage = "1.jpg", userName = "phung cong chien", dept = "edgh", numberPhone = "12315645" });
            
            
        }


        private void searchUser_TextChanged(object sender, EventArgs e)
        {
            List<User> listUser2 = new List<User>();
            if (string.IsNullOrEmpty(searchUser.Text) == false)
            {
                foreach(User user in listUser)
                {
                    if (user.dept.StartsWith(searchUser.Text.ToLower()))
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
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Form2 frm = new Form2();
            frm.Show();
        }
    }
    class User
    {
        public string ID { get; set; }
        public string urlToImage { get; set; }
        public string userName { get; set; }
        public string dept { get; set; }
        public string numberPhone { get; set; }
       

        [NotMapped]
        public Image Avatar
        {
            get
            {
                if (!string.IsNullOrEmpty(urlToImage))
                {
                    if (File.Exists(urlToImage))
                        return Image.FromFile(urlToImage);
                }
                return null;
            }
        }
    }
}
