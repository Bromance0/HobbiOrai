using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hobbi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            betoltesButton.Click += (sender, e) => Megnyitas();
            hozzaadButton.Click += (sender, e) => UjHobbi();
            mentesButton.Click += (sender, e) => Mentes();
        }
        private void Megnyitas()
        {
            if (OpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string tartalom = File.ReadAllText(OpenFileDialog.FileName);
                string[] megnyit = tartalom.Split(new[] { "\r\n", "\r", "\n", ";" }, StringSplitOptions.None);
                nevText.Text = megnyit[0];
                szulDatum.Value = Convert.ToDateTime(megnyit[1]);
                if (megnyit[2] == "F")
                {
                    ferfiRadio.Checked = true;
                    noiRadio.Checked = false;
                }
                else
                {
                    ferfiRadio.Checked = false;
                    noiRadio.Checked = true;
                }
                if (!hobbiBox.Items.Contains(megnyit[3]))
                {
                    hobbiBox.Items.Add(megnyit[3]);

                }
                if (megnyit.Length > 4)
                {
                    hobbiBox.Items.Clear();
                    for (int i = 4; i < megnyit.Length - 1; i++)
                    {
                        hobbiBox.Items.Add(megnyit[i]);
                    }
                }
                int index = hobbiBox.FindString(megnyit[3]);
                hobbiBox.SetSelected(index, true);
            }
        }
        private void Mentes()
        {
            if (nevText.Text != "" && (ferfiRadio.Checked == true || noiRadio.Checked == true) && hobbiBox.SelectedItem != null)
            {
                string tartalom = nevText.Text + ";" + szulDatum.Value + ";";
                if (ferfiRadio.Checked == true)
                {
                    tartalom += "F;";
                }
                else
                {
                    tartalom += "N;";
                }
                tartalom += hobbiBox.SelectedItem.ToString() + Environment.NewLine;
                List<String> list = new List<String>();

                foreach (String strCol in hobbiBox.Items)
                {
                    list.Add(strCol);
                }
                foreach (string itm in list)
                {
                    if (itm != "")
                    {
                        tartalom += itm + ";";
                    }
                }
                var eredmeny = saveFileDialog.ShowDialog(this);
                if (eredmeny == DialogResult.OK)
                {
                    string fileNev = saveFileDialog.FileName;

                    File.WriteAllText(fileNev, tartalom);
                }

            }
            else
            {
                MessageBox.Show("Mindent ki kell tölteni!");
            }
        }
        private void UjHobbi()
        {
            if (!hobbiBox.Items.Contains(hobbiText.Text) && hobbiText.Text != "")
            {
                hobbiBox.Items.Add(hobbiText.Text);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
