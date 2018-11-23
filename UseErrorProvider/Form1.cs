using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace UseErrorProvider
{
    
    /// <summary>
    /// Using the error provider control - several examples
    /// </summary>
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // do nothing
        }



        /// <summary>
        /// Validate to make sure that the textbox contains
        /// a string with at least one character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmptyString_Validated(object sender, EventArgs e)
        {
            bool bTest = txtEmptyStringIsValid();
            if (bTest == true)
            {
                this.errorProvider1.SetError(txtEmptyString, "This field must contain text");
            }
            else
            {
                this.errorProvider1.SetError(txtEmptyString, "");
            }
        }


        /// <summary>
        /// Test for empty string in the text box and
        /// return the results
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtEmptyStringIsValid()
        {
            if (txtEmptyString.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Test the contents of this text box against a regular expression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRegExString_Validated(object sender, EventArgs e)
        {
            bool bTest = txtRegExStringIsValid(txtRegExString.Text.ToString());
            if (bTest == false)
            {
                this.errorProvider1.SetError(txtRegExString, "This field must contain a phone number (222-333-4444)");
            }
            else
            {
                this.errorProvider1.SetError(txtRegExString, "");
            }
        }



        /// <summary>
        /// Test for a regex expression match in the text box and
        /// return the results - the example uses a regular
        /// expression used to validate a phone number
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtRegExStringIsValid(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"[2-9]\d{2}-\d{3}-\d{4}";

            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);

            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Validate that the textbox contains only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericString_Validated(object sender, EventArgs e)
        {
            bool bTest = txtNumericStringIsValid();
            if (bTest == true)
            {
                this.errorProvider1.SetError(txtNumericString, "This field must contain only numbers");
            }
            else
            {
                this.errorProvider1.SetError(txtNumericString, "");
            }
        }


        /// <summary>
        /// Test for non-numeric values in the text box and
        /// also make sure the textbox is not empty
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtNumericStringIsValid()
        {
            if (txtNumericString.Text == string.Empty)
            {
                return true;
            }

            char[] testArr = txtNumericString.Text.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsNumber(testArr[i]))
                {
                    testBool = true;
                }
            }

            return testBool;
            
        }


        /// <summary>
        /// Test to validate that this textbox only contains
        /// alphas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAlphaString_Validated(object sender, EventArgs e)
        {
            bool bTest = txtAlphaStringIsValid();
            if (bTest == true)
            {
                this.errorProvider1.SetError(txtAlphaString, "This field must contain only alphas");
            }
            else
            {
                this.errorProvider1.SetError(txtAlphaString, "");
            }
        }



        /// <summary>
        /// Test for non-alpha values in the text box and
        /// also make sure that the textbox is not empty
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtAlphaStringIsValid()
        {
            // first make sure the textbox contains something
            if (txtAlphaString.Text == string.Empty)
            {
                return true;
            }

            // test each character in the textbox
            char[] testArr = txtAlphaString.Text.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsLetter(testArr[i]))
                {
                    testBool = true;
                }
            }

            return testBool;
        }



        /// <summary>
        /// Validate that the textbox contains a value 
        /// that is between 50 and 100
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRangeValidation_Validated(object sender, EventArgs e)
        {
            bool bTest = txtRangeValidationIsValid();
            if (bTest == false)
            {
                this.errorProvider1.SetError(txtRangeValidation, "This field must contain a number between 50 and 100");
                this.errorProvider2.SetError(txtRangeValidation, "");
            }
            else
            {
                this.errorProvider1.SetError(txtRangeValidation, "");
                this.errorProvider2.SetError(txtRangeValidation, "The value is between 50 and 100");
            }
        }



        /// <summary>
        /// Test for numeric values between 50 and 100 in the text box and
        /// return the results
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtRangeValidationIsValid()
        {
            int tmpVal = 0;

            try
            {
                tmpVal = Convert.ToInt32(txtRangeValidation.Text);
            }
            catch { }

            bool testBool = false;

            if (tmpVal < 100 && tmpVal > 50)
            {
                testBool = true;
            }

            return testBool;
        }



        /// <summary>
        /// Validate that the text box contains only numbers
        /// or letters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAlphaNumericString_Validated(object sender, EventArgs e)
        {
            bool bTest = txtAlphaNumericStringIsValid();
            if (bTest == true)
            {
                this.errorProvider1.SetError(txtAlphaNumericString, "This field must contain only alphanumerics");
            }
            else
            {
                this.errorProvider1.SetError(txtAlphaNumericString, "");
            }
        }



        /// <summary>
        /// Test for non-alpha values in the text box and
        /// return the results
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtAlphaNumericStringIsValid()
        {
            // Make sure the string is not empty first
            if (txtAlphaNumericString.Text == string.Empty)
            {
                return true;
            }

            // check for alphanumeric values
            char[] testArr = txtAlphaNumericString.Text.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsLetter(testArr[i]) && !char.IsNumber(testArr[i]))
                {
                    testBool = true;
                }
            }

            return testBool;
        }
        


        /// <summary>
        /// Validate that this text box contains only special characters
        /// (non-alphanumerics)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSpecialChars_Validated(object sender, EventArgs e)
        {
            bool bTest = txtSpecialCharsIsValid();
            if (bTest == false)
            {
                this.errorProvider1.SetError(txtSpecialChars, "This field must contain only special characters");
            }
            else
            {
                this.errorProvider1.SetError(txtSpecialChars, "");
            }
        }



        /// <summary>
        /// Test for special character values in the textbox
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtSpecialCharsIsValid()
        {
            // Make sure the string is not empty first
            if (txtSpecialChars.Text == string.Empty)
            {
                return false;
            }

            char[] testArr = txtSpecialChars.Text.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsSymbol(testArr[i]))
                {
                    testBool = true;
                }

                if(char.IsLetterOrDigit(testArr[i]))
                {
                    testBool = false;
                }
            }

            return testBool;
        }



        /// <summary>
        /// Validate that the text box contains a minimum
        /// number of characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMinLengthTest_Validated(object sender, EventArgs e)
        {
            bool bTest = txtMinLengthTestIsValid();
            if (bTest == true)
            {
                this.errorProvider1.SetError(txtMinLengthTest, 
                    "This field must contain at least 3 characters");
            }
            else
            {
                this.errorProvider1.SetError(txtMinLengthTest, "");
            }
        }



        /// <summary>
        /// Test to see that the textbox contains a minimum number
        /// of characters
        /// </summary>
        /// <returns>boolean</returns>
        private bool txtMinLengthTestIsValid()
        {
            char[] testArr = txtMinLengthTest.Text.ToCharArray();
            bool testBool = false;

            if (testArr.Length < 3)
            {    
                testBool = true;
            }

            return testBool;
        }



        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// Validate all of the controls at the same time from
        /// a button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidateAll_Click(object sender, EventArgs e)
        {
            //ftxtEmptyString_Validated(this, e);
            txtAlphaNumericString_Validated(this, e);
            txtAlphaString_Validated(this, e);
            txtMinLengthTest_Validated(this, e);
            txtNumericString_Validated(this, e);
            txtRangeValidation_Validated(this, e);
            txtRegExString_Validated(this, e);
            txtSpecialChars_Validated(this, e);
        }


    }
}