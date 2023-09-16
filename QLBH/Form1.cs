using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNL.Text) || string.IsNullOrEmpty(txtTenNL.Text) || string.IsNullOrEmpty(txtGiaMua.Text)|| string.IsNullOrEmpty(txtSL.Text)|| string.IsNullOrEmpty(txtLoai.Text))
                    throw new Exception("Nhap day du thong tin SV");
                int selectedRow = GetSelectedRow(txtMaNL.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dataGridView1.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thong Bao", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thong Bao", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertUpdate(int selectedRow)
        {
            dataGridView1.Rows[selectedRow].Cells[0].Value = txtMaNL.Text;
            dataGridView1.Rows[selectedRow].Cells[1].Value = txtTenNL.Text;
            dataGridView1.Rows[selectedRow].Cells[2].Value = int.Parse(txtSL.Text).ToString();
            dataGridView1.Rows[selectedRow].Cells[3].Value = double.Parse(txtGiaMua.Text).ToString();
            dataGridView1.Rows[selectedRow].Cells[4].Value = txtLoai.Text;
        }
        private int GetSelectedRow(string studentID)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value.ToString() == studentID)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int selectedRow = GetSelectedRow(txtMaNL.Text);
                    if (selectedRow == -1)
                    {
                        throw new Exception("Khong tim duoc MSSV can xoa");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Ban co muon xoa?", "YES/NP", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            dataGridView1.Rows.RemoveAt(selectedRow);
                            MessageBox.Show("Xoa Sinh vien thanh cong!", "Thong bao", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
