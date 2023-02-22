namespace ExLab5
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.boxProvince = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.Label();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.boxPostalcode = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(33, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 20);
            this.name.TabIndex = 0;
            this.name.Text = "User name:";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(154, 46);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(469, 22);
            this.boxName.TabIndex = 1;
            // 
            // boxAddress
            // 
            this.boxAddress.Location = new System.Drawing.Point(154, 90);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(469, 22);
            this.boxAddress.TabIndex = 3;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(53, 90);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 20);
            this.address.TabIndex = 2;
            this.address.Text = "Address:";
            // 
            // boxProvince
            // 
            this.boxProvince.Location = new System.Drawing.Point(154, 178);
            this.boxProvince.Name = "boxProvince";
            this.boxProvince.Size = new System.Drawing.Size(469, 22);
            this.boxProvince.TabIndex = 7;
            // 
            // province
            // 
            this.province.AutoSize = true;
            this.province.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.Location = new System.Drawing.Point(50, 178);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(79, 20);
            this.province.TabIndex = 6;
            this.province.Text = "Province:";
            // 
            // boxCity
            // 
            this.boxCity.Location = new System.Drawing.Point(154, 134);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(469, 22);
            this.boxCity.TabIndex = 5;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(86, 134);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(43, 20);
            this.city.TabIndex = 4;
            this.city.Text = "City:";
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(154, 266);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(469, 22);
            this.boxPhone.TabIndex = 11;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(68, 266);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(61, 20);
            this.phone.TabIndex = 10;
            this.phone.Text = "Phone:";
            // 
            // boxPostalcode
            // 
            this.boxPostalcode.Location = new System.Drawing.Point(154, 222);
            this.boxPostalcode.Name = "boxPostalcode";
            this.boxPostalcode.Size = new System.Drawing.Size(469, 22);
            this.boxPostalcode.TabIndex = 9;
            // 
            // postalcode
            // 
            this.postalcode.AutoSize = true;
            this.postalcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalcode.Location = new System.Drawing.Point(24, 222);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(105, 20);
            this.postalcode.TabIndex = 8;
            this.postalcode.Text = "Postal Code:";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.Control;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(427, 316);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(85, 30);
            this.confirm.TabIndex = 12;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(538, 316);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 30);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 362);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.boxPhone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.boxPostalcode);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.boxProvince);
            this.Controls.Add(this.province);
            this.Controls.Add(this.boxCity);
            this.Controls.Add(this.city);
            this.Controls.Add(this.boxAddress);
            this.Controls.Add(this.address);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox boxProvince;
        private System.Windows.Forms.Label province;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox boxPostalcode;
        private System.Windows.Forms.Label postalcode;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
    }
}

