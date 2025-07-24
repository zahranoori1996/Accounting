namespace Accounting.Ui.Custoomers
{
    partial class FrmAddOrEditCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrEditCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pcbCustomer = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbAddressCustomer = new System.Windows.Forms.TextBox();
            this.lblAddressCustomer = new System.Windows.Forms.Label();
            this.txtbMobileCustomer = new System.Windows.Forms.TextBox();
            this.lblMobileCustomer = new System.Windows.Forms.Label();
            this.txtbEmailCustomer = new System.Windows.Forms.TextBox();
            this.lblEmailCustomer = new System.Windows.Forms.Label();
            this.txtbNameCustomer = new System.Windows.Forms.TextBox();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectPhoto);
            this.groupBox1.Controls.Add(this.pcbCustomer);
            this.groupBox1.Location = new System.Drawing.Point(284, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر";
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(6, 216);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(176, 33);
            this.btnSelectPhoto.TabIndex = 1;
            this.btnSelectPhoto.Text = "انتخاب تصویر";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // pcbCustomer
            // 
            this.pcbCustomer.Image = global::Accounting.Ui.Properties.Resources.no_profile_image;
            this.pcbCustomer.Location = new System.Drawing.Point(6, 20);
            this.pcbCustomer.Name = "pcbCustomer";
            this.pcbCustomer.Size = new System.Drawing.Size(176, 190);
            this.pcbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCustomer.TabIndex = 0;
            this.pcbCustomer.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbAddressCustomer);
            this.groupBox2.Controls.Add(this.lblAddressCustomer);
            this.groupBox2.Controls.Add(this.txtbMobileCustomer);
            this.groupBox2.Controls.Add(this.lblMobileCustomer);
            this.groupBox2.Controls.Add(this.txtbEmailCustomer);
            this.groupBox2.Controls.Add(this.lblEmailCustomer);
            this.groupBox2.Controls.Add(this.txtbNameCustomer);
            this.groupBox2.Controls.Add(this.lblNameCustomer);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات شخص";
            // 
            // txtbAddressCustomer
            // 
            this.txtbAddressCustomer.Location = new System.Drawing.Point(21, 178);
            this.txtbAddressCustomer.Multiline = true;
            this.txtbAddressCustomer.Name = "txtbAddressCustomer";
            this.txtbAddressCustomer.Size = new System.Drawing.Size(214, 64);
            this.txtbAddressCustomer.TabIndex = 7;
            // 
            // lblAddressCustomer
            // 
            this.lblAddressCustomer.AutoSize = true;
            this.lblAddressCustomer.Location = new System.Drawing.Point(196, 158);
            this.lblAddressCustomer.Name = "lblAddressCustomer";
            this.lblAddressCustomer.Size = new System.Drawing.Size(42, 13);
            this.lblAddressCustomer.TabIndex = 6;
            this.lblAddressCustomer.Text = "آدرس : ";
            // 
            // txtbMobileCustomer
            // 
            this.txtbMobileCustomer.Location = new System.Drawing.Point(21, 129);
            this.txtbMobileCustomer.Name = "txtbMobileCustomer";
            this.txtbMobileCustomer.Size = new System.Drawing.Size(214, 21);
            this.txtbMobileCustomer.TabIndex = 5;
            // 
            // lblMobileCustomer
            // 
            this.lblMobileCustomer.AutoSize = true;
            this.lblMobileCustomer.Location = new System.Drawing.Point(196, 110);
            this.lblMobileCustomer.Name = "lblMobileCustomer";
            this.lblMobileCustomer.Size = new System.Drawing.Size(42, 13);
            this.lblMobileCustomer.TabIndex = 4;
            this.lblMobileCustomer.Text = "موبایل :";
            // 
            // txtbEmailCustomer
            // 
            this.txtbEmailCustomer.Location = new System.Drawing.Point(21, 82);
            this.txtbEmailCustomer.Name = "txtbEmailCustomer";
            this.txtbEmailCustomer.Size = new System.Drawing.Size(214, 21);
            this.txtbEmailCustomer.TabIndex = 3;
            // 
            // lblEmailCustomer
            // 
            this.lblEmailCustomer.AutoSize = true;
            this.lblEmailCustomer.Location = new System.Drawing.Point(199, 65);
            this.lblEmailCustomer.Name = "lblEmailCustomer";
            this.lblEmailCustomer.Size = new System.Drawing.Size(39, 13);
            this.lblEmailCustomer.TabIndex = 2;
            this.lblEmailCustomer.Text = "ایمیل :";
            // 
            // txtbNameCustomer
            // 
            this.txtbNameCustomer.Location = new System.Drawing.Point(21, 37);
            this.txtbNameCustomer.Name = "txtbNameCustomer";
            this.txtbNameCustomer.Size = new System.Drawing.Size(214, 21);
            this.txtbNameCustomer.TabIndex = 1;
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Location = new System.Drawing.Point(211, 19);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(27, 13);
            this.lblNameCustomer.TabIndex = 0;
            this.lblNameCustomer.Text = "نام :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtbNameCustomer;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام را وارد نمایید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtbMobileCustomer;
            this.requiredFieldValidator2.ErrorMessage = "لطفا موبایل را وارد نمایید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // FrmAddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddOrEditCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص جدید";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbNameCustomer;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.TextBox txtbAddressCustomer;
        private System.Windows.Forms.Label lblAddressCustomer;
        private System.Windows.Forms.TextBox txtbMobileCustomer;
        private System.Windows.Forms.Label lblMobileCustomer;
        private System.Windows.Forms.TextBox txtbEmailCustomer;
        private System.Windows.Forms.Label lblEmailCustomer;
        private System.Windows.Forms.PictureBox pcbCustomer;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnSave;
        //private ValidationComponents.RequiredFieldValidator requiredFieldValidatorName;
        //private ValidationComponents.RequiredFieldValidator requiredFieldValidatorMobile;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}