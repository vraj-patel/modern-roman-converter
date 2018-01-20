using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace HinduArabic_and_Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // These arrays are created within the createArrays method and are used within other methods
        string[] newRomanSymbols;
        BigInteger[] newRomanValues;

        private void HAToRomanRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            InputHAOrRomanTextbox.Enabled = true;
            InputHAOrRomanTextbox.Clear();
            OutputHAOrRomanTextbox.Enabled = true;
            ChooseConversionTypeLabel.ForeColor = Color.Black;
        }

        private void RomanToHARadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            InputHAOrRomanTextbox.Enabled = true;
            InputHAOrRomanTextbox.Clear();
            OutputHAOrRomanTextbox.Enabled = true;
            ChooseConversionTypeLabel.ForeColor = Color.Black;
        }


        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Bitmap drawRomanNumberBtmp = null;

            if (HAToRomanRadioButton.Checked && InputHAOrRomanTextbox.Text.Length >= 1)
            {
                // creates the new arrays depending on the size hinduarabic number entered
                createArrays(BigInteger.Parse(InputHAOrRomanTextbox.Text));

                if (newRomanSymbols.Length > 14)
                {
                    drawRomanNumberBtmp = new Bitmap(newRomanSymbols.Length * 20, 222);
                    drawRomanNumberPictureBox.Width = newRomanSymbols.Length * 20;
                }

                else
                {
                    drawRomanNumberPictureBox.Width = 600;
                    drawRomanNumberBtmp = new Bitmap(600, 222);
                }

                OutputHAOrRomanTextbox.Text = hinduArabicTORoman(BigInteger.Parse(InputHAOrRomanTextbox.Text), drawRomanNumberBtmp);
            }

            else if (InputHAOrRomanTextbox.Text.Length == 0 && (HAToRomanRadioButton.Checked || RomanToHARadioButton.Checked))
                OutputHAOrRomanTextbox.Text = "Please Enter a Number To Convert";

            else if (RomanToHARadioButton.Checked && InputHAOrRomanTextbox.Text.Substring(0, 1) == "#")
                OutputHAOrRomanTextbox.Text = "The bar alone has no value (0*1000)";

            else if (RomanToHARadioButton.Checked && InputHAOrRomanTextbox.Text.Length >= 1)
            {
                createArrays(BigInteger.Parse("1"));

                string storeConversion = romanToHinduArabic(InputHAOrRomanTextbox.Text);

                // the original arrays need to be overwritten since the hinduArabicToRoman method is called bellow
                createArrays(BigInteger.Parse(storeConversion));

                // the input (storeConversion) is converted into a bigint and a roman output is produced  
                string storeOtherConversion = hinduArabicTORoman(BigInteger.Parse(storeConversion), drawRomanNumberBtmp);

                if (InputHAOrRomanTextbox.Text.Equals(storeOtherConversion))
                    OutputHAOrRomanTextbox.Text = storeConversion;

                else
                    OutputHAOrRomanTextbox.Text = "Invalid Roman Number";

            }

            else if ((HAToRomanRadioButton.Checked && RomanToHARadioButton.Checked) == false)
                OutputHAOrRomanTextbox.Text = "Please Select Conversion Type";

        }



        // This method creates or adds elements to the public arrays by augmenting the initial arrays 
        private void createArrays(BigInteger number)
        {
            int highestNumOfBars = 0;

            BigInteger numberRange = 4000;

            BigInteger[] initialRomanValues = { 1, 5, 10, 50, 100, 500, 1000 };
            string[] initialRomanSymbols = { "I", "V", "X", "L", "C", "D", "M" };

            while (numberRange <= number)
            {
                highestNumOfBars++;
                numberRange *= 1000;
            }

            // calculates the size of new arrays 
            newRomanSymbols = new string[6 * highestNumOfBars + 7];
            newRomanValues = new BigInteger[newRomanSymbols.Length];

            for (int x = 0; x < initialRomanSymbols.Length; x++)
            {
                newRomanSymbols[x] = initialRomanSymbols[x];
                newRomanValues[x] = initialRomanValues[x];
            }

            // adds roman numerals with '#' (bars), excluding the products of 'I' and 1000^n (since they can be written as 'M'* 1000^n-1) 
            for (int x = 7; x < newRomanSymbols.Length; x++)
            {
                if (newRomanSymbols[x - 7] == "I")
                {
                    newRomanSymbols[x] = newRomanSymbols[x - 6] + "#";
                    newRomanValues[x] = newRomanValues[x - 6] * 1000;
                }
                else
                {
                    newRomanSymbols[x] = newRomanSymbols[x - 6] + "#";
                    newRomanValues[x] = newRomanValues[x - 6] * 1000;
                }
            }

        }




        // The function of this method is to draw the roman numerals 
        private void drawRomanNumerals(string symbol, float posX, int numberOfBars, Bitmap drawRomanNumberBtmp)
        {

            SolidBrush brush = new SolidBrush(Color.Purple);

            Graphics graphic = Graphics.FromImage(drawRomanNumberBtmp);
            Font font = new Font("Arial", 12);
            Font font2 = new Font("Arial", 10);

            graphic.DrawString(symbol, font, brush, posX, 175);

            Pen drawBarsPen = new Pen(Color.Purple);

            float posYForBars = 175;
            for (int counter = 1; counter <= numberOfBars; counter++)
            {
                posYForBars -= 5;
                graphic.DrawLine(drawBarsPen, posX + 4, posYForBars, posX + 12, posYForBars);
            }
            if (numberOfBars > 0)
                graphic.DrawString(numberOfBars.ToString(), font2, brush, posX + 1, 195);

        }




        // Converts HinduArabic Numbers to Roman and uses the drawRomanNumerals method to create an accurate visual 
        private string hinduArabicTORoman(BigInteger hinduArabicNumber, Bitmap drawRomanNumberBtmp)
        {
            BigInteger remainder = hinduArabicNumber;
            BigInteger quotient = 0;
            string romanNumber = "";
            string symbol = "";
            int numberOfBars = 0;
            float posX = 15;

            for (int x = newRomanValues.Length - 1; x >= 0; x--)
            {
                symbol = "";
                numberOfBars = 0;
                quotient = remainder / newRomanValues[x];

                /* if romanValue[x] does not divide into the remainder atleast once, the quotient using intermediate symbols 
                 * (ex: IV, IX, ...) is checked. Since intermediate values consist of the original symbol along with another 
                 * symbol (which is a multiple of 10 or 0.1 apart) , only 2 other successive symbols can be allowed
                 * */
                if (quotient == 0 && x >= 2)
                {
                    for (int y = 1; y <= 2; y++)
                    {
                        quotient = remainder / (newRomanValues[x] - newRomanValues[x - y]);
                        if (quotient == 1 && newRomanValues[x] - newRomanValues[x - y] != newRomanValues[x - y])
                        {
                            romanNumber += newRomanSymbols[x - y] + newRomanSymbols[x];
                            symbol += newRomanSymbols[x - y] + newRomanSymbols[x];

                            remainder -= (newRomanValues[x] - newRomanValues[x - y]);
                        }
                    }
                }

                // Same reasoning as mentioned above, but if x == 1, there is only 1 successive symbol left to check within the array 
                else if (quotient == 0 && x == 1)
                {
                    quotient = remainder / (newRomanValues[x] - newRomanValues[x - 1]);
                    if (quotient == 1 && newRomanValues[x] - newRomanValues[x - 1] != newRomanValues[x - 1])
                    {
                        romanNumber += newRomanSymbols[x - 1] + newRomanSymbols[x];
                        symbol += newRomanSymbols[x - 1] + newRomanSymbols[x];

                        remainder -= (newRomanValues[x] - newRomanValues[x - 1]);
                    }
                }

                // Within this case, single (original) symbols are added to the romanNumber string, instead of intermediates
                else
                {
                    for (int z = 1; z <= quotient; z++)
                    {
                        romanNumber += newRomanSymbols[x];
                        symbol += newRomanSymbols[x];

                        remainder -= newRomanValues[x];
                    }
                    // This case is used to print out the final intermediate symbol (if it divides into the remainder)
                    if (x >= 2)
                    {
                        if (newRomanValues[x] - newRomanValues[x - 2] <= remainder)
                        {
                            romanNumber += newRomanSymbols[x - 2] + newRomanSymbols[x];
                            symbol += newRomanSymbols[x - 2] + newRomanSymbols[x];

                            remainder -= (newRomanValues[x] - newRomanValues[x - 2]);
                        }
                    }
                }

                // This case uses the drawRomanNumerals method to create the visual within a bitmap
                if (HAToRomanRadioButton.Checked)
                {
                    for (int counter = 0; counter <= symbol.Length - 1; counter++)
                    {
                        posX += 15;

                        numberOfBars = 0;

                        while (counter <= symbol.Length - 2 && symbol.Substring(counter + 1, 1) == "#")
                        {
                            numberOfBars++;
                            counter++;
                        }

                        drawRomanNumerals(symbol.Substring(counter - numberOfBars, 1), posX, numberOfBars, drawRomanNumberBtmp);

                    }
                }


            }

            if (HAToRomanRadioButton.Checked)
                drawRomanNumberPictureBox.Image = drawRomanNumberBtmp;

            return romanNumber;
        }



        // Checks validity of Roman number entered and converts it to Hindu-Arabic
        private string romanToHinduArabic(string romanNumber)
        {
            BigInteger hinduArabicNumber = 0;
            BigInteger currentSymbolValue = 0;
            BigInteger nextSymbolValue = 0;
            int numberOfBars = 0;
            int counterX = 0;

            if (romanNumber.Substring(0, 1) == "#")
                return "A Bar Alone Has No Value (0*1000)";


            while (counterX <= romanNumber.Length - 1)
            {
                numberOfBars = 0;
                currentSymbolValue = newRomanValues[Array.IndexOf(newRomanSymbols, romanNumber.Substring(counterX, 1))];

                if (romanNumber.Length == 1)
                {
                    hinduArabicNumber += currentSymbolValue;
                    break;
                }

                else if (romanNumber.Replace("#", "").Length == 1)
                {
                    while (counterX <= romanNumber.Length - 1)
                    {
                        if (romanNumber.Substring(counterX, 1) == "#")
                        {
                            numberOfBars++;
                            currentSymbolValue *= 1000;
                        }
                        counterX++;
                    }

                    hinduArabicNumber += currentSymbolValue;
                    break;
                }

                while (counterX <= romanNumber.Length - 2 && romanNumber.Substring(counterX + 1, 1) == "#")
                {
                    counterX++;
                    numberOfBars++;
                    currentSymbolValue *= 1000;
                }

                counterX++;
                numberOfBars = 0;

                if (counterX > romanNumber.Length - 1)
                    nextSymbolValue = 0;
                else
                    nextSymbolValue = newRomanValues[Array.IndexOf(newRomanSymbols, romanNumber.Substring(counterX, 1))];

                while (counterX <= romanNumber.Length - 2 && romanNumber.Substring(counterX + 1, 1) == "#")
                {
                    counterX++;
                    numberOfBars++;
                    nextSymbolValue *= 1000;
                }

                counterX -= numberOfBars;

                if (currentSymbolValue < nextSymbolValue)
                {
                    hinduArabicNumber -= currentSymbolValue;
                }
                else if (currentSymbolValue > nextSymbolValue)
                {
                    hinduArabicNumber += currentSymbolValue;
                }
                else if (currentSymbolValue == nextSymbolValue)
                {
                    hinduArabicNumber += currentSymbolValue;
                }
            }

            return hinduArabicNumber.ToString();
        }



        private void InputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RomanToHARadioButton.Checked)
            {
                if (Char.IsControl(e.KeyChar) || e.KeyChar == 'I' || e.KeyChar == 'V' || e.KeyChar == 'X' || e.KeyChar == 'L' || e.KeyChar == 'C' || e.KeyChar == 'D' || e.KeyChar == 'M' || e.KeyChar == '#')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            else if (HAToRomanRadioButton.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }


    }
}




