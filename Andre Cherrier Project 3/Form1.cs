/* Project Name: Technology Store form
 * Description: Purchase phones, computers, and televisions.
 * Author: Andre Cherrier
 * Date: October 20, 2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andre_Cherrier_Project_3
{
    public partial class technologyStoreForm : Form
    {

        //declaring arrays for phone names, descriptions, and prices
        string[] phones = { "iPhone 8 Plus", "Samsung Galaxy Note8" };
        string[] phoneDescription = { "64GB", "64GB" };
        double[] phonePrice = { 899.99, 929.99 };

        //declaring arrays for computer names, descriptions, and prices
        string[] computers = { "Alienware - 17.3in. Laptop", "Asus - ROG G752VS 17.3in. Laptop", "Apple -  MacBook Pro® - 15in. Display" };
        string[] computerDescription = { "Intel Core i7 - 16GB Memory - NVIDIA GeForce GTX 1070 - 1TB Hard Drive + 128GB Solid State Drive", "Intel Core i7 - 16GB Memory - NVIDIA GeForce GTX 1070 - 512GB Solid State Drive + 1TB HDD", "Intel Core i7 - 16 GB Memory - 256GB Flash Storage" };
        double[] computerPrice = { 1849.99, 2249.99, 2249.99 };

        //declaring variables for television names, descriptions, and prices
        string[] televisions = { "Sony - 75 in. Class", "Samsung - 75 in. Class", "Samsung - 82 in. Class", "Samsung QN88Q9FAMFXZA" };
        string[] televisionDescription = { "(74.5 in. Diag.) - LED - 2160p - Smart - 4K Ultra HD TV with High Dynamic Range", "(74.5 in. Diag.) - LED - 2160p - Smart - 4K Ultra HD TV with High Dynamic Range", "(82 in. Diag.) - LED - 2160p - Smart - 4K Ultra HD TV with High Dynamic Range", "88-Inch 4K Ultra HD QLED Smart TV with HDR Elite (2017)" };
        double[] televisionPrice = { 2499.99, 2499.99, 3799.99, 19997.99 };

        const double couponDiscount = .9;
        const double tax = 1.08;
        public technologyStoreForm()
        {
            InitializeComponent();
            //adding phone names and prices to corresponding list
            for (int i = 0; i < phones.Length; i++)
            {
                phoneListBox.Items.Add(string.Format("{0, -40} {1, 10}", phones[i], (phonePrice[i].ToString("c"))));
            }
            //adding computer names and prices to corresponding listbox
            for (int i = 0; i < computers.Length; i++)
            {
                computerListBox.Items.Add(string.Format("{0, -40} {1, 10}", computers[i], (computerPrice[i].ToString("c"))));
            }

            //adding television names and prices to corresponding listbox
            for (int i = 0; i < televisions.Length; i++)
            {
                televisionListBox.Items.Add(string.Format("{0, -40} {1, 10}", televisions[i], (televisionPrice[i].ToString("c"))));
            }

            //cleaning up subTotalCartGridView and setting the value of quantity column and price column to be able to transfer them to the subTotalDataGridView
            subTotalCartGridView.RowHeadersVisible = false;
            subTotalCartGridView.Columns[2].CellTemplate.ValueType = typeof(int);
            subTotalCartGridView.Columns[1].CellTemplate.ValueType = typeof(double);

            //assigning subTotalDataGridView an object to be later filled with data
            subTotalDataGridView.Rows.Add(new object[] { "", "", "" });

            //cleaning up subTotalGridView to dispense of the selected property
            subTotalDataGridView.Enabled = false;
            subTotalDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            subTotalDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            //cleaning up totalCartGridView to allow data to be more easily transferred
            totalCartGridView.RowHeadersVisible = false;
            totalCartGridView.Columns[2].CellTemplate.ValueType = typeof(int);
            totalCartGridView.Columns[1].CellTemplate.ValueType = typeof(double);

            //cleaning up totalGridView and adding an object to later be filled with data
            totalGridView.RowHeadersVisible = false;
            totalGridView.Enabled = false;
            totalGridView.Rows.Add(new object[] { "", "", "" });
            totalGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            totalGridView.DefaultCellStyle.SelectionForeColor = Color.Black;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //button to close the form
            this.Close();
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //setting the phoneCheckBox to show/unshow phone products when checked/unchecked
            if (phoneGroupBox.Visible == false)
            {
                phoneGroupBox.Visible = true;
            }
            else
            {
                phoneGroupBox.Visible = false;
            }
        }

        private void computerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //setting the computerCheckBox to show/unshow computer products when checked/unchecked
            if (computerGroupBox.Visible == false)
            {
                computerGroupBox.Visible = true;
            }
            else
            {
                computerGroupBox.Visible = false;
            }
        }

        private void televisionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //setting the televisionCheckBox to show/unshow television products when checked/unchecked
            if (televisionGroupBox.Visible == false)
            {
                televisionGroupBox.Visible = true;
            }
            else
            {
                televisionGroupBox.Visible = false;
            }
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unsubscribing and resubscribing to the event computerListBox_SelectedIndexChanged so they will deselect when a phone item is selected
            computerListBox.SelectedIndexChanged -= new System.EventHandler(this.computerListBox_SelectedIndexChanged);
            computerListBox.SelectedIndex = -1;
            computerListBox.SelectedIndexChanged += new System.EventHandler(this.computerListBox_SelectedIndexChanged);

            //unsubscribing and resubscribing to the event televisionListBox_SelectedIndexChanged so they will deselect when a phone item is selected
            televisionListBox.SelectedIndexChanged -= new System.EventHandler(this.televisionListBox_SelectedIndexChanged);
            televisionListBox.SelectedIndex = -1;
            televisionListBox.SelectedIndexChanged += new System.EventHandler(this.televisionListBox_SelectedIndexChanged);

            //putting item description in description box when selected
            if (phoneListBox.SelectedIndex != -1)
            {
                itemDescriptionTextBox.Visible = true;
                descriptionLabel.Visible = true;
                itemDescriptionTextBox.Text = (phoneDescription[phoneListBox.SelectedIndex]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clearing values when button is clicked
            phoneListBox.ClearSelected();
            computerListBox.ClearSelected();
            televisionListBox.ClearSelected();
            quantityTextBox.Text = "";
            subTotalCartGridView.Rows.Clear();
            itemDescriptionTextBox.Clear();
            couponTextBox.Clear();
            subTotalDataGridView.Rows[0].Cells[1].Value = 0;
            subTotalDataGridView.Rows[0].Cells[2].Value = 0;
            subTotalDataGridView.Visible = false;
            subTotalPrice = 0;
            subTotalQuantity = 0;
            removeItemButton.Visible = true;
            couponButton.Enabled = true;
            finalizeButton.Enabled = true;
            totalCartGridView.Rows.Clear();
            totalGridView.Rows[0].Cells[1].Value = 0;
            totalGridView.Rows[0].Cells[2].Value = 0;
            removeItemButton.Enabled = true;
            addToCartButton.Enabled = true;
            quantityTextBox.Enabled = true;
            totalGridView.Visible = false;
            totalCartGridView.Visible = false;
        }

        private void editorButton_Click(object sender, EventArgs e)
        {
            //opening a new form for management to edit products
            Form editor = new Form();
            editor.Show();
        }

        private void computerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unsubscribing and resubscribing to the event phoneListBox_SelectedIndexChanged so they will deselect when a computer item is selected
            phoneListBox.SelectedIndexChanged -= new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            phoneListBox.SelectedIndex = -1;
            phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);

            //unsubscribing and resubscribing to the event televisionListBox_SelectedIndexChanged so they will deselect when a computer item is selected
            televisionListBox.SelectedIndexChanged -= new System.EventHandler(this.televisionListBox_SelectedIndexChanged);
            televisionListBox.SelectedIndex = -1;
            televisionListBox.SelectedIndexChanged += new System.EventHandler(this.televisionListBox_SelectedIndexChanged);

            //putting item description in description box when selected
            if (computerListBox.SelectedIndex != -1)
            {
                itemDescriptionTextBox.Visible = true;
                descriptionLabel.Visible = true;
                itemDescriptionTextBox.Text = (computerDescription[computerListBox.SelectedIndex]);
            }
        }



        private void televisionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unsubscribing and resubscribing to the event phoneListBox_SelectedIndexChanged so they will deselect when a television item is selected
            phoneListBox.SelectedIndexChanged -= new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            phoneListBox.SelectedIndex = -1;
            phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);

            //unsubscribing and resubscribing to the event computerListBox_SelectedIndexChanged so they will deselect when a television item is selected
            computerListBox.SelectedIndexChanged -= new System.EventHandler(this.computerListBox_SelectedIndexChanged);
            computerListBox.SelectedIndex = -1;
            computerListBox.SelectedIndexChanged += new System.EventHandler(this.computerListBox_SelectedIndexChanged);

            //putting item description in description box when selected
            if (televisionListBox.SelectedIndex != -1)
            {
                itemDescriptionTextBox.Visible = true;
                descriptionLabel.Visible = true;
                itemDescriptionTextBox.Text = (televisionDescription[televisionListBox.SelectedIndex]);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void itemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        int subTotalQuantity;
        double subTotalPrice;
        int quantity;
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled == true)
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { phones[phoneListBox.SelectedIndex], int.Parse(quantityTextBox.Text), (phonePrice[phoneListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)).ToString("c"), phoneDescription[phoneListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else if (computerListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled == true)
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { computers[computerListBox.SelectedIndex], int.Parse(quantityTextBox.Text), (computerPrice[computerListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)).ToString("c"), computerDescription[computerListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else if (televisionListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled == true)
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { televisions[televisionListBox.SelectedIndex], int.Parse(quantityTextBox.Text), (televisionPrice[televisionListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)).ToString("c"), televisionDescription[televisionListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else if (phoneListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled != true && couponTextBox.Text.ToUpper() == "SALE10")
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { phones[phoneListBox.SelectedIndex], int.Parse(quantityTextBox.Text), ((phonePrice[phoneListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)) * couponDiscount).ToString("c"), phoneDescription[phoneListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else if (computerListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled != true && couponTextBox.Text.ToUpper() == "SALE10")
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { computers[computerListBox.SelectedIndex], int.Parse(quantityTextBox.Text), ((computerPrice[computerListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)) * couponDiscount).ToString("c"), computerDescription[computerListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else if (televisionListBox.SelectedIndex != -1 && int.Parse(quantityTextBox.Text) < 9999 && couponButton.Enabled != true && couponTextBox.Text.ToUpper() == "SALE10")
                {
                    cartLabel.Visible = true;
                    subTotalCartGridView.Visible = true;
                    subTotalDataGridView.Visible = true;
                    removeItemButton.Visible = true;
                    subTotalCartGridView.Rows.Add(new object[] { televisions[televisionListBox.SelectedIndex], int.Parse(quantityTextBox.Text), ((televisionPrice[televisionListBox.SelectedIndex] * double.Parse(quantityTextBox.Text)) * couponDiscount).ToString("c"), televisionDescription[televisionListBox.SelectedIndex] });
                    subTotalDataGridView.Rows[0].Cells[0].Value = "Subtotal :";
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;

                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    }
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                    subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    subTotalDataGridView.Columns[2].MinimumWidth = subTotalCartGridView.Columns[2].Width;
                    subTotalDataGridView.Width = subTotalCartGridView.Columns[0].Width + subTotalCartGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                }
                else
                {
                    MessageBox.Show("Please choose an item.");
                }
            }
            catch
            {
                MessageBox.Show("Please select a valid quantity.");
            }
        }

        private void subTotalCartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void couponLabel_Click(object sender, EventArgs e)
        {

        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (subTotalCartGridView.Rows.Count > 1)
                {
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalQuantity = subTotalQuantity + int.Parse(subTotalCartGridView.Rows[i].Cells[1].Value.ToString());
                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    }
                    subTotalQuantity = subTotalQuantity - int.Parse(subTotalCartGridView.SelectedRows[0].Cells[1].Value.ToString());
                    subTotalDataGridView.Rows[0].Cells[1].Value = subTotalQuantity;
                    subTotalQuantity = 0;
                    subTotalPrice = subTotalPrice - (double.Parse(subTotalCartGridView.SelectedRows[0].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                    subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                    subTotalPrice = 0;
                    subTotalCartGridView.Rows.RemoveAt(subTotalCartGridView.SelectedRows[0].Index);
                }
                else
                {
                    subTotalCartGridView.Rows.RemoveAt(subTotalCartGridView.SelectedRows[0].Index);
                    subTotalDataGridView.Visible = false;
                    subTotalQuantity = 0;
                    subTotalPrice = 0;
                }
            }
            catch
            {
                MessageBox.Show("You must first add a product to your cart.");
            }
            subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
            subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
            subTotalDataGridView.Columns[2].Width = subTotalCartGridView.Columns[2].Width;
            subTotalDataGridView.Width = subTotalDataGridView.Columns[0].Width + subTotalDataGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
        }

        private void couponButton_Click(object sender, EventArgs e)
        {
            if (couponTextBox.Text.ToUpper() == "SALE10")
            {
                MessageBox.Show("Thank you for entering a coupon!" + "\n" + "Enjoy 10% off!");
                if (subTotalCartGridView.Rows.Count != 0)
                {
                    couponButton.Enabled = false;
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        subTotalCartGridView.Rows[i].Cells[2].Value = (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency) * couponDiscount).ToString("c");
                        subTotalPrice = subTotalPrice + (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency));
                        subTotalDataGridView.Rows[0].Cells[2].Value = subTotalPrice.ToString("c");
                        subTotalDataGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                        subTotalDataGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                        subTotalDataGridView.Columns[2].Width = subTotalCartGridView.Columns[2].Width;
                        subTotalDataGridView.Width = subTotalDataGridView.Columns[0].Width + subTotalDataGridView.Columns[1].Width + subTotalDataGridView.Columns[2].Width + 3;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid coupon.");
            }
            subTotalQuantity = 0;
            subTotalPrice = 0;
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
                if (subTotalDataGridView.Visible == true && subTotalCartGridView.Rows.Count != 0)
                {
                    subTotalCartGridView.Enabled = false;
                    addToCartButton.Enabled = false;
                    removeItemButton.Enabled = false;
                    finalizeButton.Enabled = false;
                    quantityTextBox.Enabled = false;
                    totalGridView.Visible = true;
                    totalCartGridView.Visible = true;
                    totalGridView.ColumnHeadersVisible = false;
                    totalGridView.Rows[0].Cells[0].Value = "Total :";
                    totalCartGridView.Columns[0].Width = subTotalCartGridView.Columns[0].Width;
                    totalCartGridView.Columns[1].Width = subTotalCartGridView.Columns[1].Width;
                    totalCartGridView.Columns[2].Width = subTotalCartGridView.Columns[2].Width;
                    totalCartGridView.Columns[3].Width = subTotalCartGridView.Columns[3].Width;
                    subTotalDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                    subTotalDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                    totalGridView.Columns[0].Width = totalCartGridView.Columns[0].Width;
                    totalGridView.Columns[1].Width = totalCartGridView.Columns[1].Width;
                    totalGridView.Columns[2].Width = totalCartGridView.Columns[2].Width;
                    totalGridView.Width = totalGridView.Columns[0].Width + totalGridView.Columns[1].Width + totalGridView.Columns[2].Width + 3;
                    totalGridView.Rows[0].Cells[1].Value = subTotalDataGridView.Rows[0].Cells[1].Value;
                    totalGridView.Rows[0].Cells[2].Value = (double.Parse(subTotalDataGridView.Rows[0].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency) * tax).ToString("c");
                    for (int i = 0; i < subTotalCartGridView.Rows.Count; i++)
                    {
                        totalCartGridView.Rows.Add(new object[] { subTotalCartGridView.Rows[i].Cells[0].Value, subTotalCartGridView.Rows[i].Cells[1].Value, (double.Parse(subTotalCartGridView.Rows[i].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency) * tax).ToString("c"), subTotalCartGridView.Rows[i].Cells[3].Value });
                    }
                }
                else
                {
                MessageBox.Show("Please add an item to the cart first.");
                }
         }
    }
}

