using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSwitch
{
    public class MickeyEvilLightSwitch
    {
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive");
                }
                _price = value;
            }
        }

        private bool IsSwitchOn { get; set; }

        private bool IsFullBright { get; set; }

        public const int DimmestDimmerValue = 0;
        public const int BrightestDimmerValue = 5;
        public const int LowestIntensityValue = 0;
        public const int HighestIntensityValue = 5;
        public int DimmerValue { get; private set; }
        public int IntensityLedValue { get; private set; }

        public int PhysicalLightBrightness
        {
            get
            {
                if (!IsSwitchOn)
                {
                    return DimmestDimmerValue;
                }
                if (IsFullBright)
                {
                    return HighestIntensityValue;
                }
                return HighestIntensityValue;
            }
        }

        public void ClickBigButton()
        {
            if (IsSwitchOn)
            {
                IsSwitchOn = false;
                IsFullBright = false;
            }
            else
            {
                IsSwitchOn = true;
            }
        }

        public void DoubleClickBigButton()
        {
            IsSwitchOn = true;
            IsFullBright = true;
        }

        public void ClickDimmerUpButton()
        {
//            if (DimmerValue < BrightestDimmerValue)
//            {
//                DimmerValue++;
//            }
            if (IsSwitchOn == false)
            {
                DimmerValue++;
                if (DimmerValue > BrightestDimmerValue)
                {
                    DimmerValue = BrightestDimmerValue;
                }
            }
            if (IsSwitchOn)
            {
                IntensityLedValue++;
                if (IntensityLedValue > HighestIntensityValue)
                {
                    IntensityLedValue = HighestIntensityValue;
                }
            }
        }

        public void ClickDimmerDownButton()
        {
            if (IsSwitchOn == false)
            {
                if (IsFullBright)
                {
                    DimmerValue = BrightestDimmerValue - 1;
                    IsFullBright = false;
                }
                else
                {
                    DimmerValue--;
                    if (DimmerValue < DimmestDimmerValue)
                    {
                        DimmerValue = DimmestDimmerValue;
                    }
                }
            }
            if (IsSwitchOn)
            {
                IntensityLedValue--;
                if (IntensityLedValue < LowestIntensityValue)
                {
                    IntensityLedValue = LowestIntensityValue;
                }

            }
//            if (IsFullBright)
//            {
//                DimmerValue = BrightestDimmerValue - 1;
//                IsFullBright = false;
//            }
//            else
//            {
//                DimmerValue--;
//                if (DimmerValue < DimmestDimmerValue)
//                {
//                    DimmerValue = DimmestDimmerValue;
//                }
//            }
        }
    }
}
