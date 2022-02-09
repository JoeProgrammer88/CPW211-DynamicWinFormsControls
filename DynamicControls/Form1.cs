namespace DynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dynamicButtonNumber = 1;
        Point currentPosition = new Point(0, 0);

        private void btnCreateButtons_Click(object sender, EventArgs e)
        {
            const int ButtonWidth = 200;

            Button dynamicButton = new()
            {
                Text = "This button was generated!",
                Size = new Size(ButtonWidth, 50),
                Location = new Point(ButtonWidth * (dynamicButtonNumber - 1), 0)
            };

            dynamicButton.Click += DynamicButton_Click;
            dynamicButton.Tag = "Button #" + dynamicButtonNumber++;

            flpDynamicControls.Controls.Add(dynamicButton);
        }

        private void DynamicButton_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("You clicked the dynamic button " + clickedButton.Tag);

            // this.Controls.Remove(clickedButton);
        }
    }
}