namespace StoreProject
{
    partial class FrmProductCreate
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "เพิ่มสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(75, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชื่อสินค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "ราคาสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(75, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "จำนวนสินค้า";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(75, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "หน่วยสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(75, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "สถานะสินค้า";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(203, 322);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(196, 20);
            this.tbProName.TabIndex = 12;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(203, 358);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(196, 20);
            this.tbProPrice.TabIndex = 13;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(203, 440);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(196, 20);
            this.tbProUnit.TabIndex = 15;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(203, 485);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 16;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(301, 485);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 17;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProImage);
            this.panel1.Location = new System.Drawing.Point(141, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 213);
            this.panel1.TabIndex = 18;
            // 
            // pcbProImage
            // 
            this.pcbProImage.Location = new System.Drawing.Point(14, 14);
            this.pcbProImage.Name = "pcbProImage";
            this.pcbProImage.Size = new System.Drawing.Size(188, 181);
            this.pcbProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProImage.TabIndex = 0;
            this.pcbProImage.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Image = global::StoreProject.Properties.Resources.save;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(271, 532);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(128, 52);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "บันทึกเพิ่มสินค้า";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::StoreProject.Properties.Resources.cancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(78, 532);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(111, 52);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(203, 401);
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(196, 20);
            this.nudProQuan.TabIndex = 35;
            // 
            // btProImage
            // 
            this.btProImage.Location = new System.Drawing.Point(379, 251);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(35, 40);
            this.btProImage.TabIndex = 1;
            this.btProImage.UseVisualStyleBackColor = true;
            this.btProImage.Click += new System.EventHandler(this.btProImage_Click);
            // 
            // FrmProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 673);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductCreate";
            this.Text = "FrmProductCreate";
            this.Load += new System.EventHandler(this.FrmProductCreate_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.Button btProImage;
    }
}

