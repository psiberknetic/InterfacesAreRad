namespace InternalLegacySystem
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}