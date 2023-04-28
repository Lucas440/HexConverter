namespace TextToHex
{
    partial class HexGUI
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
            label1 = new Label();
            Input_TextBox = new TextBox();
            Output_Label = new Label();
            label4 = new Label();
            Convert_Button = new Button();
            BitA_CheckBox = new CheckBox();
            BitB_CheckBox = new CheckBox();
            BitC_CheckBox = new CheckBox();
            BitD_CheckBox = new CheckBox();
            ShortInput_TextBox = new TextBox();
            label2 = new Label();
            DateInput_DatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 244);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Input Text";
            // 
            // Input_TextBox
            // 
            Input_TextBox.Location = new Point(61, 278);
            Input_TextBox.Name = "Input_TextBox";
            Input_TextBox.Size = new Size(286, 27);
            Input_TextBox.TabIndex = 1;
            Input_TextBox.TextChanged += Input_TextBox_TextChanged;
            // 
            // Output_Label
            // 
            Output_Label.AutoSize = true;
            Output_Label.Location = new Point(69, 353);
            Output_Label.Name = "Output_Label";
            Output_Label.Size = new Size(55, 20);
            Output_Label.TabIndex = 3;
            Output_Label.Text = "Output";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 324);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 4;
            label4.Text = "Hex";
            // 
            // Convert_Button
            // 
            Convert_Button.Location = new Point(353, 278);
            Convert_Button.Name = "Convert_Button";
            Convert_Button.Size = new Size(94, 29);
            Convert_Button.TabIndex = 5;
            Convert_Button.Text = "Convert!";
            Convert_Button.UseVisualStyleBackColor = true;
            Convert_Button.Click += Convert_Button_Click;
            // 
            // BitA_CheckBox
            // 
            BitA_CheckBox.AutoSize = true;
            BitA_CheckBox.Location = new Point(61, 33);
            BitA_CheckBox.Name = "BitA_CheckBox";
            BitA_CheckBox.Size = new Size(59, 24);
            BitA_CheckBox.TabIndex = 6;
            BitA_CheckBox.Text = "BitA";
            BitA_CheckBox.UseVisualStyleBackColor = true;
            BitA_CheckBox.CheckedChanged += BitA_CheckBox_CheckedChanged;
            // 
            // BitB_CheckBox
            // 
            BitB_CheckBox.AutoSize = true;
            BitB_CheckBox.Location = new Point(126, 33);
            BitB_CheckBox.Name = "BitB_CheckBox";
            BitB_CheckBox.Size = new Size(58, 24);
            BitB_CheckBox.TabIndex = 7;
            BitB_CheckBox.Text = "BitB";
            BitB_CheckBox.UseVisualStyleBackColor = true;
            BitB_CheckBox.CheckedChanged += BitB_CheckBox_CheckedChanged;
            // 
            // BitC_CheckBox
            // 
            BitC_CheckBox.AutoSize = true;
            BitC_CheckBox.Location = new Point(190, 33);
            BitC_CheckBox.Name = "BitC_CheckBox";
            BitC_CheckBox.Size = new Size(58, 24);
            BitC_CheckBox.TabIndex = 8;
            BitC_CheckBox.Text = "BitC";
            BitC_CheckBox.UseVisualStyleBackColor = true;
            BitC_CheckBox.CheckedChanged += BitC_CheckBox_CheckedChanged;
            // 
            // BitD_CheckBox
            // 
            BitD_CheckBox.AutoSize = true;
            BitD_CheckBox.Location = new Point(254, 33);
            BitD_CheckBox.Name = "BitD_CheckBox";
            BitD_CheckBox.Size = new Size(60, 24);
            BitD_CheckBox.TabIndex = 9;
            BitD_CheckBox.Text = "BitD";
            BitD_CheckBox.UseVisualStyleBackColor = true;
            BitD_CheckBox.CheckedChanged += BitD_CheckBox_CheckedChanged;
            // 
            // ShortInput_TextBox
            // 
            ShortInput_TextBox.Location = new Point(61, 127);
            ShortInput_TextBox.Name = "ShortInput_TextBox";
            ShortInput_TextBox.Size = new Size(125, 27);
            ShortInput_TextBox.TabIndex = 10;
            ShortInput_TextBox.TextChanged += ShortInput_TextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 104);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 11;
            label2.Text = "Input Short";
            // 
            // DateInput_DatePicker
            // 
            DateInput_DatePicker.Location = new Point(61, 191);
            DateInput_DatePicker.Name = "DateInput_DatePicker";
            DateInput_DatePicker.Size = new Size(250, 27);
            DateInput_DatePicker.TabIndex = 12;
            DateInput_DatePicker.ValueChanged += DateInput_DatePicker_ValueChanged;
            // 
            // HexGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 410);
            Controls.Add(DateInput_DatePicker);
            Controls.Add(label2);
            Controls.Add(ShortInput_TextBox);
            Controls.Add(BitD_CheckBox);
            Controls.Add(BitC_CheckBox);
            Controls.Add(BitB_CheckBox);
            Controls.Add(BitA_CheckBox);
            Controls.Add(Convert_Button);
            Controls.Add(label4);
            Controls.Add(Output_Label);
            Controls.Add(Input_TextBox);
            Controls.Add(label1);
            Name = "HexGUI";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Input_TextBox;
        private Label Output_Label;
        private Label label4;
        private Button Convert_Button;
        private CheckBox BitA_CheckBox;
        private CheckBox BitB_CheckBox;
        private CheckBox BitC_CheckBox;
        private CheckBox BitD_CheckBox;
        private TextBox ShortInput_TextBox;
        private Label label2;
        private DateTimePicker DateInput_DatePicker;
    }
}