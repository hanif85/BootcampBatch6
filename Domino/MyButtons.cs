namespace Domino;

using System;
using System.Windows.Forms;

class MyButton : Button
{
    public MyButton()
    {
        // Initialize the button properties, such as size, text, and other settings.
        this.Size = new System.Drawing.Size(100, 30);
        this.Text = "Click Me";
        this.Click += Button_Click;  // Event handler for the click event
        this.MouseEnter += Button_MouseEnter;  // Event handler for mouse enter
        this.MouseLeave += Button_MouseLeave;  // Event handler for mouse leave
    }

    private void Button_Click(object sender, EventArgs e)
    {
        // Handle the button click event
        // You can put your code here
    }

    private void Button_MouseEnter(object sender, EventArgs e)
    {
        // Handle the mouse enter event
        // You can put your code here
    }

    private void Button_MouseLeave(object sender, EventArgs e)
    {
        // Handle the mouse leave event
        // You can put your code here
    }
}

// class Program
// {
//     [STAThread]
//     static void Main()
//     {
//         Application.EnableVisualStyles();
//         Application.SetCompatibleTextRenderingDefault(false);

//         // Create a Form and add the custom button to it
//         Form form = new Form();
//         MyButton button = new MyButton();
//         form.Controls.Add(button);

//         Application.Run(form);
//     }
// }

