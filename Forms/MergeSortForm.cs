using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MergeSort.MergeSort;

namespace MergeSort.Forms.SmithMergeSortUI
{
    public partial class SmithMergeSortForm : Form
    {
        public SmithMergeSortForm()
        {
            InitializeComponent();
        }

        private void SmithMergeSortForm_Load(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RandomNumber randomGenerator = new RandomNumber();
            txtInput.Text = String.Join(", ", randomGenerator.GenerateRandomNumber(1, 1000));
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = {','};

            List<int> ListToSort = txtInput.Text.TrimEnd(charsToTrim).Split(',').Select(int.Parse).ToList();
            MergeSort<int> SortInParallel = new MergeSort<int>();

            SortInParallel.Sort(ListToSort);
            lblResult.Text = String.Join(", ", ListToSort);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //////// only allow one comma and not at the start
            if ((sender as TextBox).Text.Length <= 0 && (e.KeyChar == ','))
            {
                e.Handled = true ;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = ((sender as TextBox).Text.Length > 0);

            if ((sender as TextBox).Text.IndexOf(",,") >= 0)
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Replace(",,", ",");
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
        }
    }
}
