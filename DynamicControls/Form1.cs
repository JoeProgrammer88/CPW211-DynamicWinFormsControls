namespace DynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dynamicButtonNumber = 1;

        private void btnCreateButtons_Click(object sender, EventArgs e)
        {
            Button dynamicButton = new()
            {
                Text = "This button was generated!",
                Size = new Size(200, 50),
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            dynamicButton.Click += DynamicButton_Click;
            dynamicButton.Tag = "Button #" + dynamicButtonNumber++;

            this.Controls.Add(dynamicButton);
        }

        private void DynamicButton_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("You clicked the dynamic button " + clickedButton.Tag);

            this.Controls.Remove(clickedButton);
        }
    }
}