namespace DTO
{
    public class DTO_Products
    {
        private string ID;
        private string name;
        private string quantity;
        private string type;
        private string price;
        private string color;

        public DTO_Products(string iD, string name, string quantity, string type, string price, string color)
        {
            this.ID = iD;
            this.name = name;
            this.quantity = quantity;
            this.type = type;
            this.price = price;
            this.color = color;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Type { get => type; set => type = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
