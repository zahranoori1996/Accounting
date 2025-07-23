using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Ui
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
    }
}
