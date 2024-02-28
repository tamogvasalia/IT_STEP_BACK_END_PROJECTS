using BookManagmentSystemApp.Entities;

namespace BookManagmentSystemApp.Helper
{
    public static  class InputHelper
    {
        public static Book ReadBook(string header, bool ident = false)
        {
            if(ident)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" ATTENTION! we identify Books Using Caption. ATTENTION!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine( header);
            Author auth = new Author();
            Console.WriteLine("enter Author Name");
            string? Name = Console.ReadLine();
            Console.WriteLine("enter Author Surname");
            string? Surname = Console.ReadLine();
            auth.Name = Name;
            auth.Surname = Surname;
            Console.WriteLine("Enter Caption");
            string caption = Console.ReadLine();
            Book bks = new Book()
            { 
            author = auth,
            RelaseDate=DateTime.Now,
            Caption=caption,
            };
            Console.ResetColor();
            return bks;
        }

        public static string ReadDateforidentity(string capt,bool optional=false)
        {
            
            if (optional)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Attention!!!  you are  going to delete  book From Db :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.WriteLine(capt);
            string caption = Console.ReadLine();
            Console.ResetColor();
            return caption;
        }

    }
}
