namespace StoreProject
{
    partial class FrmProductUpDel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProUpdate = new System.Windows.Forms.Button();
            this.btProDelete = new System.Windows.Forms.Button();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProImage);
            this.panel1.Location = new System.Drawing.Point(137, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 213);
            this.panel1.TabIndex = 33;
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
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(299, 570);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 32;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(201, 570);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 31;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(201, 525);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(196, 20);
            this.tbProUnit.TabIndex = 30;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(201, 443);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(196, 20);
            this.tbProPrice.TabIndex = 28;
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(201, 407);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(196, 20);
            this.tbProName.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(73, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "สถานะสินค้า";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(73, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "หน่วยสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(73, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "จำนวนสินค้า";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "ราคาสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(73, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "ชื่อสินค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "แก้ไข/ลบสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btProUpdate
            // 
            this.btProUpdate.Image = global::StoreProject.Properties.Resources.update;
            this.btProUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProUpdate.Location = new System.Drawing.Point(292, 617);
            this.btProUpdate.Name = "btProUpdate";
            this.btProUpdate.Size = new System.Drawing.Size(105, 52);
            this.btProUpdate.TabIndex = 26;
            this.btProUpdate.Text = "บันทึกแก้ไขสินค้า";
            this.btProUpdate.UseVisualStyleBackColor = true;
            this.btProUpdate.Click += new System.EventHandler(this.btProUpdate_Click);
            // 
            // btProDelete
            // 
            this.btProDelete.Image = global::StoreProject.Properties.Resources.delete;
            this.btProDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProDelete.Location = new System.Drawing.Point(76, 617);
            this.btProDelete.Name = "btProDelete";
            this.btProDelete.Size = new System.Drawing.Size(111, 52);
            this.btProDelete.TabIndex = 25;
            this.btProDelete.Text = "ลบสินค้า";
            this.btProDelete.UseVisualStyleBackColor = true;
            this.btProDelete.Click += new System.EventHandler(this.btProDelete_Click);
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(201, 483);
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(196, 20);
            this.nudProQuan.TabIndex = 34;
            // 
            // btProImage
            // 
            this.btProImage.Location = new System.Drawing.Point(383, 286);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(45, 45);
            this.btProImage.TabIndex = 35;
            this.btProImage.UseVisualStyleBackColor = true;
            this.btProImage.Click += new System.EventHandler(this.btProImage_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(73, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "รหัสสินค้า";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProId
            // 
            this.tbProId.Location = new System.Drawing.Point(201, 370);
            this.tbProId.Name = "tbProId";
            this.tbProId.ReadOnly = true;
            this.tbProId.Size = new System.Drawing.Size(196, 20);
            this.tbProId.TabIndex = 37;
            // 
            // FrmProductUpDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 673);
            this.Controls.Add(this.tbProId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProUpdate);
            this.Controls.Add(this.btProDelete);
            this.Name = "FrmProductUpDel";
            this.Text = "FrmProductUpDel";
            this.Load += new System.EventHandler(this.FrmProductUpDel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProUpdate;
        private System.Windows.Forms.Button btProDelete;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.Button btProImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProId;
    }
}