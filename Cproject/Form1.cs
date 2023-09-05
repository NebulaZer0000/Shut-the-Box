namespace Cproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> baseList = new List<int>()
            {1,2,3,4,5,6,7,8,9};

        List<int> numUse = new List<int>()
            {1,2,3,4,5,6,7,8,9};

        List<int> numUsed = new List<int>()
        { };

        private void rollBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            die1Lbl.Text = die1.ToString();
            die2Lbl.Text = die2.ToString();

            rollBtn.Enabled = false;
            submitBtn.Enabled = true;
            loseCheck(die1, die2);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int die1 = int.Parse(die1Lbl.Text);
            int die2 = int.Parse(die2Lbl.Text);
            int total = die1 + die2;

            string amount1Str = num1TextBox.Text;
            string amount2Str = num2TextBox.Text;

            int amount1 = 0;
            int amount2 = 0;

            bool check1 = int.TryParse(amount1Str, out amount1);
            bool check2 = int.TryParse(amount2Str, out amount2);

            bool run = false;

            if (amount1Str == "")
            {
                check1 = true;
                amount1 = 0;
            }
            if (amount2Str == "")
            {
                check2 = true;
                amount2 = 0;
            }

            bool amountCheck = checkAmount(amount1, amount2);
            

            if (amountCheck)
            {
                bool dieCheck = checkDie(amount1, amount2, total);
                run = checkRun(check1, check2, dieCheck);
            }

            if (run)
            {
                (bool inspectCheck1, bool inspectCheck2) = inspectCheck(amount1, amount2);
                bool finalCheck = false;
                
                if (inspectCheck1 && inspectCheck2)
                {
                    finalCheck = true;
                }
                else
                {
                    string message = "";

                    foreach (int num in numUse)
                    {
                        message += " " + num;
                    }

                    MessageBox.Show("The usable numbers are" + message);
                }

                if (finalCheck)
                {
                    shutBox(amount1, amount2);
                }
            }
            else
            {
                MessageBox.Show("Something input was incorrect");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void shutBox(int amount1, int amount2)
        {

            if (amount1 != 0)
            {
                numUse.Remove(amount1);
                numUsed.Add(amount1);
                shutSwitch(amount1);
            }

            if (amount2 != 0)
            {
                numUse.Remove(amount2);
                numUsed.Add(amount2);
                shutSwitch(amount2);
            }

            num1TextBox.Text = "";
            num2TextBox.Text = "";
            rollBtn.Enabled = true;
            submitBtn.Enabled = false;
            winCheck();
        }

        private bool checkRun(bool check1, bool check2, bool checkDie)
        {
            if (check1 && check2)
            {
                if(checkDie)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool checkDie(int amount1, int amount2, int total)
        {
            int add = amount1 + amount2;
            if(add == total && amount1 != amount2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkAmount(int amount1, int amount2)
        {
            bool check1 = false;
            bool check2 = false;
            bool checkFinal = false;

            if (amount1 >= 0 && amount1 <= 9)
            {
                check1 = true;
            }
            if (amount2 >= 0 && amount2 <= 9)
            {
                check2 = true;
            }

            if (check1 && check2)
            {
                checkFinal = true;
            }

            if (checkFinal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private (bool inspectCheck1, bool inspectCheck2) inspectCheck(int amount1, int amount2)
        {
            bool inspectCheck1 = false;
            bool inspectCheck2 = false;

            if (numUse.Contains(amount1) || amount1 == 0)
            {
                inspectCheck1 = true;
            }
            if (numUse.Contains(amount2) || amount2 == 0)
            {
                inspectCheck2 = true;
            }

            return (inspectCheck1, inspectCheck2);

            
        }

        private void shutSwitch(int num)
        {
            switch (num)
            {
                case 1:
                    num1OpenLbl.Visible = false;
                    num1CloseLbl.Visible = true;
                    break;
                case 2:
                    num2OpenLbl.Visible = false;
                    num2CloseLbl.Visible = true;
                    break;
                case 3:
                    num3OpenLbl.Visible = false;
                    num3CloseLbl.Visible = true;
                    break;
                case 4:
                    num4OpenLbl.Visible = false;
                    num4CloseLbl.Visible = true;
                    break;
                case 5:
                    num5OpenLbl.Visible = false;
                    num5CloseLbl.Visible = true;
                    break;
                case 6:
                    num6OpenLbl.Visible = false;
                    num6CloseLbl.Visible = true;
                    break;
                case 7:
                    num7OpenLbl.Visible = false;
                    num7CloseLbl.Visible = true;
                    break;
                case 8:
                    num8OpenLbl.Visible = false;
                    num8CloseLbl.Visible = true;
                    break;
                case 9:
                    num9OpenLbl.Visible = false;
                    num9CloseLbl.Visible = true;
                    break;

            }
        }

        private void winCheck()
        {
            if (numUsed.Count == 9)
            {
                MessageBox.Show("You Win!!!!!!");
            }
        }

        private void loseCheck(int die1, int die2)
        {
            int total = die1 + die2;
            bool loseCheck = true;

            foreach (int num in numUse)
            {
                foreach (int i in numUse)
                {
                    if (num != i && (num + i) == total)
                    {
                        loseCheck = false;
                        goto EndInvoke;
                        
                    }
                }
            }

            EndInvoke:;
            if (loseCheck == true)
            {
                MessageBox.Show("You lost \nBetter luck next time.");
            }
        }

        private void reset()
        {
            numUsed.Clear();
            numUse.Clear();
            numUse.AddRange(baseList);

            num1TextBox.Text = "";
            num2TextBox.Text = "";

            die1Lbl.Text = "0";
            die2Lbl.Text = "0";

            submitBtn.Enabled = false;
            rollBtn.Enabled = true;

            num1OpenLbl.Visible = true;
            num2OpenLbl.Visible = true;
            num3OpenLbl.Visible = true;
            num4OpenLbl.Visible = true;
            num5OpenLbl.Visible = true;
            num6OpenLbl.Visible = true;
            num7OpenLbl.Visible = true;
            num8OpenLbl.Visible = true;
            num9OpenLbl.Visible = true;

            num1CloseLbl.Visible = false;
            num2CloseLbl.Visible = false;
            num3CloseLbl.Visible = false;
            num4CloseLbl.Visible = false;
            num5CloseLbl.Visible = false;
            num6CloseLbl.Visible = false;
            num7CloseLbl.Visible = false;
            num8CloseLbl.Visible = false;
            num9CloseLbl.Visible = false;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thank you for Playing");
        }
    }
}