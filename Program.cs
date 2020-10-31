//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: Make a window application to calculate Hair service fee   
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;
using System.Windows.Forms;

namespace Lab2B
{
    /// <summary>
    /// This class is the main class in the program and control the program
    /// </summary>
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
            Application.Run(new Form1());
        }
    }
}
