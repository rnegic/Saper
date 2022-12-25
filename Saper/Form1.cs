using System.Windows.Forms;

namespace Saper
{
    public partial class Saper : Form
    {
        Random rnd = new Random();
        int score = 0;
        int scoreTemp = 0;
        public Saper()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int mine1 = rnd.Next(1,19);
            int mine2 = rnd.Next(20,39);
            int mine3 = rnd.Next(40,59);
            int mine4 = rnd.Next(60,79);
            int mine5 = rnd.Next(79,100);
            for (int i = 0; i < 100; i++)
            {
                Button buttonCell = new Button();
                buttonCell.Tag = i;
                buttonCell.Size = new System.Drawing.Size(65, 65);
                if(i == mine1 || i == mine2 || i == mine3 || i == mine4 || i == mine5)
                {
                    buttonCell.Tag = true;
                }
                else
                {
                    buttonCell.Tag = false;
                }

                buttonCell.Click += buttonCell_Click;
                FlowLayoutPanel.Controls.Add(buttonCell);
                //зарпет нажимать еще раз 
                buttonStart.Enabled = false;
            }
        }
        private void buttonCell_Click(object sender, EventArgs e)
        {
            Button buttonCell = (Button)sender;
            bool isMine = (bool)buttonCell.Tag;

            if(isMine)
            {
                buttonCell.Enabled = false;
                buttonCell.BackColor = Color.IndianRed;
                score = 0;
                labelScore.Text = score.ToString();

                DialogResult dialogGameOver = MessageBox.Show("Вас счет: "+scoreTemp+"\n"+"Хотите начать игру заново?", "Вы проиграли", MessageBoxButtons.YesNo);
                if (dialogGameOver == DialogResult.Yes)
                {
                    //начать игру заново
                }
                else if (dialogGameOver == DialogResult.No)
                {
                    Close();
                    //выйти из игры вообще
                }

            }
            else
            {
                buttonCell.Enabled = false;
                buttonCell.BackColor = Color.GreenYellow;
                score++;
                scoreTemp = score;
                labelScore.Text = score.ToString();
                if (score == 95)
                {
                    DialogResult dialogGameOver = MessageBox.Show("Вы набрали максимум очков. Вас счет: " + scoreTemp + "\n" + "Хотите начать игру заново?", "УРА!!ВЫ ВЫИГРАЛИ", MessageBoxButtons.YesNo);
                    if (dialogGameOver == DialogResult.Yes)
                    {

                        //начать игру заново
                    }
                    else if (dialogGameOver == DialogResult.No)
                    {
                        Close();
                        //выйти из игры вообще
                    }
                }

            }
         }

    }
}