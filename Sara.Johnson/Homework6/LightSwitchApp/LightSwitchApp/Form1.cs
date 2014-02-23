using System;
using System.Windows.Forms;
using LightSwitch;

namespace LightSwitchApp
{
    public partial class Form1 : Form
    {
        private readonly MickeyEvilLightSwitch _lightSwitch = new MickeyEvilLightSwitch();

        public Form1()
        {
            InitializeComponent();
            UpdateUi();
        }

        private void UpdateUi()
        {
            GetRadioButtonForDimmerValue().Checked = true;
            if (_lightSwitch.PhysicalLightBrightness == 0)
            {
                lightBrightnessDisplay.Text = @"Overhead light OFF";
            }
            else
            {
                lightBrightnessDisplay.Text = @"Overhead light ON: " + _lightSwitch.PhysicalLightBrightness;
            }
        }

        private RadioButton GetRadioButtonForDimmerValue()
        {
            switch (_lightSwitch.DimmerValue)
            {
                case 0: return dimmer0;
                case 1: return dimmer1;
                case 2: return dimmer2;
                case 3: return dimmer3;
                case 4: return dimmer4;
                case 5: return dimmer5;
                default:
                    MessageBox.Show(@"Illegal dimmer value: " + _lightSwitch.DimmerValue);
                    return dimmer0;
            }
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            _lightSwitch.ClickBigButton();
            UpdateUi();
        }

        private void bigButtonDoubleClick_Click(object sender, EventArgs e)
        {
            _lightSwitch.DoubleClickBigButton();
            UpdateUi();
        }

        private void dimmerUpButton_Click(object sender, EventArgs e)
        {
            _lightSwitch.ClickDimmerUpButton();
            UpdateUi();
        }

        private void dimmerDownButton_Click(object sender, EventArgs e)
        {
            _lightSwitch.ClickDimmerDownButton();
            UpdateUi();
        }
    }
}
