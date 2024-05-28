using System.Windows.Forms;
using GKYS;

public class Program
{
    private static void dieButton_Click(object sender, System.EventArgs e)
    {
        Die.End();
    }

    public static void Main()
    {
        int width = 600;
        int height = 400;

        Form window = new Form
        {
            Text = "Test",
            Size = new Size(width, height),
        };

        int btnWidth = 60;
        int btnHeight = 30;


        Button dieButton = new Button
        {
            Text = "Kill me?",
            Size = new Size(btnWidth, btnHeight),
            Location = new Point((width / 2) - (btnWidth / 2), (height / 2) - (btnHeight / 2)),
        };

        dieButton.Click += new EventHandler(dieButton_Click);

        window.Controls.Add(dieButton);

        Application.Run(window);
    }
}

