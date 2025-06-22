using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class FrmProductUpDel : Form
    {

        //สร้างตัวแปรเก็บรูปที่แปลงเป็น Binary/Byte Array เอาไว้บันทึก DB
        byte[] proImage;

        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        //สร้างตัวแปรกับ proId ที่ส่งมาจาก Fr,Product
        int proId;
        public FrmProductUpDel(int proId)
        {
            InitializeComponent();
            this.proId = proId;
        }
        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ArgumentException ex)
            {
                // อาจเกิดขึ้นถ้า byte array ไม่ใช่ข้อมูลรูปภาพที่ถูกต้อง
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }
        private void FrmProductUpDel_Load(object sender, EventArgs e)
        {
            //Connect String เพื่อติดต่อไปยังฐานข้อมูล
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            //สร้าง Connection ไปยังฐานข้อมูล
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open(); //เปิดการเชื่อมต่อไปยังฐานข้อมูล

                    //สร้างคำสั่ง SQL ในที่นี้คือ ดึงข้อมูลทั้งหมดจากตาราง product_tb
                    string strSQL = "SELECT proId, proName, proPrice, proQuan, proUnit, proStatus, proImage FROM product_tb " +
                                    "WHERE proId=@proId";

                    //จัดการให้ SQL ทำงาน
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        //กำหนดค่าให้กับ SQL Parameter
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@proId", proId);
                        //เอาข้อมูลที่ได้จาก strSQL ซึ่งเป็นก้อนใน dataAdapter มาทำให้เป็นตารางโดยใส่  dataTable
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        //เอาข้อมูลจาก DataTable มาใช้โดยใส่ไว้ใน DataRow
                        DataRow row = dataTable.Rows[0];

                        //เอาข้อมูลใน DataRow มาใช้งาน
                        tbProId.Text = row["proId"].ToString();
                        tbProName.Text = row["proName"].ToString();
                        tbProPrice.Text = row["proPrice"].ToString();
                        tbProUnit.Text = row["proUnit"].ToString();
                        nudProQuan.Value = int.Parse(row["proQuan"].ToString());
                        if (row["proStatus"].ToString() == "พร้อมขาย")
                        {
                            rdoProStatusOn.Checked = true;
                        }
                        else
                        {
                            rdoProStatusOff.Checked = true;
                        }
                        //เอารูปมาแสดง โดยต้องแปลงรูปซึ่งเป็น binary/byte array ให้เป็นตัวรูป
                        if (row["proImage"] == DBNull.Value)
                        {
                            pcbProImage.Image = null;
                        }
                        else
                        {
                            pcbProImage.Image = convertByteArrayToImage((byte[])row["proImage"]);
                        }

                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติอต่อ IT :" + ex.Message);
                }
            }
        }

        private void btProDelete_Click(object sender, EventArgs e)
        {
            //ลบข้อมูลสินค้าออกจากตารางใน DB
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); // ใช้กับ Insert/update/delete

                    //คำสั่ง SQl
                    string strSQL = "DELETE FROM product_tb WHERE proId=@proId";
                    using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                    {

                        sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = tbProId.Text;


                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        MessageBox.Show("ลบเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติอต่อ IT: " + ex.Message);
                }



            }
        }

        private void btProUpdate_Click(object sender, EventArgs e)
        {
            //Validate UI แสเงแล้วก็เอาข้อมูลไปบันทีกลง DB
            //พอบันทึกเสร็จแสดงข้อความบอกผู้ใช้ และปิดหน้าจอ FrmProductCreate และกลับไปยังหน้าจอ FrmProduct Show
            if (proImage == null)
            {
                showWarningMSG("เลือกรูปด้วย");
            }
            else if (tbProName.Text.Length == 0)
            {
                showWarningMSG("ป้อนชื่อสินค้าด้วย");
            }
            else if (tbProPrice.Text.Length == 0)
            {
                showWarningMSG("ป้อนราคาสินค้าด้วย");
            }
            else if (int.Parse(nudProQuan.Value.ToString()) <= 0)
            {
                showWarningMSG("จำนวนสินค้าต้องมากกว่า 0");
            }
            else if (tbProUnit.Text.Length == 0)
            {
                showWarningMSG("ป้อนหน่วยสินค้าด้วย");
            }
            else
            {
                //Connect String เพื่อติดต่อไปยังฐานข้อมูล
                string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); // ใช้กับ Insert/update/delete

                        //คำสั่ง SQl
                        string strSQL = "UPDATE product_tb SET " +
                                        "proName=@proName, proPrice=@proPrice," +
                                        "proQuan=@proQuan, proUnit=@proUnit," +
                                        "proStatus=@proStatus, proImage=@proImage," +
                                        "updateAt=@updateAt WHERE ProId=@proId ";
                        using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = tbProId.Text;
                            sqlCommand.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            sqlCommand.Parameters.Add("@proPrice", SqlDbType.Float).Value = float.Parse(tbProPrice.Text);
                            sqlCommand.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse(nudProQuan.Value.ToString());
                            sqlCommand.Parameters.Add("@proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;
                            if (rdoProStatusOn.Checked == true)
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "พร้อมขาย";
                            }
                            else
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "ไม่พร้อมขาย";
                            }
                            sqlCommand.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            sqlCommand.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;

                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();

                            MessageBox.Show("แก้ไขเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติอต่อ IT: " + ex.Message);
                    }

                }
            }
        }

        private void btProImage_Click(object sender, EventArgs e)
        {
            //เปิด File Dialog ให้เลือกรูปโดยฟิวเตอร์เฉพาะไฟล์ jpg/png
            //แล้วนำรูปที่เลือกไปแสดงที่ pcbProImage
            //แล้วก็แปลงเป็น Binary/Byte เก็บในตัวแปรเพื่อเอาไว้บันทึกลง DB
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //เอารูปที่เลือกไปแสดงที่ pcbProImage
                pcbProImage.Image = Image.FromFile(openFileDialog.FileName);
                //ตรวจสอบ Format ของรูป แล้วส่งรูปไปแปลงเป็น Binary/Byte เก็บในตัวแปร
                if (pcbProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Jpeg);
                }
                else
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Png);
                }
            }
        }
    }
}

