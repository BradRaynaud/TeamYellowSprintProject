﻿using System;
using System.Windows.Forms;

namespace GenericRPG {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMap("level-1"));
            Application.Run(new Frm_Menu());
        }
    }
}
