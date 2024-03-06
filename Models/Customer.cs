namespace myFirstWebAPI.Models
{
    public class Customer
    {
        private int _id;

        private string _name = string.Empty;

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public string Name 
        {
            get { return _name; }

            set { _name = value; }
        }
       
    }
}
