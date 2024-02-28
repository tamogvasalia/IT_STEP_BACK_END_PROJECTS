namespace BookManagmentSystemApp.Entities
{
    public class Author:AbstractEntity
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }
        public Author():base()
        {
                
        }

        public Author(string id,string name, string surname):base(id)
        {
            this.Name = name;
            this.Surname = surname;

        }

        public override string ToString()
        {
            return $"{base.ToString()}Name:{Name};Surname:{Surname}";
        }
    }
}
