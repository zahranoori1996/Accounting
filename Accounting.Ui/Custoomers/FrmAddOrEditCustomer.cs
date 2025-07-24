using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;


namespace Accounting.Ui.Custoomers
{
    public partial class FrmAddOrEditCustomer : Form
    {
        UnitOfWork db = new UnitOfWork(); // ایجاد یک نمونه از یونیت اف ورک برای دسترسی به مخزن مشتری
        public FrmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcbCustomer.ImageLocation = openFile.FileName; // قرار دادن آدرس عکس انتخاب شده در PictureBox

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
               
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                // ایجاد پوشه اگر وجود ندارد
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                // تولید نام یکتا برای فایل
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcbCustomer.ImageLocation);
                string imagePath = Path.Combine(imagesFolder, imageName);

                // ذخیره تصویر
                try
                {
                    pcbCustomer.Image.Save(imagePath);
                    Customers customer = new Customers()
                    {
                        Fullname = txtbNameCustomer.Text,
                        Mobile = txtbMobileCustomer.Text,
                        Email = txtbEmailCustomer.Text,
                        Address = txtbAddressCustomer.Text,
                        CustomerImage = "NoImage.png" // در اینجا فرض میکنیم که اگر عکسی انتخاب نشه یک عکس پیشفرض قرار میدیم
                    };
                    db.CustomerRepository.InsertCustomers(customer);
                    db.Save(); // ذخیره تغییرات در دیتابیس
                    DialogResult = DialogResult.OK; // برای بستن فرم و برگشت به فرم قبلی
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطا در ذخیره تصویر: {ex.Message}");
                }
                
            }
        }
    }
}
