using MergeSort.Forms.SmithMergeSortUI;
using System;
using System.Windows.Forms;

namespace MergeSort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmithMergeSortForm());
        }
    }
}
