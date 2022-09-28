using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsForms_TARpv21
{
public class OmaVorm : Form

    {
        public RadioButton laul1, laul2;
        public Button nupp;
        public Label failinimi;
        public OmaVorm() { }
        
        //private string v1;
        //private string v2;
        //private string v3;

        public OmaVorm(string Peakiri, string Nupp, string Fail)
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = Peakiri;
            nupp = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.AliceBlue,

            };
            nupp.Click += Nupp_Click;

            failinimi = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(50, 100),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.AliceBlue,
            };

            laul1 = new RadioButton
            {
                Text = "Laul 1",
                Location = new System.Drawing.Point(50, 150),
                Size = new System.Drawing.Size(100, 25),
                BackColor = System.Drawing.Color.AliceBlue,
            };


            laul2 = new RadioButton
            {
                Text = "Laul 2",
                Location = new System.Drawing.Point(50, 175),
                Size = new System.Drawing.Size(100, 20),
                BackColor = System.Drawing.Color.AliceBlue,
            };
            this.Controls.Add(nupp);
            this.Controls.Add(failinimi);
            this.Controls.Add(laul1);
            this.Controls.Add(laul2);
        }

        /*public OmaVorm(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }*/

        private void Nupp_Click(object sender, EventArgs e)
        {
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                if (laul1.Checked == true)

                {
                    failinimi.Text = "Laul 1";
                    using (var muusika = new SoundPlayer(@"..\..\music.wav"))
                    {
                        MessageBox.Show("Mängib muusika");
                        muusika.Play();
                    }


                    laul1.Checked = false;
                }

                else if (laul2.Checked == true)
                {
                    failinimi.Text = "Laul 2";
                    using (var muusika = new SoundPlayer(@"..\..\music.wav"))
                    {
                        MessageBox.Show("Mängib muusika");
                        muusika.Play();
                    }
                    laul2.Checked = false;
                }

                else
                {
                    MessageBox.Show("Mitte midagi ei ole valitud");
                }
            }
            else
            {

                MessageBox.Show(":(");


            }


        }

    }
}





