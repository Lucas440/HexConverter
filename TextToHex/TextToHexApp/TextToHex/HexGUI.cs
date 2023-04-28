namespace TextToHex
{
    public partial class HexGUI : Form
    {
        private HexGUI_Logic _logic;

        public HexGUI(HexGUI_Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void Input_TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = _logic.OnTextChange(((TextBox)sender).Text);

        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            this.Output_Label.Text = _logic.ConvertToHex();
        }

        private void BitA_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _logic.BitA = ((CheckBox)sender).Checked;
        }

        private void BitB_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _logic.BitB = ((CheckBox)sender).Checked;
        }

        private void BitC_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _logic.BitC = ((CheckBox)sender).Checked;
        }

        private void BitD_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _logic.BitD = ((CheckBox)sender).Checked;
        }

        private void ShortInput_TextBox_TextChanged(object sender, EventArgs e)
        {
            _logic.OnShortChange(((TextBox)sender).Text);
        }

        private void DateInput_DatePicker_ValueChanged(object sender, EventArgs e)
        {
            _logic.OnDateChange(this.DateInput_DatePicker.Value);
        }
    }
}