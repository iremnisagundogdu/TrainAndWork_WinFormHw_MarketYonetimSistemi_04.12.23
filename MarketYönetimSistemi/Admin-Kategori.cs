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
    public partial class Admin_Kategori : Form
    {
        Category category = new Category();
        CategoryCrud categoryCrud = new CategoryCrud();
        Functions function = new Functions();
        public static int id = 0;
        public Admin_Kategori()
        {
            InitializeComponent();
        }

       

        private void Admin_Kategori_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryCrud.GetAll();
        }

        private void CategoryAddBtn_Click(object sender, EventArgs e)
        {
            category.Name = CategoryNameTxt.Text;
            category.Description = CategoryDescTxt.Text;
            category.IsStatus = CategoryStatusCheck.Checked;

            string CategoryImg = "";
            string imagePath = @"C:\Users\_irem\Desktop\image\";
            string defaultImage = "emptyUser.jpg";

            if (CategoryPb.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                CategoryPb.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                CategoryImg = imagePath + imageName;
            }
            else
            {
                CategoryImg = imagePath + defaultImage;
            }
            category.Image = CategoryImg;
            MessageLbl.Visible = true;
            MessageLbl.Text = categoryCrud.Add(category) ?
                                    "Category Ekleme Başarılı" :
                                    "Category Ekleme Başarısız";
        }

        private void selectImageCatBtn_Click(object sender, EventArgs e)
        {
            function.UploadPictureBoxImage(CategoryPb);
        }

        private void CategoryDeleteBtn_Click(object sender, EventArgs e)
        {
            categoryCrud.Delete(id);
            dataGridView1.DataSource = categoryCrud.GetAll();
        }

        private void KategoriBtn_Click(object sender, EventArgs e)
        {
            Admin_Kategori aKat = new Admin_Kategori();
            aKat.Show();
        }

        private void MusteriBtn_Click(object sender, EventArgs e)
        {
            Admin_Müsteri aKat = new Admin_Müsteri();
            aKat.Show();
        }

        private void UrunBtn_Click(object sender, EventArgs e)
        {
            Admin_Ürün ürün = new Admin_Ürün();
            ürün.Show();
        }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            Admin_Rapor rapor = new Admin_Rapor();
            rapor.Show();
        }

        private void CategoryUpdateBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            string upcategoryName = CategoryNameTxt.Text;
            string upcategoryDesc = CategoryDescTxt.Text;
            bool upstatus = CategoryStatusCheck.Checked;
   

            {
                Category updatedCategory = new Category
                {
                    Name = upcategoryName,
                    Description = upcategoryDesc,
                    IsStatus = upstatus,
                    

                };
                categoryCrud.Update(updatedCategory, id);
                dataGridView1.DataSource = categoryCrud.GetAll();
            }
        }
    }
    }

