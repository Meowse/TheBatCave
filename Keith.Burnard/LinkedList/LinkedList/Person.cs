namespace LinkedList
{
    public class Person
    {
        public int Age { get; set; }
        public int Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
