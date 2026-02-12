using CommunityToolkit.Mvvm.ComponentModel;

namespace HexCalculator.Models
{
    public partial class AudioFlag : ObservableObject
    {
        public int HexValue { get; set; }
        public string Description { get; set; } = string.Empty;

        [ObservableProperty]
        private bool isChecked;

        public string DisplayText => $"0x{HexValue:X8} - {Description}";
    }
}
