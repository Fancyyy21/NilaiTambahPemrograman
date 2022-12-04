using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NilaiTambahUTS
{
    public partial class NilaiTambahUTS : Form
    {
        public NilaiTambahUTS()
        {
            InitializeComponent();
            this.Size = new Size(984, 243);
        }

        private void FormDataReservasi_Click(object sender, EventArgs e)
        {
            if (tbNIK.Text != "")
            {
                if (tbNAMA.Text != "")
                {
                    if (Laki.Checked || Perempuan.Checked)
                    {
                        if (tbALAMAT.Text != "")
                        {
                            if (tbNOHP.Text != "")
                            {
                                if (Regex.IsMatch(tbEMAIL.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                                {
                                    MessageBox.Show
                                   ("LENGKAP!!",
                                   "Informasi Data Submit",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Size = new Size(1004, 515);
                                }
                                else
                                {
                                    MessageBox.Show
                                ("Email Belum Diisi!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                            ("No HP Belum Diisi!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                        ("Alamat Belum Diisi!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                    ("Jenis Kelamin Belum Diisi!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                ("Nama Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("NIK Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tbNIK_TextChanged(object sender, EventArgs e)
        {
            if (tbNIK.Text == "")
            {
                epCorrect.SetError(tbNIK, "");
                epWarning.SetError(tbNIK, "Textbox NIK tidak boleh kosong");
                epWrong.SetError(tbNIK, "");
            }
            else
            {
                if ((tbNIK.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbNIK, "Betul");
                    epWarning.SetError(tbNIK, "");
                    epWrong.SetError(tbNIK, "");
                }
                else
                {
                    epCorrect.SetError(tbNIK, "");
                    epWarning.SetError(tbNIK, "");
                    epWrong.SetError(tbNIK, "Inputan hanya boleh angka!");
                }
            }
        }
        private void tbNOHP_TextChanged(object sender, EventArgs e)
        {
            if (tbNOHP.Text == "")
            {
                epCorrect.SetError(tbNOHP, "");
                epWarning.SetError(tbNOHP, "Textbox NOHP tidak boleh kosong");
                epWrong.SetError(tbNOHP, "");
            }
            else
            {
                if ((tbNOHP.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbNOHP, "Betul");
                    epWarning.SetError(tbNOHP, "");
                    epWrong.SetError(tbNOHP, "");
                }
                else
                {
                    epCorrect.SetError(tbNOHP, "");
                    epWarning.SetError(tbNOHP, "");
                    epWrong.SetError(tbNOHP, "Inputan hanya boleh angka!");
                }
            }
        }

        private void tbEMAIL_Leave(object sender, EventArgs e)
        {
            if (tbEMAIL.Text == "")
            {
                epWarning.SetError(tbEMAIL, "Textbox Email tidak boleh kosong");
                epWrong.SetError(tbEMAIL, "");
                epCorrect.SetError(tbEMAIL, "");
            }
            else
            {
                if (Regex.IsMatch(tbEMAIL.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEMAIL, "");
                    epWrong.SetError(tbEMAIL, "");
                    epCorrect.SetError(tbEMAIL, "Betul");
                }
                else
                {
                    epWarning.SetError(tbEMAIL, "Format email salah!\nContoh: a@b.c");
                    epWrong.SetError(tbEMAIL, "");
                    epCorrect.SetError(tbEMAIL, "");
                }
            }
        }

        private void FormDataPembayaran_Click(object sender, EventArgs e)
        {
            if (tbCHECKIN.Text != "" && Regex.IsMatch(tbCHECKIN.Text, @"^\d{2}/\d{2}/\d{4}$"))
            {
                if (tbCHECKOUT.Text != "" && Regex.IsMatch(tbCHECKIN.Text, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    if (comboBox1.GetItemText(comboBox1.SelectedItem) != "")
                    {
                        if (tbJUMLAHKAMAR.Text != "")
                        {
                            if (tbJUMLAHTAMU.Text != "")
                            {
                                MessageBox.Show
                                  ("LENGKAP!!",
                                  "Informasi Data Submit",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Size = new Size(1014, 771);
                            }
                            else
                            {
                                MessageBox.Show
                                ("Jumlah Tamu Belum Diisi!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                            ("Jumlah Kamar Belum Diisi!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                        ("Tipe Kamar Belum Diisi!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Checkout Belum Diisi!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("Checkin Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbCHECKIN_TextChanged(object sender, EventArgs e)
        {
            if (tbCHECKIN.Text == "")
            {
                epWarning.SetError(tbCHECKIN, "Textbox CHECKIN tidak boleh kosong");
                epWrong.SetError(tbCHECKIN, "");
                epCorrect.SetError(tbCHECKIN, "");
            }
            else
            {
                if (Regex.IsMatch(tbCHECKIN.Text, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    epWarning.SetError(tbCHECKIN, "");
                    epWrong.SetError(tbCHECKIN, "");
                    epCorrect.SetError(tbCHECKIN, "Betul");
                }
                else
                {
                    epWarning.SetError(tbCHECKIN, "Format CHECKIN salah!\nContoh: nn / nn / nnnn");
                    epWrong.SetError(tbCHECKIN, "");
                    epCorrect.SetError(tbCHECKIN, "");
                }
            }
        }

        private void tbCHECKOUT_TextChanged(object sender, EventArgs e)
        {
            {
                if (tbCHECKOUT.Text == "")
                {
                    epWarning.SetError(tbCHECKOUT, "Textbox CHECKOUT tidak boleh kosong");
                    epWrong.SetError(tbCHECKOUT, "");
                    epCorrect.SetError(tbCHECKOUT, "");
                }
                else
                {
                    if (Regex.IsMatch(tbCHECKOUT.Text, @"^\d{2}/\d{2}/\d{4}$"))
                    {
                        epWarning.SetError(tbCHECKOUT, "");
                        epWrong.SetError(tbCHECKOUT, "");
                        epCorrect.SetError(tbCHECKOUT, "Betul");
                    }
                    else
                    {
                        epWarning.SetError(tbCHECKOUT, "Format CHECKOUT salah!\nContoh: nn/nn/nnnn");
                        epWrong.SetError(tbCHECKOUT, "");
                        epCorrect.SetError(tbCHECKOUT, "");
                    }
                }
            }
        }
        private void Tunai_CheckedChanged_2(object sender, EventArgs e)
        {
            if (Tunai.Checked)
            {
                BRI.Enabled = false;
                BCA.Enabled = false;
                Mandiri.Enabled = false;
                OVO.Enabled = false;
                Gopay.Enabled = false;
                DANA.Enabled = false;
            }
        }

        private void Card_CheckedChanged(object sender, EventArgs e)
        {
            if (Card.Checked)
            {
                BRI.Enabled = true;
                BCA.Enabled = true;
                Mandiri.Enabled = true;
                OVO.Enabled = false;
                Gopay.Enabled = false;
                DANA.Enabled = false;
            }
        }
        private void Emoney_CheckedChanged(object sender, EventArgs e)
        {
            if (Emoney.Checked)
            {
                BRI.Enabled = false;
                BCA.Enabled = false;
                Mandiri.Enabled = false;
                OVO.Enabled = true;
                Gopay.Enabled = true;
                DANA.Enabled = true;
            }
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (tbPembayaran.Text != "")
            {

            }
            else
            {
                MessageBox.Show
                ("Pembayaran Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            {
                string MetodePembayaran = "";
                string Pembayaran = null;

                if (Tunai.Checked)
                {
                    MetodePembayaran += Tunai.Text;
                }
                if (Card.Checked)
                {
                    MetodePembayaran += Card.Text;
                }
                if (Emoney.Checked)
                {
                    MetodePembayaran += Emoney.Text;
                }


                if (MetodePembayaran == "")
                {
                    MessageBox.Show("Harus memilih salah satu dari pilihan Kurikulum", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



                if (BRI.Checked)
                {
                    Pembayaran += BRI.Text + ", ";
                }
                if (BCA.Checked)
                {
                    Pembayaran += BCA.Text + ", ";
                }
                if (Mandiri.Checked)
                {
                    Pembayaran += Mandiri.Text + ", ";
                }
                if (OVO.Checked)
                {
                    Pembayaran += OVO.Text + ", ";
                }
                if (Gopay.Checked)
                {
                    Pembayaran += Gopay.Text + ", ";
                }
                if (DANA.Checked)
                {
                    Pembayaran += DANA.Text + ", ";
                }
                

                string jk = null;
                if (Laki.Checked)
                {
                    jk = Laki.Text;
                }
                else
                {
                    jk = Perempuan.Text;
                }


                

                {
                    MessageBox.Show
                            ("NIM : " + tbNIK.Text +
                            "\nNama : " + tbNAMA.Text +
                            "\nJenis Kelamin : " + jk +
                            "\nAlamat : " + tbALAMAT.Text +
                            "\nNo HP: " + tbNOHP.Text +
                            "\nEmail : " + tbEMAIL.Text +
                            "\n------------------------------------------------" +
                            "\nCheckin: " + tbCHECKIN.Text +
                            "\nCheckout: " + tbCHECKOUT.Text +
                            "\nTipe Kamar : " + comboBox1.Text +
                            "\nJumlah Kamar: " + tbJUMLAHKAMAR.Text +
                            "\nJumlah Tamu: " + tbJUMLAHTAMU.Text +

                            "\n------------------------------------------------" +
                            "\nTotal Pembayaran: " + tbPembayaran.Text +
                            "\nMetodePembayaran: " + MetodePembayaran +
                            "\nPembayaran: " + Pembayaran,
                            


                            "Informasi Formulir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void BATAL_Click(object sender, EventArgs e)
        {
            tbNIK.Text = null;
            tbNAMA.Text = null;
            Laki.Checked = false;
            Perempuan.Checked = false;
            tbALAMAT.Text = null;
            tbNOHP.Text = null;
            tbEMAIL.Text = null;

            tbCHECKIN.Text = null;
            tbCHECKOUT.Text = null;
            comboBox1 = null;
           
            tbJUMLAHKAMAR = null;
            tbJUMLAHTAMU = null;

            tbPembayaran = null;
            tbJUMLAHTAMU = null;

            Tunai.Checked = false;
            Card.Checked = false;
            Emoney.Checked = false;

            BRI.Checked = false;
            BCA.Checked = false;
            Mandiri.Checked = false;
            OVO.Checked = false;
            Gopay.Checked = false;
            DANA.Checked = false;


            this.Size = new Size(984, 243);
        }

        
    }
}



        