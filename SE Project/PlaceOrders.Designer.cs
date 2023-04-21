
namespace SE_Project
{
    partial class PlaceOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_Vendor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillAdrr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_ProductsOfVendor = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openCart = new System.Windows.Forms.Button();
            this.txtQuantityItem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProductsOfVendor)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT ORDER FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deliveryDate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cb_Vendor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBillAdrr);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(406, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 137);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ORDERS";
            // 
            // deliveryDate
            // 
            this.deliveryDate.Location = new System.Drawing.Point(133, 61);
            this.deliveryDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(255, 22);
            this.deliveryDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Select a vendor:";
            // 
            // cb_Vendor
            // 
            this.cb_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vendor.FormattingEnabled = true;
            this.cb_Vendor.Location = new System.Drawing.Point(133, 98);
            this.cb_Vendor.Name = "cb_Vendor";
            this.cb_Vendor.Size = new System.Drawing.Size(255, 24);
            this.cb_Vendor.TabIndex = 9;
            this.cb_Vendor.TextChanged += new System.EventHandler(this.cb_Vendor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Delivery time:";
            // 
            // txtBillAdrr
            // 
            this.txtBillAdrr.Location = new System.Drawing.Point(133, 24);
            this.txtBillAdrr.Name = "txtBillAdrr";
            this.txtBillAdrr.Size = new System.Drawing.Size(255, 22);
            this.txtBillAdrr.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Billing address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhoneStaff);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmailStaff);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNameStaff);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STAFF";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Location = new System.Drawing.Point(99, 98);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(255, 22);
            this.txtPhoneStaff.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone:";
            // 
            // txtEmailStaff
            // 
            this.txtEmailStaff.Location = new System.Drawing.Point(99, 62);
            this.txtEmailStaff.Name = "txtEmailStaff";
            this.txtEmailStaff.Size = new System.Drawing.Size(255, 22);
            this.txtEmailStaff.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Location = new System.Drawing.Point(99, 25);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(255, 22);
            this.txtNameStaff.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_ProductsOfVendor);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(840, 304);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "The list of products";
            // 
            // grd_ProductsOfVendor
            // 
            this.grd_ProductsOfVendor.AllowUserToAddRows = false;
            this.grd_ProductsOfVendor.AllowUserToDeleteRows = false;
            this.grd_ProductsOfVendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd_ProductsOfVendor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grd_ProductsOfVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ProductsOfVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ProductsOfVendor.Location = new System.Drawing.Point(3, 20);
            this.grd_ProductsOfVendor.Name = "grd_ProductsOfVendor";
            this.grd_ProductsOfVendor.ReadOnly = true;
            this.grd_ProductsOfVendor.RowHeadersWidth = 104;
            this.grd_ProductsOfVendor.Size = new System.Drawing.Size(834, 281);
            this.grd_ProductsOfVendor.TabIndex = 17;
            this.grd_ProductsOfVendor.Click += new System.EventHandler(this.grd_ProductsOfVendor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.openCart);
            this.groupBox5.Controls.Add(this.txtQuantityItem);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtNameItem);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(12, 537);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(840, 132);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Item information and Features";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(427, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 38);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openCart
            // 
            this.openCart.Location = new System.Drawing.Point(733, 14);
            this.openCart.Name = "openCart";
            this.openCart.Size = new System.Drawing.Size(101, 35);
            this.openCart.TabIndex = 14;
            this.openCart.Text = "Cart";
            this.openCart.UseVisualStyleBackColor = true;
            this.openCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuantityItem
            // 
            this.txtQuantityItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityItem.Location = new System.Drawing.Point(106, 62);
            this.txtQuantityItem.Name = "txtQuantityItem";
            this.txtQuantityItem.Size = new System.Drawing.Size(79, 22);
            this.txtQuantityItem.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Quantity:";
            // 
            // txtNameItem
            // 
            this.txtNameItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameItem.Location = new System.Drawing.Point(106, 26);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.ReadOnly = true;
            this.txtNameItem.Size = new System.Drawing.Size(216, 22);
            this.txtNameItem.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name of item:";
            // 
            // PlaceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 678);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlaceOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceOrders";
            this.Load += new System.EventHandler(this.PlaceOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProductsOfVendor)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillAdrr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_Vendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grd_ProductsOfVendor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button openCart;
        private System.Windows.Forms.TextBox txtQuantityItem;
        private System.Windows.Forms.Label label14;
    }
}