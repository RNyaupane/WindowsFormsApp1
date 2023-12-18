namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber, secondNumber, result;

                //Int32.TryParse(textBoxFirstNumber.Text, out firstNumber);
                //Int32.TryParse(textBoxSecondNumber.Text, out secondNumber);

                firstNumber = Int32.Parse(textBoxFirstNumber.Text);
                secondNumber = Int32.Parse(textBoxSecondNumber.Text);

                result = firstNumber + secondNumber;

                //labelResult.Text = "The sum of " + firstNumber.ToString() + " and " + secondNumber.ToString() + " is " + result.ToString();
                labelResult.Text = $"The sum of {firstNumber} and {secondNumber} is {result}";
            }
            catch(FormatException ex)
            {
                labelResult.Text = $"Enter number only. Details: {ex.Message}";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Error occurred. {ex.Message}";
            }
        }
    }
}