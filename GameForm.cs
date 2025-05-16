using System;
using System.Drawing;
using System.Windows.Forms;

public class GameForm : Form
{
    public GameForm()
    {
        this.BackColor = Color.White;
        this.ClientSize = new Size(800, 600);
        this.FormBorderStyle = FormBorderStyle.None;

        this.Paint += DrawCenteredText;
    }

    private void DrawCenteredText(object? sender, PaintEventArgs e)
    {
        string text = "Rythm Game";
        Font font = new Font("Arial", 24);
        Brush brush = Brushes.Black;

        SizeF textSize = e.Graphics.MeasureString(text, font);
        float x = (this.ClientSize.Width - textSize.Width) / 2;
        float y = (this.ClientSize.Height - textSize.Height) / 2;

        e.Graphics.DrawString(text, font, brush, x, y);
    }
}
