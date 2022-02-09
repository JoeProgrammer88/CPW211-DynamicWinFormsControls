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

        List<Panel> controlGroupPanels = new List<Panel>();

        private void btnGenerateControlGroup_Click(object sender, EventArgs e)
        {
            // Panel container for holding a group of controls
            Panel controlPanel = new Panel();
            controlPanel.Size = new Size(500, 75);
            controlPanel.Location = new Point(0, 350);
            controlGroupPanels.Add(controlPanel);

            this.Controls.Add(controlPanel);

            // Populate first dynamic combo box
            ComboBox foodOptions = new ComboBox();
            List<string> allFoodOptions = GetFoodOptions();
            foreach(string option in allFoodOptions)
            {
                foodOptions.Items.Add(option);
            }
            foodOptions.SelectedIndexChanged += FoodOptions_SelectedIndexChanged;

            ComboBox toppings = new ComboBox();

            // Add 2nd dropdown in tag, to keep reference to associated combobox
            foodOptions.Tag = toppings; 

            TextBox test = new TextBox();
            test.Size = new Size(100, 50);
            test.Location = new Point(200, 0);

            controlPanel.Controls.Add(test);
            controlPanel.Controls.Add(foodOptions);
        }

        private void FoodOptions_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox currFoodOptionsBox = sender as ComboBox;
            ComboBox toppingsOptions = currFoodOptionsBox.Tag as ComboBox;

            List<string> toppings = GetToppingsForFood(currFoodOptionsBox.SelectedItem);
        }

        private List<string> GetToppingsForFood(object selectedItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Populating combobox with data. Data could come from
        /// DB or another source
        /// </summary>
        /// <param name="foodOptions"></param>
        private List<string> GetFoodOptions()
        {
            List<string> foodOptions = new List<string>
            {
                "Hamburger",
                "Pasta",
                "Chili"
            };
            return foodOptions;
        }

        private void btnExtractControlGroupData_Click(object sender, EventArgs e)
        {
            // Loop through each Panel that contains grouped controls
            foreach (Panel p in controlGroupPanels)
            {
                TextBox textBox = p.Controls[0] as TextBox;
                MessageBox.Show(textBox.Text);

                ComboBox foodOptions = p.Controls[1] as ComboBox;
                MessageBox.Show(foodOptions.SelectedItem.ToString());
            }
        }
    }
}