using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using HexCalculator.Models;

namespace HexCalculator.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string outputHexValue = "0x00000000";

        public ObservableCollection<AudioFlag> AudioFlags { get; } = new();

        public MainViewModel()
        {
            InitializeAudioFlags();
        }

        private void InitializeAudioFlags()
        {
            var flagDefinitions = new[]
            {
                (0x00000001, "Flags2"),
                (0x00000002, "ParentOverrides"),
                (0x00000004, "Volume"),
                (0x00000008, "VolumeVariance"),
                (0x00000010, "Pitch"),
                (0x00000020, "PitchVariance"),
                (0x00000040, "Pan"),
                (0x00000080, "PanVariance"),
                (0x00000100, "PreDelay"),
                (0x00000200, "PreDelayVariance"),
                (0x00000400, "StartOffset"),
                (0x00000800, "StartOffsetVariance"),
                (0x00001000, "AttackTime"),
                (0x00002000, "ReleaseTime"),
                (0x00004000, "DopplerFactor"),
                (0x00008000, "Category"),
                (0x00010000, "LPFCutOff"),
                (0x00020000, "LPFCutOffVariance"),
                (0x00040000, "HPFCutOff"),
                (0x00080000, "HPFCutOffVariance"),
                (0x00100000, "VolumeCurve"),
                (0x00200000, "VolumeCurveScale"),
                (0x00400000, "VolumeCurvePlateau"),
                (0x00800000, "SpeakerMask"),
                (0x01000000, "EffectRoute"),
                (0x02000000, "PreDelayVariable"),
                (0x04000000, "StartOffsetVariable"),
                (0x08000000, "SmallReverbSend"),
                (0x10000000, "MediumReverbSend"),
                (0x20000000, "LargeReverbSend")
            };

            foreach (var (hexValue, description) in flagDefinitions)
            {
                var flag = new AudioFlag
                {
                    HexValue = hexValue,
                    Description = description
                };

                flag.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == nameof(AudioFlag.IsChecked))
                    {
                        CalculateTotal();
                    }
                };

                AudioFlags.Add(flag);
            }
        }

        private void CalculateTotal()
        {
            int total = 0;
            foreach (var flag in AudioFlags)
            {
                if (flag.IsChecked)
                {
                    total += flag.HexValue;
                }
            }
            OutputHexValue = $"0x{total:X8}";
        }
    }
}
