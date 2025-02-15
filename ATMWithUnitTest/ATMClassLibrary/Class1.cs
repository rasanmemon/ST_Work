namespace ATMClassLibrary
{
    public class ATM
    {
        public string BankTransaction(Params parame)
        {
            if(parame.pin == 123)
            {
                int x = 0;
                while (true)
                {
                    switch (parame.choice)
                    {
                        case 1:
                            return "Your current balance is: " + parame.amount;
                        case 2:
                            if (parame.withdraw % 100 != 0)
                            {
                                return "YOUR CURRENT BALACEN IS ABOVE 100";
                            }
                            else if (parame.withdraw > (parame.amount - 1000))
                            {
                                return "sorry insufficient balance";
                            }
                            else
                            {
                                parame.amount = parame.amount - parame.withdraw;
                                return "Your current amount now is: " + parame.amount;
                            }
                        case 3:
                            parame.amount = parame.amount + parame.deposit;
                            return "Your amount now has been deposited successfully: " + parame.amount;
                        default:
                            return "Thank You";
                    }
                }
            }
            else
            {
                return "InCorrect Pin";
            }
        }
        
    }

    public class Params
    {
        public int amount { get; set; }
        public int pin { get; set; }
        public int choice { get; set; }
        public int withdraw { get; set; }
        public int deposit { get; set; }
    }
}
