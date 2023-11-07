// namespace Domino;

using System;
using System.Drawing;
using System.Windows.Forms;
namespace Domino
{
    public class StartButton : Button
    {
        private Label text;

        public StartButton(string name)
        {
            this.Size = new Size(200, 50);
            this.BackColor = Color.DarkCyan;

            text = new Label();
            text.Text = name;
            text.AutoSize = true;
            text.ForeColor = Color.White;
            text.BackColor = Color.Transparent;

            int xPos = (this.Width - text.Width) / 2;
            int yPos = (this.Height - text.Height) / 2;
            text.Location = new Point(xPos, yPos);

            this.Controls.Add(text);

            this.MouseClick += StartButton_MouseClick;
            this.MouseEnter += StartButton_MouseEnter;
            this.MouseLeave += StartButton_MouseLeave;
        }

        private void StartButton_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick(EventArgs.Empty);
        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkCyan;
        }
    }
}
