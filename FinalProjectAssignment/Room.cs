using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectAssignment
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        int red, green;
        private void A1_Click(object sender, EventArgs e)
        {
            if (A1.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA1ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A1.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A1";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA1เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A1.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (A2.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA2ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A2.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A2";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA2เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A2.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA3ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A3.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A3";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA3เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A3.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (A4.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA4ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A4.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A4";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA4เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A4.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (A5.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA5ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A5.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A5";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA5เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A5.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A6_Click(object sender, EventArgs e)
        {
            if (A6.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA6ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A6.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A6";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA6เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A6.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A7_Click(object sender, EventArgs e)
        {
            if (A7.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA7ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A7.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A7";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA7เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A7.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A8_Click(object sender, EventArgs e)
        {
            if (A8.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA8ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A8.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A8";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA8เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A8.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void A9_Click(object sender, EventArgs e)
        {
            if (A9.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจองห้องเรียนA9ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A9.BackColor = Color.Red;
                red++;
                green--;
                txtNumRoom.Text = txtNumRoom.Text + "A9";
            }
            else
            {
                if (MessageBox.Show("คุณใช้ห้องเรียนA9เสร็จแล้วใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    A9.BackColor = Color.LawnGreen;
                red--;
                green++;
                txtNumRoom.Clear();
            }
            labelEmptyRoom.Text = green.ToString();
            labelBusyRoom.Text = red.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView2.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView2.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView2.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView2.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView2.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erorr :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonAddRoom_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtNameBooking.Text, txtNumRoom.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtClassroomTime.Text);
        }

        private void Room_Load_1(object sender, EventArgs e)
        {
            A1.BackColor = Color.LawnGreen;
            A2.BackColor = Color.LawnGreen;
            A3.BackColor = Color.LawnGreen;
            A4.BackColor = Color.LawnGreen;
            A5.BackColor = Color.LawnGreen;
            A6.BackColor = Color.LawnGreen;
            A7.BackColor = Color.LawnGreen;
            A8.BackColor = Color.LawnGreen;
            A9.BackColor = Color.LawnGreen;

            if (A1.BackColor == Color.LawnGreen)
                green++;
            if (A2.BackColor == Color.LawnGreen)
                green++;
            if (A3.BackColor == Color.LawnGreen)
                green++;
            if (A4.BackColor == Color.LawnGreen)
                green++;
            if (A5.BackColor == Color.LawnGreen)
                green++;
            if (A6.BackColor == Color.LawnGreen)
                green++;
            if (A7.BackColor == Color.LawnGreen)
                green++;
            if (A8.BackColor == Color.LawnGreen)
                green++;
            if (A9.BackColor == Color.LawnGreen)
                green++;

            labelEmptyRoom.Text = green.ToString();
        }
    }
}
