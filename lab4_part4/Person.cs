namespace lab4_part4
{
    public class Person
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public Person(string name, string phone, string email, string address)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
        
    }
}