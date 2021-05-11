using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// PROG1853
namespace InClass_ArraySearchMethod
{
    public partial class FrmArrayMethod : Form
    {
        // Fields (Class Level Variables)
        
        public FrmArrayMethod()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Local Variables (Method Level Variables)
            int[] itemNumber = { 23, 26, 31, 52, 76 };
            double[] itemPrice = { 1.23, 2.26, 3.31, 4.52, 5.76 };
            string[] itemDescription = { "One", "Two", "Three", "Four", "Five" };

            // User Input
            int input = int.Parse(txtUserInput.Text);
            txtOutput.Text = "Match Not Found";

            // Call method and output
            int index = SearchArray(itemNumber, input);
            if (index > -1) // determine if a valid index number is returned
            {
                txtOutput.Text = "Item Description: " + itemDescription[index] +
                                    "\r\nItem Price: " + itemPrice[index].ToString("C2");
            }
        }// click method()

        // User defined method
        // Search an array for a value
        int SearchArray(int[] array, int value)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == value)
                {
                    return index;
                }
            }
            return -1;
        }
    }// class
}// namespace
