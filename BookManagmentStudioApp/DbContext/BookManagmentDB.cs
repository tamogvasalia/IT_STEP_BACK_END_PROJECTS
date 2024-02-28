using BookManagmentSystemApp.Entities;

namespace BookManagmentSystemApp.DbContext
{
    public class BookManagmentDB
    {
        private List<Book> books;
        public BookManagmentDB()
        {
            books = new List<Book>();
            GenerateRandomData();
        }
        private void GenerateRandomData()
        {
            Random age = new Random();
            for (int i = 0; i < 10; i++)
            {
                Author auth = new Author()
                {
                    Name = Faker.Name.First(),
                    Surname = Faker.Name.Last(),
                };
                Book book = new Book()
                {
                    RelaseDate = DateTime.Now.AddYears(-age.Next(10, 200)),
                    author = auth,
                    Caption = Faker.Company.Name(),
                };
                books.Add(book);
            }
        }
        public List<Book> GetContext()
        {
            return books;
        }
    }
}
