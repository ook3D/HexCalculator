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
            InputHexValue1TextBox = new MaterialSkin.Controls.MaterialTextBox();
            InputHexValue2TextBox = new MaterialSkin.Controls.MaterialTextBox();
            HexValue1Label = new Label();
            HexValue2Label = new Label();
            CalculateHexButton = new MaterialSkin.Controls.MaterialButton();
            OutputHexTextBox = new MaterialSkin.Controls.MaterialTextBox();
            OutputHexLabel = new Label();
            OperationComboBox = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // InputHexValue1TextBox
            // 
            InputHexValue1TextBox.AnimateReadOnly = false;
            InputHexValue1TextBox.BorderStyle = BorderStyle.None;
            InputHexValue1TextBox.Depth = 0;
            InputHexValue1TextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputHexValue1TextBox.LeadingIcon = null;
            InputHexValue1TextBox.Location = new Point(37, 117);
            InputHexValue1TextBox.MaxLength = 50;
            InputHexValue1TextBox.MouseState = MaterialSkin.MouseState.OUT;
            InputHexValue1TextBox.Multiline = false;
            InputHexValue1TextBox.Name = "InputHexValue1TextBox";
            InputHexValue1TextBox.Size = new Size(228, 50);
            InputHexValue1TextBox.TabIndex = 0;
            InputHexValue1TextBox.Text = "";
            InputHexValue1TextBox.TrailingIcon = null;
            InputHexValue1TextBox.TextChanged += InputHexValue1TextBox_TextChanged;
            // 
            // InputHexValue2TextBox
            // 
            InputHexValue2TextBox.AnimateReadOnly = false;
            InputHexValue2TextBox.BorderStyle = BorderStyle.None;
            InputHexValue2TextBox.Depth = 0;
            InputHexValue2TextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputHexValue2TextBox.LeadingIcon = null;
            InputHexValue2TextBox.Location = new Point(513, 117);
            InputHexValue2TextBox.MaxLength = 50;
            InputHexValue2TextBox.MouseState = MaterialSkin.MouseState.OUT;
            InputHexValue2TextBox.Multiline = false;
            InputHexValue2TextBox.Name = "InputHexValue2TextBox";
            InputHexValue2TextBox.Size = new Size(228, 50);
            InputHexValue2TextBox.TabIndex = 1;
            InputHexValue2TextBox.Text = "";
            InputHexValue2TextBox.TrailingIcon = null;
            InputHexValue2TextBox.TextChanged += InputHexValue2TextBox_TextChanged;
            // 
            // HexValue1Label
            // 
            HexValue1Label.AutoSize = true;
            HexValue1Label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexValue1Label.Location = new Point(71, 82);
            HexValue1Label.Name = "HexValue1Label";
            HexValue1Label.Size = new Size(145, 32);
            HexValue1Label.TabIndex = 2;
            HexValue1Label.Text = "Hex Value 1:";
            // 
            // HexValue2Label
            // 
            HexValue2Label.AutoSize = true;
            HexValue2Label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexValue2Label.Location = new Point(547, 82);
            HexValue2Label.Name = "HexValue2Label";
            HexValue2Label.Size = new Size(145, 32);
            HexValue2Label.TabIndex = 3;
            HexValue2Label.Text = "Hex Value 2:";
            // 
            // CalculateHexButton
            // 
            CalculateHexButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalculateHexButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CalculateHexButton.Depth = 0;
            CalculateHexButton.HighEmphasis = true;
            CalculateHexButton.Icon = null;
            CalculateHexButton.Location = new Point(314, 171);
            CalculateHexButton.Margin = new Padding(4, 6, 4, 6);
            CalculateHexButton.MouseState = MaterialSkin.MouseState.HOVER;
            CalculateHexButton.Name = "CalculateHexButton";
            CalculateHexButton.NoAccentTextColor = Color.Empty;
            CalculateHexButton.Size = new Size(135, 36);
            CalculateHexButton.TabIndex = 4;
            CalculateHexButton.Text = "Calculate Hex";
            CalculateHexButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CalculateHexButton.UseAccentColor = false;
            CalculateHexButton.UseVisualStyleBackColor = true;
            CalculateHexButton.Click += CalculateHexButton_Click;
            // 
            // OutputHexTextBox
            // 
            OutputHexTextBox.AnimateReadOnly = false;
            OutputHexTextBox.BorderStyle = BorderStyle.None;
            OutputHexTextBox.Depth = 0;
            OutputHexTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            OutputHexTextBox.LeadingIcon = null;
            OutputHexTextBox.Location = new Point(271, 304);
            OutputHexTextBox.MaxLength = 50;
            OutputHexTextBox.MouseState = MaterialSkin.MouseState.OUT;
            OutputHexTextBox.Multiline = false;
            OutputHexTextBox.Name = "OutputHexTextBox";
            OutputHexTextBox.Size = new Size(235, 50);
            OutputHexTextBox.TabIndex = 5;
            OutputHexTextBox.Text = "";
            OutputHexTextBox.TrailingIcon = null;
            // 
            // OutputHexLabel
            // 
            OutputHexLabel.AutoSize = true;
            OutputHexLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputHexLabel.Location = new Point(306, 269);
            OutputHexLabel.Name = "OutputHexLabel";
            OutputHexLabel.Size = new Size(143, 32);
            OutputHexLabel.TabIndex = 6;
            OutputHexLabel.Text = "Output Hex:";
            // 
            // OperationComboBox
            // 
            OperationComboBox.AutoResize = false;
            OperationComboBox.BackColor = Color.FromArgb(255, 255, 255);
            OperationComboBox.Depth = 0;
            OperationComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            OperationComboBox.DropDownHeight = 174;
            OperationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationComboBox.DropDownWidth = 121;
            OperationComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            OperationComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            OperationComboBox.FormattingEnabled = true;
            OperationComboBox.IntegralHeight = false;
            OperationComboBox.ItemHeight = 43;
            OperationComboBox.Items.AddRange(new object[] { "+", "-" });
            OperationComboBox.Location = new Point(321, 114);
            OperationComboBox.MaxDropDownItems = 4;
            OperationComboBox.MouseState = MaterialSkin.MouseState.OUT;
            OperationComboBox.Name = "OperationComboBox";
            OperationComboBox.Size = new Size(121, 49);
            OperationComboBox.StartIndex = 0;
            OperationComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(OperationComboBox);
            Controls.Add(OutputHexLabel);
            Controls.Add(OutputHexTextBox);
            Controls.Add(CalculateHexButton);
            Controls.Add(HexValue2Label);
            Controls.Add(HexValue1Label);
            Controls.Add(InputHexValue2TextBox);
            Controls.Add(InputHexValue1TextBox);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox InputHexValue1TextBox;
        private MaterialSkin.Controls.MaterialTextBox InputHexValue2TextBox;
        private Label HexValue1Label;
        private Label HexValue2Label;
        private MaterialSkin.Controls.MaterialButton CalculateHexButton;
        private MaterialSkin.Controls.MaterialTextBox OutputHexTextBox;
        private Label OutputHexLabel;
        private MaterialSkin.Controls.MaterialComboBox OperationComboBox;
    }
}
