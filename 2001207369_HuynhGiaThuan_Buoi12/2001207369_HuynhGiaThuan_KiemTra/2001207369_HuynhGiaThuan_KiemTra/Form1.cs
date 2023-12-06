using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2001207369_HuynhGiaThuan_KiemTra
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-ALA9RHJO\\SQLEXPRESS;Initial Catalog=QLHN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();


            LoadDGV_HoiNghi();
            LoadCBX_HoiNghi();
        }


        private void LoadDGV_HoiNghi()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from HoiNghi";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_HoiNghi.DataSource = table;
        }


        private void LoadCBX_HoiNghi()
        {
            try
            {

                SqlCommand sqlCmd = new SqlCommand("select * from LoaiPhong", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {

                    cbxLoaiPhong.Items.Add(sqlReader["tenLoaiPhong"].ToString());
                    cbxLoaiPhong.SelectedIndex = 0;
                }

                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi  Load CBX Loại Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGV_HoiNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGV_HoiNghi.CurrentRow.Index;
            txtMaPhongHoiNghi.Text = DGV_HoiNghi.Rows[i].Cells[0].Value.ToString();
            txtTenHoiNghi.Text = DGV_HoiNghi.Rows[i].Cells[1].Value.ToString();
            txtSoLuong.Text = DGV_HoiNghi.Rows[i].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaPhongHoiNghi.Text = null;
            txtTenHoiNghi.Text = null;
            txtSoLuong.Text = null; txtSoLuong.Text = null;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenHoiNghi.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Hội Nghị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập Số lượng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (int.Parse(txtSoLuong.Text) > 50)
                    {
                        DialogResult dlr = MessageBox.Show("\nThêm phòng hội nghị   ", "Xác Nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            Random rand = new Random();
                            string kytu = "HN";
                            string s = "";
                            int temp = 5;
                            string number;
                            int num = 5;
                            number = num.ToString();
                            List<int> list = new List<int>();
                            for (int i = 0; i <= 5; i++)
                            {
                                list.Add(i);
                                //list.Add(rand.Next(a));
                            }
                            //random
                            for (int i = 0; i <= 4; i++)
                            {
                                temp = rand.Next(list.Count);
                                s += list[temp];
                                list.RemoveAt(temp);

                            }


                          


                            string Ma = kytu + s;
                            //cmd.CommandText = @"insert into HoiNghi values ('" + Ma.Trim() + "',N'" + txtTenHoiNghi.Text.Trim() + "'," + int.Parse(txtSoLuong.Text) + ",N'" + cbxLoaiPhong.Text.Trim() + "')";


                            cmd.CommandText = @"EXEC InsertHoiNghi  @maHoiNghi = '" + Ma.Trim() + "', @tenHoiNghi = N'" + txtTenHoiNghi.Text.Trim() + "', @SoNguoi = " + int.Parse(txtSoLuong.Text) + ",   @tenLoaiPhong = N'" + cbxLoaiPhong.Text.Trim() + "'; ";

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm Phòng Hội Nghị Thành Công :", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            LoadDGV_HoiNghi();

                        }
                        else
                        {
                            MessageBox.Show("Yêu Cầu Đã hủy", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                    }

                    else
                    {
                        MessageBox.Show("Số lượng trên 50", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Detele();
        }


        private void Detele()
        {

            if ((string.IsNullOrEmpty(txtMaPhongHoiNghi.Text)))
            {
                MessageBox.Show("Vui Lòng Chọn Phòng Muốn Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult dlr = MessageBox.Show("\nXóa Phòng Hội Nghị   ", "Xác Nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "delete from HoiNghi where maHoiNghi = '" + txtMaPhongHoiNghi.Text.Trim() + "'";
                        adapter.SelectCommand = cmd;
                        table.Clear();
                        adapter.Fill(table);
                        DGV_HoiNghi.DataSource = table;

                        MessageBox.Show("Xoá thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadDGV_HoiNghi();
                    }
                    else
                    {
                        MessageBox.Show("Yêu Cầu Đã hủy", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                catch
                {
                    MessageBox.Show("Xe Đã Có Lịch");
                }
            }


        }

        private void btn_LocDuLieu_Click(object sender, EventArgs e)
        {
            LocDuLieu();
        }


        private void LocDuLieu() 
        {

            if ((string.IsNullOrEmpty(cbxLoaiPhong.Text.Trim())))
            {
                MessageBox.Show("Vui Lòng Chọn Loai Phong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "EXEC GetHoiNghiByLoaiPhong @tenLoaiPhong = N'"+cbxLoaiPhong.Text.Trim()+"'";
                adapter.SelectCommand = cmd;
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGV_HoiNghi.DataSource = table;
               
            }

        }
    }
}
