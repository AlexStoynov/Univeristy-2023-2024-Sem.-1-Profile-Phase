namespace Snackbar
{
    public class SnackBar
    {
        private List<Snack> snacks;
        private Snack chips;
        private Snack soda;
        private Snack candy;
        private double totalPriceAllOrders;

        public SnackBar()
        {
            snacks = new List<Snack>();
            chips = new Snack("Chips", 1.99, 20);
            snacks.Add(chips);
            soda = new Snack("Soda", 0.99, 20);
            snacks.Add(soda);
            candy = new Snack("Candy", 2.99, 20);
            snacks.Add(candy);
        }

        public double ProcessOrder(List<int> amounts)
        {
            double totalPrice = 0;
            int amountIndex = 0;
            int isEnough = 0;

            foreach (Snack snack in snacks)
            {
                if(snack.GetAmountInStock() < amounts[amountIndex])
                {
                    isEnough = -1;
                    throw new Exception($"We don't have {snack.GetName()} in stock");
                }
                amountIndex++;
            }

            amountIndex = 0;
            if (isEnough == 0)
            {
                foreach (Snack snack in snacks)
                {
                    snack.DecreaseStock(amounts[amountIndex]);
                    totalPrice += amounts[amountIndex] * snack.GetPrice();
                    amountIndex++;
                }
                totalPriceAllOrders += totalPrice;
                return totalPrice;
            }
            else
            {
                return -1;
            }
        }

        public string AddSnack(Snack snack)
        {
            if (!snacks.Contains(snack))
            {
                snacks.Add(snack);
                return $"{snack.GetName} successfully added.";
            }
            else
            {
                return $"{snack.GetName} is already added.";
            }
        }

        public double GetTotalPriceAllOrders()
        {
            return totalPriceAllOrders;
        }

        public List<Snack> GetSnacks()
        {
            return snacks;
        }

        public double GetRevenue()
        {
            return this.totalPriceAllOrders;
        }
    }
}