namespace LibraryData.Models
{
    public class Patron
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public string Telephone   { get; set; }


        public virtual LibraryCard LibraryCard {get; set;}
        
        
    }
}