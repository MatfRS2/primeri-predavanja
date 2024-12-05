namespace RS2.LambdaExpressionInInterface
{
    public class Artikal
    {
        private string name;
        private decimal cost;

        public Artikal(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => cost;
            set => cost = value;
        }       
    }
}