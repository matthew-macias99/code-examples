namespace midterm
{
    public partial class CalcApp : Form
    {
        private int currentInput = 0;
        private Calculator calculator = new Calculator();
        private MemoryCalculator memoryCalculator = new MemoryCalculator();
        private int firstNumber;
        private string operation;
        public CalcApp()
        {
            InitializeComponent();
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput = currentInput * 10 + int.Parse(button.Text);
            txtNumberInput.Text = currentInput.ToString();
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            firstNumber = currentInput;
            operation = (sender as Button).Text;
            currentInput = 0;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                int secondNumber = currentInput;
                int result = operation switch
                {
                    "+" => calculator.Add(firstNumber, secondNumber),
                    "-" => calculator.Subtract(firstNumber, secondNumber),
                    "*" => calculator.Multiply(firstNumber, secondNumber),
                    "/" => calculator.Divide(firstNumber, secondNumber),
                    _ => 0
                };
                txtNumberInput.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                txtNumberInput.Text = "Error: Can't Divide by Zero";
            }
            catch (Exception ex)
            {
                txtNumberInput.Text = ex.Message;
            }
            finally
            {
                currentInput = 0;
            }   
        }
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                int value = currentInput;
                int result = calculator.SquareRoot(value);
                txtNumberInput.Text = result.ToString();
                currentInput = 0;
            }
            catch (Exception ex)
            {
                txtNumberInput.Text = ex.Message;
            }
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                int value = currentInput;
                int result = calculator.Reciprocal(value);
                txtNumberInput.Text = result.ToString();
                currentInput = 0;
            }
            catch (Exception ex)
            {
                txtNumberInput.Text = ex.Message;
            }
        }
        private void btnPosOrNeg_Click(object sender, EventArgs e)
        {
            currentInput = -currentInput;
            txtNumberInput.Text = currentInput.ToString();
        }
        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memoryCalculator.MemorySave(currentInput);
            txtNumberInput.Text = "Saved to memory";
            btnMemory.Text = "M";
            currentInput = 0;
            
        }
        private void btnMemoryAddValue_Click(object sender, EventArgs e)
        {
            memoryCalculator.MemoryPlus(currentInput);
            txtNumberInput.Text = "Added to memory";
            btnMemory.Text = "M";
            currentInput = 0;
            
        }
        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            int value = memoryCalculator.MemoryRecall();
            txtNumberInput.Text = value.ToString();
        }
        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memoryCalculator.MemoryClear();
            btnMemory.Text = " ";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string currentInputAsString = currentInput.ToString();
            if (currentInputAsString.Length > 1)
            {
                currentInputAsString = currentInputAsString.Substring(0, currentInputAsString.Length - 1);
                currentInput = int.Parse(currentInputAsString);
            }
            else
            {
                currentInput = 0;
            }
            txtNumberInput.Text = currentInput.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = 0;
            txtNumberInput.Text = " ";
        }
    }
}
