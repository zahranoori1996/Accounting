
using Accounting.DataLayer.Context;
using Accounting.Ui.Custoomers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Ui.Custoomers
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            BindGird();
        }
        void BindGird()
        {
            // زمانیکه از یوزینگ استفاده کردیم وقتی به بلوک پایانی برسه به صورت خودکار متد دیسپوز که در یونیت اف ورک گذاشتیم را فراخوانی میکنه و دیسپوز میشه
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false; // برای اینکه ستون های دیتا گرید ویو به صورت خودکار ایجاد نشه

                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty; // پاک کردن فیلتر
            BindGird();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork()) { 
                dgvCustomers.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddOrEditCustomer frmAdd = new FrmAddOrEditCustomer();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGird(); // بعد از اضافه کردن مشتری جدید، دیتا گرید ویو را دوباره بارگذاری میکنیم
            }
            //frmAdd.ShowDialog();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null) {
                using (UnitOfWork db = new UnitOfWork())
                {
                    
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString(); // گرفتن نام مشتری از سلول انتخاب شده
                    if(RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟","توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return; // اگر کاربر گزینه خیر را انتخاب کرد، از متد خارج می‌شود
                    }
                    // گرفتن آیدی مشتری از سلول انتخاب شده
                    int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
                    db.CustomerRepository.DeleteCustomer(customerId);
                    db.Save();
                    BindGird();
                }
                


            }
            else {
                RtlMessageBox.Show("لطفا یک ردیف را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
