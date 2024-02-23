using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class Admin : Form
    {
        Product product = new Product();
        ProductCrud productCrud = new ProductCrud();
        Functions function = new Functions();
        public static int id = 0;


        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Urundgv.DataSource = productCrud.GetAll();
        }

        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            product.Name = UrunAdTxt.Text;
            product.Stock = Convert.ToInt32(UrunStokTxt.Text);
            product.Price = Convert.ToInt32(UrunFiyatTxt.Text);
            product.Description = UrunAcıklamaTxt.Text;
            product.CategoryId = Convert.ToInt32(UrunKategoriCb.SelectedValue);

        }

        private void UrunSilBtn_Click(object sender, EventArgs e)
        {
            productCrud.Delete(id);
            Urundgv.DataSource = productCrud.GetAll();
        }

        private void UrunGuncelleBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Urundgv.CurrentRow.Cells["Id"].Value);

            string updatedName = UrunAdTxt.Text;
            string updatedDesc = UrunAcıklamaTxt.Text;
            int updatedPrice = Convert.ToInt32(UrunFiyatTxt.Text);
            int updatedStock = Convert.ToInt32(UrunStokTxt.Text);
            
            {
                Product updatedProduct = new Product
                {
                    Name = updatedName,
                    Description = updatedDesc,
                    Price = updatedPrice,
                    Stock = updatedStock,
                   
                };
                productCrud.Update(updatedProduct, id);
                Urundgv.DataSource = productCrud.GetAll();
            }
        }
        private void UrunBtn_Click(object sender, EventArgs e)
        {
            Admin_Ürün ürün = new Admin_Ürün();
            ürün.Show();
        }

        private void KategoriBtn_Click(object sender, EventArgs e)
        {
            Admin_Kategori aKat = new Admin_Kategori();
            aKat.Show();

        }

        private void MüsteriBtn_Click(object sender, EventArgs e)
        {
            Admin_Müsteri aMüs = new Admin_Müsteri();
            aMüs.Show();
        }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            Admin_Rapor rapor = new Admin_Rapor();
            rapor.Show();
        }
    }
}
