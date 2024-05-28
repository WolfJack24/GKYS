using System;
using System.Windows.Forms;

namespace GKYS;

public class Die
{
    public static void End()
    {
        Console.WriteLine("I'm Dying");
        Application.Exit();
    }
}
