using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Montoya
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
            InitializematerialComboBox();
        }

        private void InitializematerialComboBox()
        {
            materialComboBox.Items.AddRange(Enum.GetNames(typeof(DesktopMaterial)));
        }

        private void CloseAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

       private void widthTextBox_Validating(object sender,  CancelEventArgs e)
        {
            int widthNumber = 0;
            if (!int.TryParse(widthTextBox.Text, out widthNumber))
            {
                widthErrorProvider.SetError(widthTextBox, "Width must be an integer");
                return;
            }
            else if (widthNumber >= Desk.MAXWIDTH)
            {
                widthErrorProvider.SetError(widthTextBox, "Width must be lesser than 96 inches");
                return;
            }
            else if (widthNumber <= Desk.MINWIDTH)
            {
                widthErrorProvider.SetError(widthTextBox, "Width must be greater than 24 inches");
                return;
            }
            else
                widthErrorProvider.SetError(widthTextBox, string.Empty);
        }

        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                depthErrorProvider.SetError(depthTextBox, "Depth must be an integer");
                return;
            }
            else
                depthErrorProvider.SetError(depthTextBox, string.Empty);
        }
        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            int depthNumber = 0;
            try
            {
                depthNumber = Int32.Parse(depthTextBox.Text);
            }
            catch (Exception ex)
            {
                depthErrorProvider.SetError(depthTextBox, ex.Message);

            }
            if (depthNumber >= Desk.MAXDEPTH)
                {
                    depthErrorProvider.SetError(depthTextBox, "Depth must be lesser than 48 inches");
                    return;
                }
                else if (depthNumber <= Desk.MINDEPTH)
                {
                    depthErrorProvider.SetError(depthTextBox, "Depth must be greater than 12 inches");
                    return;
                }
        }
        public static Desk desk = new Desk();
        public static DeskQuote deskQuote = new DeskQuote();

        public void SubmitQuote_Click(object sender, EventArgs e)
        {

            deskQuote.Name = nameTextBox.Text;
            deskQuote.Date = DateTime.Now.ToString("dd MMMM yyyy");
            desk.Width = Int32.Parse(widthTextBox.Text);
            desk.Depth = Int32.Parse(depthTextBox.Text);
            int size = desk.Width * desk.Depth;
            desk.Drawers = Int32.Parse(drawersTextBox.Text);
            DesktopMaterial material = (DesktopMaterial)materialComboBox.SelectedIndex;
            deskQuote.RushDays = rushOrderComboBox.SelectedIndex;
            int sizeCost = 0;
            if (size > 1000)
                sizeCost = size - 1000;
            int drawersCost = desk.Drawers * 50;
            int materialCost = 0;
            int rushDaysCost = 0;
            int total = 0;

            DisplayQuote display = new DisplayQuote();
            display.nameLabel.Text = deskQuote.Name;
            display.dateLabel.Text = deskQuote.Date;
            display.sizeLabel.Text = size.ToString();
            display.drawersLabel.Text = desk.Drawers.ToString();
            display.materialLabel.Text = material.ToString();
            switch(deskQuote.RushDays)
            {
                case 0:
                display.rushOrderLabel.Text = "3 days";
                break;
                case 1:
                display.rushOrderLabel.Text = "5 days";
                break;
                case 2:
                display.rushOrderLabel.Text = "7 days";
                break;
            }
            display.baseDeskCostLabel.Text = ("$"+Desk.BASEPRICE.ToString());
            display.sizeCostLabel.Text = ("$"+sizeCost.ToString());
            display.drawersCostLabel.Text = ("$"+drawersCost.ToString());
            switch (material)
            {
                case DesktopMaterial.Oak:
                    materialCost = 200;
                    display.materialCostLabel.Text = ("$200");
                    break;
                case DesktopMaterial.Laminate:
                    materialCost = 100;
                    display.materialCostLabel.Text = ("$100");
                    break;
                case DesktopMaterial.Pine:
                    materialCost = 50;
                    display.materialCostLabel.Text = ("$50");
                    break;
                case DesktopMaterial.Rosewood:
                    materialCost = 300;
                    display.materialCostLabel.Text = ("$300");
                    break;
                case DesktopMaterial.Veneer:
                    materialCost = 125;
                    display.materialCostLabel.Text = ("$125");
                    break;
            }
            switch(deskQuote.RushDays)
            {
                case 0:
                    if (size < 1000)
                    {
                        rushDaysCost = 60;
                        display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                    }
                    else if (size >= 1000 && size <= 2000)
                    { 
                        rushDaysCost = 70;
                        display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                    }
                    else
                    {
                        rushDaysCost = 80;
                        display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                    }
                break;
                case 1:
                if (size < 1000)
                {
                    rushDaysCost = 40;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                }
                if (size >= 1000 && size <= 2000)
                {
                    rushDaysCost = 50;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                }
                if (size >= 2000)
                {
                    rushDaysCost = 60;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                }
                break;
                case 2:
                if (size < 1000)
                {
                    rushDaysCost = 30;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
            
                }
                if (size >= 1000 && size <= 2000)
                {
                    rushDaysCost = 35;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                    
                }
                if (size >= 2000)
                {
                    rushDaysCost = 40;
                    display.rushOrderCostLabel.Text = ("$" + rushDaysCost.ToString());
                }
                break;
            }
            
            total = Desk.BASEPRICE + sizeCost + drawersCost + materialCost + rushDaysCost;
            display.totalLabel.Text = ("$"+total.ToString());
            display.Show();
        }
    }
}
