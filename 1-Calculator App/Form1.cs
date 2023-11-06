namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variable number hold one operand and answer variable hold final answer 
        float number=0, answer=0;
        //count variable for operations
        int count=0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        //button divide
        private void button16_Click(object sender, EventArgs e)
        {
            number = float.Parse(outputscreen.Text);
            outputscreen.Clear();
            count = 4;
            textBox1.Text = number.ToString() + "÷";
        }


        //button clear
        private void button5_Click(object sender, EventArgs e)
        {
            outputscreen.Clear();
            textBox1.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //button one
        private void one_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + one.Text;
        }
        //button two
        private void two_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + two.Text;

        }
        //button three
        private void three_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + three.Text;



        }
        //button four
        private void four_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + four.Text;
        }
        //button five
        private void five_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + five.Text;
        }
        //button six
        private void six_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + six.Text;
        } 
        //button seven
        private void button1_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + seven.Text;
        }
        //button eight
        private void eight_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + eight.Text;
        }
        //button nine
        private void nine_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + nine.Text;
        }
        //button zero
        private void zero_Click(object sender, EventArgs e)
        {
            outputscreen.Text = outputscreen.Text + zero.Text;
        }
        //button dot
        private void dot_Click(object sender, EventArgs e)
        {
            if (!outputscreen.Text.Contains("."))
            {
                outputscreen.Text = outputscreen.Text + dot.Text;
            }
        }


        //button modulus
        private void modulus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("%"))
            {
                number = float.Parse(outputscreen.Text);
                outputscreen.Clear();
                count = 5;
                textBox1.Text = number.ToString() + "%";
            }
        }
        //button multiply
        private void multiply_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("×"))
            {
                number = float.Parse(outputscreen.Text);
                outputscreen.Clear();
                count = 3;
                textBox1.Text = number.ToString() + "×";
            }
        }
        //button minus
        private void minus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("-"))
            {
                number = float.Parse(outputscreen.Text);
                outputscreen.Clear();
                count = 2;
                textBox1.Text = number.ToString() + "-";
            }
        }
        //button add
        private void add_Click(object sender, EventArgs e)

        {

            if (!textBox1.Text.Contains("+"))
            {
                number = float.Parse(outputscreen.Text);
                outputscreen.Clear();
                outputscreen.Focus();
                count = 1;
                textBox1.Text = number.ToString() + "+";
            }
            
        }
        //Taking Square of Any Number
        private void square_Click(object sender, EventArgs e)

        {
            textBox1.Text = $"{outputscreen.Text}x{outputscreen.Text}";
            float sqr = float.Parse(outputscreen.Text) * float.Parse(outputscreen.Text);
            outputscreen.Clear();
            outputscreen.Text = outputscreen.Text + sqr;
        }
        //Taking Cube of Any Number
        private void cube_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{outputscreen.Text}x{outputscreen.Text}x{outputscreen.Text}";
            float c = float.Parse(outputscreen.Text) * float.Parse(outputscreen.Text) * float.Parse(outputscreen.Text);
            outputscreen.Clear();
            outputscreen.Text = outputscreen.Text + c;
        }
        //This Function call compute function for calculations
        private void button12_Click(object sender, EventArgs e)
        {
            compute();

        }
        //Perform Calculations
        private void compute()
        {
            switch (count)
            {
                //Addition
                case 1:
                    textBox1.Text = textBox1.Text + outputscreen.Text;
                    answer = number + float.Parse(outputscreen.Text);
                    outputscreen.Clear();
                    outputscreen.Text = answer.ToString();
                    break;
                //Subtraction
                case 2:
                    textBox1.Text = textBox1.Text + outputscreen.Text;
                    answer = number - float.Parse(outputscreen.Text);
                    outputscreen.Clear();
                    outputscreen.Text = answer.ToString();
                    break;
                //Multiplication
                case 3:
                    textBox1.Text = textBox1.Text + outputscreen.Text;
                    answer = number * float.Parse(outputscreen.Text);
                    outputscreen.Clear();
                    outputscreen.Text = answer.ToString();
                    break;
                //Division
                case 4:
                  
                    if (float.Parse(outputscreen.Text) == 0)
                    {
                        outputscreen.Clear();
                        outputscreen.Text = "Cannot Divide by zero";
                        break;
                    }
                    else
                    {
                    textBox1.Text = textBox1.Text + outputscreen.Text;
                    answer = number / float.Parse(outputscreen.Text);
                    outputscreen.Clear();
                    outputscreen.Text = answer.ToString();
                    break;
                    }
                 //Modulus    
                case 5:
                    textBox1.Text = textBox1.Text + outputscreen.Text;
                    answer = number % float.Parse(outputscreen.Text);
                    outputscreen.Clear();
                    outputscreen.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //button del
        private void del_Click(object sender, EventArgs e)
        {
            if(outputscreen.Text == "")
            {
                outputscreen.Text = textBox1.Text;
                textBox1.Clear();
                
                int length= outputscreen.Text.Length-1;
                string text = outputscreen.Text;
                outputscreen.Clear() ;
                for(int i = 0;i<length; i++)
                {
                    outputscreen.Text = outputscreen.Text + text[i];
                }

            }
            else
            {
                
                int length = outputscreen.Text.Length - 1;
                string text = outputscreen.Text;
                outputscreen.Clear();
                for (int i = 0; i < length; i++)
                {
                    outputscreen.Text = outputscreen.Text + text[i];
                }
            }
        }
    }
}

