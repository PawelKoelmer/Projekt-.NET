namespace projekt.Models
{
    public class Person
    {
        ApplicationDbContext context;

        public int id {get;set;}
        public string name {get;set;}
        public string lastname{get;set;}
        public int age {get;set;}
        public GenderEnum gender {get;set;}

        

    }
}