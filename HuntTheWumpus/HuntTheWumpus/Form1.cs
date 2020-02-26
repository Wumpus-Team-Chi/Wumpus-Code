using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void construct_objects_Click(object sender, EventArgs e)
        {
            Cave cave = new Cave();
            GameControl game = new GameControl();
            HighScore highScore = new HighScore(0);
            Trivia trivia = new Trivia();
            UI ui = new UI();
        }
    }
}
