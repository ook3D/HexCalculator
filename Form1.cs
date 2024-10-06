using MaterialSkin;
using MaterialSkin.Controls;

namespace HexCalculator
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InputHexValue1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputHexValue2TextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void CalculateHexButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from input textboxes
                string hex1 = InputHexValue1TextBox.Text.Trim();
                string hex2 = InputHexValue2TextBox.Text.Trim();
                string operation = OperationComboBox.Text.Trim();

                // Convert hex strings to integers
                int value1 = Convert.ToInt32(hex1, 16);
                int value2 = Convert.ToInt32(hex2, 16);

                int result = 0;

                // Perform the selected operation
                if (operation == "+")
                {
                    result = value1 + value2;
                }
                else if (operation == "-")
                {
                    result = value1 - value2;
                }
                else
                {
                    MessageBox.Show("Invalid operation selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determine the maximum length for formatting the result
                int maxLength = Math.Max(hex1.Length - 2, hex2.Length - 2); // Subtract 2 to exclude the "0x" prefix

                // Format the result as a hex string and display it in the output textbox
                OutputHexTextBox.Text = "0x" + result.ToString($"X{maxLength}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hex value entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
