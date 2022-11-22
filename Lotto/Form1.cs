namespace Lotto
{
    public partial class LottoForm : Form
    {
        string[] oikeat = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        int laskuri1, laskuri2, laskuri3, laskuri4, laskuri5 = 0;
        public LottoForm()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            

            

            


            //rivi1 tarkistus
            if (r1c1.Text == oikeat[0])
            {
                laskuri1++;
            }
            if (r1c2.Text == oikeat[1])
            {
                laskuri1++;
            }
            if (r1c3.Text == oikeat[2])
            {
                laskuri1++;
            }
            if (r1c4.Text == oikeat[3])
            {
                laskuri1++;
            }
            if (r1c5.Text == oikeat[4])
            {
                laskuri1++;
            }
            if (r1c6.Text == oikeat[5])
            {
                laskuri1++;
            }
            if (r1c7.Text == oikeat[6])
            {
                laskuri1++;
            }

            //rivi2 tarkistus
            if (r2c1.Text == oikeat[0])
            {
                laskuri2++;
            }
            if (r2c2.Text == oikeat[1])
            {
                laskuri2++;
            }
            if (r2c3.Text == oikeat[2])
            {
                laskuri2++;
            }
            if (r2c4.Text == oikeat[3])
            {
                laskuri2++;
            }
            if (r2c5.Text == oikeat[4])
            {
                laskuri2++;
            }
            if (r2c6.Text == oikeat[5])
            {
                laskuri2++;
            }
            if (r2c7.Text == oikeat[6])
            {
                laskuri2++;
            }

            //rivi3 tarkistus
            if (r3c1.Text == oikeat[0])
            {
                laskuri3++;
            }
            if (r3c2.Text == oikeat[1])
            {
                laskuri3++;
            }
            if (r3c3.Text == oikeat[2])
            {
                laskuri3++;
            }
            if (r3c4.Text == oikeat[3])
            {
                laskuri3++;
            }
            if (r3c5.Text == oikeat[4])
            {
                laskuri3++;
            }
            if (r3c6.Text == oikeat[5])
            {
                laskuri3++;
            }
            if (r3c7.Text == oikeat[6])
            {
                laskuri3++;
            }

            //rivi4 tarkistus
            if (r4c1.Text == oikeat[0])
            {
                laskuri4++;
            }
            if (r4c2.Text == oikeat[1])
            {
                laskuri4++;
            }
            if (r4c3.Text == oikeat[2])
            {
                laskuri4++;
            }
            if (r4c4.Text == oikeat[3])
            {
                laskuri4++;
            }
            if (r4c5.Text == oikeat[4])
            {
                laskuri4++;
            }
            if (r4c6.Text == oikeat[5])
            {
                laskuri4++;
            }
            if (r4c7.Text == oikeat[6])
            {
                laskuri4++;
            }

            //rivi5 tarkistus
            if (r5c1.Text == oikeat[0])
            {
                laskuri5++;
            }
            if (r5c2.Text == oikeat[1])
            {
                laskuri5++;
            }
            if (r5c3.Text == oikeat[2])
            {
                laskuri5++;
            }
            if (r5c4.Text == oikeat[3])
            {
                laskuri5++;
            }
            if (r5c5.Text == oikeat[4])
            {
                laskuri5++;
            }
            if (r5c6.Text == oikeat[5])
            {
                laskuri5++;
            }
            if (r5c7.Text == oikeat[6])
            {
                laskuri5++;
            }

            //tulokset
            string[] temp_str = new string[] { r1c1.Text, r1c2.Text, r1c3.Text, r1c4.Text, r1c5.Text, r1c6.Text, r1c7.Text };
            int[] num = Array.ConvertAll(temp_str, s => int.Parse(s));

            int loop;
            for (loop = 0; loop < 7; loop++) {
                if (num[loop] <= 0 || num[loop] >= 40)
                {
                    tulosLB.Text = "Joku numero ei ole 0-40 välillä.";
                } }
            if (laskuri1 >= 3 || laskuri2 >= 3 || laskuri3 >= 3 || laskuri4 >= 3 || laskuri5 >= 3)
            {
                tulosLB.Text = "Voitit 10 euroa! Onnea!";
            }
            else
            {
                tulosLB.Text = "Ei voittoa tällä kertaa :(";
            }

            tulos1LB.Text = laskuri1 + " oikein";
            tulos1LB.Visible = true;

            tulos2LB.Text = laskuri2 + " oikein";
            tulos2LB.Visible = true;

            tulos3LB.Text = laskuri3 + " oikein";
            tulos3LB.Visible = true;

            tulos4LB.Text = laskuri4 + " oikein";
            tulos4LB.Visible = true;

            tulos5LB.Text = laskuri5 + " oikein";
            tulos5LB.Visible = true;

            tulosLB.Visible = true;
        }
    }
}