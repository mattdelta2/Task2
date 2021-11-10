using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
        Barrier,
        Empty,
        Obstacle
    }

    public enum MovementDirtection
    {
        NoMovement,
        Up,
        Down,
        Left,
        Right,


    }

    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
