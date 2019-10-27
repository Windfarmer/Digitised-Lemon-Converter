using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLCMayJune
{
    public partial class formDLC : Form
    {

        
        
        // Look at all these currencies and their values!
        Decimal USD = 5487500;
        Decimal EUR = 6133950;
        Decimal GBP = 6931700;
        Decimal RUB = 83669;
        Decimal RSD = 52039;
        Decimal SEK = 577850;
        Decimal CAD = 4060280;
        Decimal AUD = 3806055;
        Decimal CNY = 794935;
        Decimal JPY = 50677;

        // The bool property that makes the converter change directions
        private bool _modeConvert;

        public bool modeConvert
        {
            get
            {
                return _modeConvert;
            }
            set
            {
                _modeConvert = value;
                labelInput.Text = _modeConvert ? "Input in lemons" : "Input in selected currency";
                labelOutput.Text = _modeConvert ? "Output in selected currency" : "Output in lemons";
            }
        }

        public formDLC()
        {
            InitializeComponent();
        }

        // This switches the conversion direction, must I explain this
        private void buttonDirection_Click(object sender, EventArgs e)
        {
            modeConvert = !modeConvert;
        }

        // Do I have to explain this too? this makes the converter convert
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // but these three statements don't convert anything
            if (modeConvert == true)
            {
                Console.WriteLine("Success (true) " + boxOutput.Text);
            }
            if (modeConvert == false)
            {
                Console.WriteLine("Success (false) " + boxOutput.Text);
            }
            else
            {
                Console.WriteLine("Failure " + boxOutput.Text);
            }



            // but these ones do
            if (modeConvert == true)
            {
                if (boxCurrency.Text == "US dollar (USD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / USD).ToString();
                }
                if (boxCurrency.Text == "Euro (EUR)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / EUR).ToString();
                }
                if (boxCurrency.Text == "British pound (GBP)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / GBP).ToString();
                }
                if (boxCurrency.Text == "Russian ruble (RUB)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / RUB).ToString();
                }
                if (boxCurrency.Text == "Serbian dinar (RSD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / RSD).ToString();
                }
                if (boxCurrency.Text == "Swedish krona (SEK)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / SEK).ToString();
                }
                if (boxCurrency.Text == "Canadian dollar (CAD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / CAD).ToString();
                }
                if (boxCurrency.Text == "Australian dollar (AUD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / AUD).ToString();
                }
                if (boxCurrency.Text == "Chinese yuan (CNY)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / CNY).ToString();
                }
                if (boxCurrency.Text == "Japanese yen (JPY)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) / JPY).ToString();
                }
            }

            if (modeConvert == false)
            {
                if (boxCurrency.Text == "US dollar (USD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * USD).ToString();
                }
                if (boxCurrency.Text == "Euro (EUR)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * EUR).ToString();
                }
                if (boxCurrency.Text == "British pound (GBP)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * GBP).ToString();
                }
                if (boxCurrency.Text == "Russian ruble (RUB)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * RUB).ToString();
                }
                if (boxCurrency.Text == "Serbian dinar (RSD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * RSD).ToString();
                }
                if (boxCurrency.Text == "Swedish krona (SEK)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * SEK).ToString();
                }
                if (boxCurrency.Text == "Canadian dollar (CAD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * CAD).ToString();
                }
                if (boxCurrency.Text == "Australian dollar (AUD)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * AUD).ToString();
                }
                if (boxCurrency.Text == "Chinese yuan (CNY)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * CNY).ToString();
                }
                if (boxCurrency.Text == "Japanese yen (JPY)")
                {
                    boxOutput.Text = (Decimal.Parse(boxInput.Text) * JPY).ToString();
                }
            }
        }

        // This makes the about page appear
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();

            formAbout.Show();
        }
    }
}
