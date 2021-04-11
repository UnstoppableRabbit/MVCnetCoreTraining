namespace dontTrustMe.Models
{
    public class Yummy
    {
        private int id;
        private string name;
        private decimal price;
        private string description;
        private string img;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Desc
        {
            get { return description; }
            set { description = value; }
        }
        public string Img 
        {
            get { return img; }
            set { img = value; }
        }
    }
}
