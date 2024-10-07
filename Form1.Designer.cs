namespace HexCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OutputHexTextBox = new MaterialSkin.Controls.MaterialTextBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // OutputHexTextBox
            // 
            OutputHexTextBox.AnimateReadOnly = false;
            OutputHexTextBox.BorderStyle = BorderStyle.None;
            OutputHexTextBox.Depth = 0;
            OutputHexTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            OutputHexTextBox.LeadingIcon = null;
            OutputHexTextBox.Location = new Point(6, 37);
            OutputHexTextBox.MaxLength = 50;
            OutputHexTextBox.MouseState = MaterialSkin.MouseState.OUT;
            OutputHexTextBox.Multiline = false;
            OutputHexTextBox.Name = "OutputHexTextBox";
            OutputHexTextBox.Size = new Size(340, 50);
            OutputHexTextBox.TabIndex = 5;
            OutputHexTextBox.Text = "";
            OutputHexTextBox.TrailingIcon = null;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "0x00000001 - Flags2", "0x00000002 - ParentOverrides", "0x00000004 - Volume", "0x00000008 - VolumeVariance", "0x00000010 - Pitch", "0x00000020 - PitchVariance", "0x00000040 - Pan", "0x00000080 - PanVariance", "0x00000100 - PreDelay", "0x00000200 - PreDelayVariance", "0x00000400 - StartOffset", "0x00000800 - StartOffsetVariance", "0x00001000 - AttackTime", "0x00002000 - ReleaseTime", "0x00004000 - DopplerFactor", "0x00008000 - Category", "0x00010000 - LPFCutOff", "0x00020000 - LPFCutOffVariance", "0x00040000 - HPFCutOff", "0X00080000 - HPFCutOffVariance", "0x00100000 - VolumeCurve", "0x00200000 - VolumeCurveScale", "0x00400000 - VolumeCurvePlateau", "0x00800000 - SpeakerMask", "0x01000000 - EffectRoute", "0x02000000 - PreDelayVariable", "0x04000000 - StartOffsetVariable", "0x08000000 - SmallReverbSend", "0x10000000 - MediumReverbSend", "0x20000000 - LargeReverbSend" });
            checkedListBox1.Location = new Point(6, 95);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(340, 562);
            checkedListBox1.TabIndex = 6;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 668);
            Controls.Add(checkedListBox1);
            Controls.Add(OutputHexTextBox);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox OutputHexTextBox;
        private CheckedListBox checkedListBox1;
    }
}
