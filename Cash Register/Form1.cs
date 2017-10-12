//Cash Register Project, Max Senez, October.11.2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class cashForm : Form
    {
        //Global Constants
        const double BACONATOR = 6.99;
        const double DOUBLE_CHEESE = 4.99;
        const double BIG_MAC = 9.99;
        const double TAX_RATE = 0.13;

        //Global Variables
        int baconAmmount;
        int cheeseAmmount;
        int macAmmount;
        double subTotal;
        double tax;
        double total;
        double tenderedAmmount;
        double change;

        public cashForm()
        {
            InitializeComponent();


        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //typing sound
            SoundPlayer typing = new SoundPlayer(Properties.Resources.typing_sound);
            typing.Play();


            //Ammount inputs
            try
            {
                baconAmmount = Convert.ToInt16(baconBox.Text);
                baconLabel.ForeColor = Color.Black;
            }
             catch
            {
                baconLabel.ForeColor = Color.Red;
                baconAmmount = 0;
            }
            try
            {
                cheeseAmmount = Convert.ToInt16(cheeseBox.Text);
                cheeseLabel.ForeColor = Color.Black;
            }
            catch
            {
                cheeseAmmount = 0;
                cheeseLabel.ForeColor = Color.Red;
            }
            try
            {
                macAmmount = Convert.ToInt16(macBox.Text);
                macLabel.ForeColor = Color.Black;
            }
            catch
            {
                macAmmount = 0;
                macLabel.ForeColor = Color.Red;
            }

            //Calculations for total sub total tax
            subTotal = BACONATOR * baconAmmount + DOUBLE_CHEESE * cheeseAmmount + BIG_MAC * macAmmount;
            tax = subTotal * TAX_RATE;
            total = subTotal + tax;

            subAmmountLabel.Text = subTotal.ToString("C");
            
            taxAmmountLabel.Text = tax.ToString("C");
            
            totalAmmountLabel.Text = total.ToString("C");
            

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Cha ching sound
            SoundPlayer cash = new SoundPlayer(Properties.Resources.cha_ching);
            cash.Play();

            //Input tendered, calculate change
            try
            {
                tenderedAmmount = Convert.ToInt16(tenderedBox.Text);
                change = tenderedAmmount - total;
                changeAmmountLabel.Text = change.ToString("C");
                tenderedLabel.ForeColor = Color.Black;
            }
            catch
            {
                tenderedAmmount = 0;
                tenderedLabel.ForeColor = Color.Red;
            }
                              
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //Printing Sound
            SoundPlayer printing = new SoundPlayer(Properties.Resources.printing);
            printing.Play();

            //Print Receipt
            Graphics formGraphics = this.CreateGraphics();

            Pen outline = new Pen(Color.DarkGray, 1);
            SolidBrush paper = new SolidBrush(Color.White);
            Font header = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Font text = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
            SolidBrush font = new SolidBrush(Color.Black);

            formGraphics.DrawRectangle(outline, 253, 32, 168, 235);
            formGraphics.FillRectangle(paper, 253, 32, 168, 235);

            formGraphics.DrawString("Burger Joint int.", header, font, 295, 52);
            formGraphics.DrawString("Order Number 4209", text, font, 273, 72);
            formGraphics.DrawString("April, 20, 2019", text, font, 273, 82);
            formGraphics.DrawString("Baconator           x" + baconAmmount + " @ " + BACONATOR.ToString("C"), text, font, 273, 102);
            formGraphics.DrawString("Double Cheese  x" + cheeseAmmount + " @ " + DOUBLE_CHEESE.ToString("C"), text, font, 273, 112);
            formGraphics.DrawString("Big Mac               x" + macAmmount + " @ " + BIG_MAC.ToString("C"), text, font, 273, 122);
            formGraphics.DrawString("Sub Total                      " + subTotal.ToString("C"), text, font, 273, 142);
            formGraphics.DrawString("Tax                                " + tax.ToString("C"), text, font, 273, 152);
            formGraphics.DrawString("Total                              " + total.ToString("C"), text, font, 273, 162);
            formGraphics.DrawString("Tendered                      " + tenderedAmmount.ToString("C"), text, font, 273, 182);
            formGraphics.DrawString("Change                         " + change.ToString("C"), text, font, 273, 192);
            formGraphics.DrawString("Enjoy your burgers! :)", text, font, 273, 232);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Crumple Sound
            SoundPlayer crumple = new SoundPlayer(Properties.Resources.Windows_Recycle);
            crumple.Play();

            //Clear All
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.WhiteSmoke);

            baconBox.Clear();
            cheeseBox.Clear();
            macBox.Clear();
            tenderedBox.Clear();
            
            subAmmountLabel.Text = " ";
            taxAmmountLabel.Text = " ";
            totalAmmountLabel.Text = " ";
            changeAmmountLabel.Text = " ";
            
            subTotal = 0;
            tax = 0;
            total = 0;
            change = 0;

            baconLabel.ForeColor = Color.Black;
            cheeseLabel.ForeColor = Color.Black;
            macLabel.ForeColor = Color.Black;
            tenderedLabel.ForeColor = Color.Black;


        }

    }
}
