using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2SanwichBuilder
{
    public partial class frmMain : Form
    {
         Sandwich sandwichInstance;
         Order orderClass;
         frmReceipt frmreceipt;
        public frmMain()
        {
            InitializeComponent();
           sandwichInstance = new Sandwich();
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // "var" create variables without explicitly saying what type they are.
            foreach ( var item in sandwichInstance.meatPrice)
                {
                    clbMeat.Items.Add(item.Key + " $ " + item.Value.ToString());
                    
                }
            foreach (var item in sandwichInstance.cheesePrice)
            {
                clbCheese.Items.Add(item.Key + " $ " + item.Value.ToString());

            }
            foreach (var item in sandwichInstance.toppingPrice)
            {
                clbToppings.Items.Add(item.Key + " $ " + item.Value.ToString());

            }
            foreach (var item in sandwichInstance.extraPrice)
            {
                clbExtra.Items.Add(item.Key + " $ " + item.Value.ToString());

            }
            foreach (var item in sandwichInstance.BreadPrice)
            {
                libBread.Items.Add(item.Key + " $ " + item.Value.ToString());

            }
            foreach (var item in sandwichInstance.saucePrice)
            {
                libSaues.Items.Add(item.Key + " $ " + item.Value.ToString());

            }
            foreach (var item in sandwichInstance.breadSize)
            {
                cobSandwitchSize.Items.Add(item.Key + " $ " + item.Value.ToString());

            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            orderClass = new Order();

            Customer customer = new Customer
            {
                Name = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Street = txtStreet.Text,
                City = txtCity.Text,
                State = txtState.Text,
                CustomerTip = double.Parse(txtTip.Text.ToString()),
                
            };

            if (double.TryParse(txtZipCode.Text, out double zipCode))
            {
                customer.Zipcode = zipCode;
            }
            else { MessageBox.Show("Please Enter a Valid ZipCode"); }


            if (double.TryParse(txtPhoneNumber.Text, out double phoneNumber))
            {
                customer.PhoneNumber = phoneNumber;
            }
            else { MessageBox.Show("Please Enter a Valid Phone Number"); }


            //Sending the Selected infoemantion to the frmReceipt Form. 
            frmreceipt = new frmReceipt();
            frmreceipt.txtFirstName.Text = customer.Name;
            frmreceipt.txtLastName.Text = customer.Lastname;
            frmreceipt.txtStreet.Text = customer.Street;
            frmreceipt.txtCity.Text = customer.City;
            frmreceipt.txtState.Text = customer.State;
            frmreceipt.txtPhoneNumber.Text = customer.PhoneNumber.ToString();
            frmreceipt.txtZipCode.Text = customer.Zipcode.ToString();
            frmreceipt.lblTip.Text = ("Tip : " + customer.CustomerTip.ToString());


            


            if (rdbDelivery.Checked)
            {
                frmreceipt.lblDeliveryOption.Text = ("Delivery");
            }
            else { frmreceipt.lblDeliveryOption.Text = "PickUp"; }

            frmreceipt.Show();
            this.Hide();


            //CkeckedListboc Function
            SortedList<string, double> selectedMeat = orderClass.GetCheckedListBox(clbMeat);
            SortedList<string, double> selectedCheese = orderClass.GetCheckedListBox(clbCheese);
            SortedList<string, double> selectedToppings = orderClass.GetCheckedListBox(clbToppings);
            SortedList<string, double> selectedExtra = orderClass.GetCheckedListBox(clbExtra);


            // Listbox function 
           // SortedList<string, double> selectedBread = orderClass.GetListboxItem(libBread);
            SortedList<string, double> selectedSaues = orderClass.GetListboxItem(libSaues);
            //Combobox selected Items
            SortedList<string, double> selectedBreadSize = orderClass.GetComboBoxItem(cobSandwitchSize);

            // CReate a sort ist array to store the Selected Items
            SortedList<string, double>[] selectedItems = { selectedBreadSize,selectedCheese,selectedMeat,
                                        selectedToppings,selectedExtra,selectedSaues};

            double totalOrder = 0;
            // Clear the list box before adding items

            frmreceipt.libReceipt.Items.Clear();
            foreach (var item in selectedItems)
            {
                foreach (var pair in item)
                {
                    frmreceipt.libReceipt.Items.Add($"{pair.Key}: {pair.Value}"); 

                    totalOrder += pair.Value; // the total value
                }
            }

            // Get the total value before tax
            string totalValueBeforeTax = totalOrder.ToString("F2");
            // 8% tax rate (you mentioned 0.08m, assuming it's 8%)
            decimal taxRate = 0.08m;
            // Calculate tax
            decimal taxAmount = Convert.ToDecimal(totalValueBeforeTax) * taxRate; 

            string totalTax = taxAmount.ToString("F2");
            // Calculate total after tax
            decimal totalValueAfterTax = Convert.ToDecimal(totalValueBeforeTax) + taxAmount; 

            var totalValueWithTip = Convert.ToDouble(totalValueAfterTax) + customer.CustomerTip; 

            frmreceipt.lblTax.Text = totalTax; // Set the tax amount

            frmreceipt.lblTotal.Text = totalValueWithTip.ToString("F2");

            frmreceipt.lblDateTime.Text = "Order Time : " + DateTime.Now.ToString();


        }
    }
}
