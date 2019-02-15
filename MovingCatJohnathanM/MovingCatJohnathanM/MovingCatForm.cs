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
        // global variables
        int zombieCount = 1;

        public frmMovingCat()
        {
            InitializeComponent();
        }

            
        private void btnForwards_Click(object sender, EventArgs e)
        {
            
            if (zombieCount == 1)
            {
                zombieCount = 2;

                this.picZombie.Load(@"Images\zombie2.png");

            }
            else if (zombieCount == 2)
            {
                zombieCount = 3;

                this.picZombie.Load(@"Images\zombie3.png");
            }
            else if (zombieCount == 3)
            {
                zombieCount = 4;

                this.picZombie.Load(@"Images\zombie4.png");
            }
            else if (zombieCount == 4)
            {
                zombieCount = 5;

                this.picZombie.Load(@"Images\zombie5.png");
            }
            else if (zombieCount == 5)
            {
                zombieCount = 6;

                this.picZombie.Load(@"Images\zombie6.png");
            }
            else if (zombieCount == 6)
            {
                zombieCount = 7;

                this.picZombie.Load(@"Images\zombie7.png");
            }
            else if (zombieCount == 7)
            {
                zombieCount = 8;

                this.picZombie.Load(@"Images\zombie8.png");
            }
            else if (zombieCount == 8)
            {
                zombieCount = 9;

                this.picZombie.Load(@"Images\zombie9.png");
            }
            else if (zombieCount == 9)
            {
                zombieCount = 10;

                this.picZombie.Load(@"Images\zombie10.png");
            }
            else if (zombieCount == 10)
            {
                zombieCount = 1;

                this.picZombie.Load(@"Images\zombie1.png");
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
