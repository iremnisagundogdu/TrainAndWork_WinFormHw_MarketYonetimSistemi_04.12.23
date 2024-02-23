using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class Admin_Müsteri : Form
    {

        User user = new User();
        UserCrud userCrud = new UserCrud();
        Functions function = new Functions();
        public static int id = 0;
        public Admin_Müsteri()
        {
            InitializeComponent();
        }

        private void Admin_Müsteri_Load(object sender, EventArgs e)
        {
            Musteridgv.DataSource = userCrud.GetAll();
        }

        private void MusteriAddBtn_Click(object sender, EventArgs e)
        {
            user.Name = musteriAdTxt.Text;
            user.Surname = MusteriSoyadTxt.Text;
            user.Email = MusteriMailTxt.Text;
            user.Password = MusteriSifre.Text;
            user.IsStatus = MusteriStatusCheck.Checked;
            string UserImg = "";
            string imagePath = @"C:\Users\_irem\Desktop\image\";
            string defaultImage = "emptyUser.jpg";

            if (UserPb.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                UserPb.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                UserImg = imagePath + imageName;
            }
            else
            {
                UserImg = imagePath + defaultImage;
            }
            user.Image = UserImg;
            MessageLbl.Visible = true;
            MessageLbl.Text = userCrud.Add(user) ?
                                    "Category Ekleme Başarılı" :
                                    "Category Ekleme Başarısız";
        }

        private void MusteriSilBtn_Click(object sender, EventArgs e)
        {
            userCrud.Delete(id);
            Musteridgv.DataSource = userCrud.GetAll();
        }

        private void MusteriGuncelleBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Musteridgv.CurrentRow.Cells["Id"].Value);

            string updatedName = musteriAdTxt.Text;
            string updatedSurname = MusteriSoyadTxt.Text;
            string updatedMail = MusteriMailTxt.Text;
            string updatedPassword = MusteriSifre.Text;
            bool updatedStatus = MusteriStatusCheck.Checked;
            {
                User updatedUser = new User
                {
                    Name = updatedName,
                    Surname = updatedSurname,
                    Email = updatedMail,
                    Password = updatedPassword,
                    IsStatus= updatedStatus

                };
                userCrud.Update(updatedUser, id);
                Musteridgv.DataSource = userCrud.GetAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Kategori aKat = new Admin_Kategori();
            aKat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Müsteri aKat = new Admin_Müsteri();
            aKat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Rapor rapor = new Admin_Rapor();
            rapor.Show();
        }
    }
}
