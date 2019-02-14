using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Johnathan Meloche
 * Created on: 14/02/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 Moving Cat
 * This program changes the image to the next picture when a button is clicked
*/
namespace MovingCatJohnathanM
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void btnForwards_Click(object sender, EventArgs e)
        {
            if (picZombie.Image == Properties.Resources.zombie1)
            {
                this.picZombie.Image = Properties.Resources.zombie2;
            }
            else if (picZombie.Image == Properties.Resources.zombie2)
            {
                this.picZombie.Image = Properties.Resources.zombie3;
            }
            else if (picZombie.Image == Properties.Resources.zombie3)
            {
                this.picZombie.Image = Properties.Resources.zombie4;
            }
            else if (picZombie.Image == Properties.Resources.zombie4)
            {
                this.picZombie.Image = Properties.Resources.zombie5;
            }
            else if (picZombie.Image == Properties.Resources.zombie5)
            {
                this.picZombie.Image = Properties.Resources.zombie6;
            }
            else if (picZombie.Image == Properties.Resources.zombie6)
            {
                this.picZombie.Image = Properties.Resources.zombie7;
            }
            else if (picZombie.Image == Properties.Resources.zombie7)
            {
                this.picZombie.Image = Properties.Resources.zombie8;
            }
            else if (picZombie.Image == Properties.Resources.zombie8)
            {
                this.picZombie.Image = Properties.Resources.zombie9;
            }
            else if (picZombie.Image == Properties.Resources.zombie9)
            {
                this.picZombie.Image = Properties.Resources.zombie10;
            }
            else if (picZombie.Image == Properties.Resources.zombie10)
            {
                this.picZombie.Image = Properties.Resources.zombie1;
            }
        }

        private void picZombie_Click(object sender, EventArgs e)
        {

        }

        private void frmMovingCat_Load(object sender, EventArgs e)
        {

        }
    }
}
