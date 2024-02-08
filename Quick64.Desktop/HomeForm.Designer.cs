namespace Quick64.Desktop
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            EncodeButton = new Button();
            InputTextBox = new TextBox();
            DecodeButton = new Button();
            OutputTextBox = new TextBox();
            SuspendLayout();
            // 
            // EncodeButton
            // 
            EncodeButton.AccessibleDescription = "Button to encode a string to base 64";
            EncodeButton.AccessibleName = "Encode Button";
            EncodeButton.BackColor = Color.Green;
            EncodeButton.FlatStyle = FlatStyle.Popup;
            EncodeButton.Font = new Font("Cascadia Code", 13.875F);
            EncodeButton.Location = new Point(377, 438);
            EncodeButton.Margin = new Padding(4, 3, 4, 3);
            EncodeButton.Name = "EncodeButton";
            EncodeButton.Size = new Size(316, 75);
            EncodeButton.TabIndex = 0;
            EncodeButton.Text = "< Encode >";
            EncodeButton.UseVisualStyleBackColor = false;
            EncodeButton.Click += EncodeButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Font = new Font("Cascadia Code", 12F);
            InputTextBox.Location = new Point(194, 92);
            InputTextBox.Margin = new Padding(4, 3, 4, 3);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.PlaceholderText = "Text to encode/decode...";
            InputTextBox.Size = new Size(1408, 241);
            InputTextBox.TabIndex = 1;
            // 
            // DecodeButton
            // 
            DecodeButton.AccessibleDescription = "Button to decode a base 64 string";
            DecodeButton.AccessibleName = "Decode Button";
            DecodeButton.BackColor = Color.Green;
            DecodeButton.FlatAppearance.BorderColor = Color.Silver;
            DecodeButton.FlatStyle = FlatStyle.Popup;
            DecodeButton.Font = new Font("Cascadia Code", 13.875F);
            DecodeButton.Location = new Point(1002, 438);
            DecodeButton.Margin = new Padding(4, 3, 4, 3);
            DecodeButton.Name = "DecodeButton";
            DecodeButton.Size = new Size(316, 75);
            DecodeButton.TabIndex = 2;
            DecodeButton.Text = "< Decode >";
            DecodeButton.UseVisualStyleBackColor = false;
            DecodeButton.Click += DecodeButton_Click;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Font = new Font("Cascadia Code", 12F);
            OutputTextBox.Location = new Point(194, 593);
            OutputTextBox.Margin = new Padding(4, 3, 4, 3);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.PlaceholderText = "Output...";
            OutputTextBox.Size = new Size(1408, 241);
            OutputTextBox.TabIndex = 3;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1925, 848);
            Controls.Add(OutputTextBox);
            Controls.Add(DecodeButton);
            Controls.Add(InputTextBox);
            Controls.Add(EncodeButton);
            Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeForm";
            Text = "Quick64";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EncodeButton;
        private TextBox InputTextBox;
        private Button DecodeButton;
        private TextBox OutputTextBox;
    }
}