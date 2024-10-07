using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;
using System.Windows.Forms;

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
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void checkedListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                int newTotalHexValue = 0;

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    string? itemText = checkedListBox.Items[i]?.ToString() ?? string.Empty;
                    string hexValueString = itemText.Split(' ')[0];

                    if (hexValueString.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                    {
                        hexValueString = hexValueString.Substring(2);
                    }

                    int hexValue = int.Parse(hexValueString, NumberStyles.HexNumber);


                    if (i == e.Index)
                    {
                        if (e.NewValue == CheckState.Checked)
                        {
                            newTotalHexValue += hexValue;
                        }
                    }
                    else
                    {
                        if (checkedListBox.GetItemChecked(i))
                        {
                            newTotalHexValue += hexValue;
                        }
                    }
                }

                OutputHexTextBox.Text = $"0x{newTotalHexValue:X8}";
            }
        }
    }
}
