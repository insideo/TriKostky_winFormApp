using System.Resources;

namespace TriKostky_winFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Zaloz objekt typu kostka s poctem 3 kostky
            
            InitializeComponent();
        }

        private void butThrowDice_Click(object sender, EventArgs e)
        {
            //int[] hodValues =  mojeKostka.HodKostky(); zavolej metodu hodKostky 
            int throwValue = 1;
            switch (throwValue)
            {
                case 1:
                    this.pictureBox1.Image = Properties.Resources.d1;  //@"\Resources\d" + pokus + ".png";
                    break;
                case 2:
                    this.pictureBox1.Image = Properties.Resources.d2;  //@"\Resources\d" + pokus + ".png";
                    break;
                case 3:
                    this.pictureBox1.Image = Properties.Resources.d3;  //@"\Resources\d" + pokus + ".png";
                    break;
                    //Dodelej ostatni cases a take default
            }
        }
    }
}
