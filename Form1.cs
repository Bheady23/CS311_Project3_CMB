/*This application simulates an ordering app for a fictious pizza place. 
 * @author Chris Burkhead
 * @version 1.0
 * CS311ON
 * Bellarmine University
 * Fall 2022 
 */

namespace CS311_Project3_CMB
{
    public partial class frmPizza : Form
    {
        //constructor
        public frmPizza()
        {
            InitializeComponent();
        }//end constructor

        /*
         * btnCalcu_Click() executes when the calcuate button is clicked by
         * the user. It ensures all text fields are empty and that a pizza size and 
         * crust type have been selected. If those two conditions are met, then the
         * Summarize() is called. 
         */
        private void btnCalcu_Click(object sender, EventArgs e)
        {
            //clearing text fields
            rtfOrderSummary.Clear();
            txtTotal.Clear();
            txtSub.Clear();
            txtTax.Clear();

            //if statment checks to see that a pizza size has been selected. If not a message box prompts
            //the user to select a size.
            if (cboSize.SelectedIndex == -1)
            {
                MessageBox.Show("You must pick a size");
                return;
            }//end if
            
            //if else statements ensure that a crust type has been selected, if true then Summarize() is called
            //otherwise a message box prompts the use to select a crust type
            if ((rdoThick.Checked) || (rdoRegular.Checked) || (rdoThin.Checked))
                Summarize();
            else
                MessageBox.Show("You must select a type of crust");
            
        }// end btnCalcu-Click


        /*
         * Summarize() computes the subtotal, tax and total for the pizza selected
         * and prints the results to the screen in the assigned text bozes. It also prints an order summary
         * which details all the pizza choices made by the user to an assigned rich text box.
         * The variable subtotal is initalized to 0.00 but it values increases based the choices 
         * made by the user. The variable tax is determined by multipling the 
         * state of Kentucky's sale tax of 6% or .06 by the subtotal after all 
         * selections have been made by the user. And the varibale total represents the complete total cost 
         * of the pizza after the subtotal and tax have been added together. 
         */
        private void Summarize()
        {

            //instance variables
            string size = cboSize.GetItemText(cboSize.SelectedItem);
            double subTotal = 0.00;
            double tax = 0.00;
            double total = 0.00;


            //if statements determine the size of the pizza and
            //increases the value of subTotal based the user's selection
            if (size == "Small")
                subTotal = 2.00;
            if (size == "Medium")
                subTotal = 5.00;
            if (size == "Large")
                subTotal = 10.00;
            if (size == "X-Large")
                subTotal = 15.00;
            if (size == "Ginormous")
                subTotal = 20.00;

            //if statements determines the crust type selected by the user and prints the results to the rich
            //text box rtfOrderSummary
            if (rdoThick.Checked)
                rtfOrderSummary.SelectedText = "You ordered a " + size + " pizza with Thick Crust and the following toppings: \n";
            if (rdoRegular.Checked)
                rtfOrderSummary.SelectedText = "You ordered a " + size + " pizza with Regular Crust and the following toppings: \n";
            if (rdoThin.Checked)
                rtfOrderSummary.SelectedText = "You ordered a " + size + " pizza with Thin Crust and the following toppings: \n";

            
            rtfOrderSummary.SelectionBullet = true;

            /*
             * This series of if statements checks each topping check box one at a time to see 
             * if it has been checked. If it has been checked then the topping selected is printed to 
             * rtfOrderSummary and the cost of the topping is added to the variable subTotal.   
             */
            if (ckbPep.Checked != false)
            {
                rtfOrderSummary.SelectedText = "Pepperoni\n";
                subTotal = subTotal + 2.00;
            }//end if

            if (ckbSaus.Checked)
            {
                rtfOrderSummary.SelectedText = "Sausage\n";
                subTotal = subTotal + 2.00;
            }//end if 

            if (ckbCanada.Checked)
            {
                rtfOrderSummary.SelectedText = "Canadian Bacon\n";
                subTotal = subTotal + 2.00;
            }//end if 

            if (ckbSpicySaus.Checked)
            {
                rtfOrderSummary.SelectedText = "Spicy Italian Sausage\n";
                subTotal = subTotal + 2.00;
            }//end if

            if (ckbOnion.Checked)
            {
                rtfOrderSummary.SelectedText = "Onion\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbGrnPep.Checked)
            {
                rtfOrderSummary.SelectedText = "Green Pepper\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbBlkO.Checked)
            {
                rtfOrderSummary.SelectedText = "Black Olives\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbGrnO.Checked)
            {
                rtfOrderSummary.SelectedText = "Green Olives\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbBanPep.Checked)
            {
                rtfOrderSummary.SelectedText = "Banana Peppers\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbJale.Checked)
            {
                rtfOrderSummary.SelectedText = "Jalepeno\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbExtraC.Checked)
            {
                rtfOrderSummary.SelectedText = "Extra Cheese\n";
                subTotal = subTotal + 1.00;
            }//end if

            if (ckbMush.Checked)
            {
                rtfOrderSummary.SelectedText = "Mushroom\n";
                subTotal = subTotal + 1.00;
            }//end if

            rtfOrderSummary.SelectionBullet = false;

            //final calculatons are made and printed to the assigned text boxes
            tax = subTotal * .06;
            total = subTotal + tax;
            txtSub.Text = "$" + subTotal.ToString("0.00");
            Console.WriteLine(txtSub);
            txtTax.Text = "$" + tax.ToString("0.00");
            Console.WriteLine(txtTax);
            txtTotal.Text = "$" + total.ToString("0.00");
            Console.WriteLine(txtTotal);

        }//end Summarize

    }//end class

}//end namespace
