using BookManagmentSystemApp.DbContext;
using BookManagmentSystemApp.Interfaces;

namespace BookManagmentSystemApp.Controller
{
    public class BookManagmentController
    {
        private readonly IbookManagment manage;

        public BookManagmentController()
        {
            BookManagmentDB Db = new BookManagmentDB();
            manage = new BookManagmentServices.BookManagmentSystem(Db);
        }

        public void Addbook()
        {
            var book = Helper.InputHelper.ReadBook("Let's Add new Book TO DB");
            manage.Addbook(book);
        }

        public void EditBook()
        {
            var book = Helper.InputHelper.ReadBook("Let's update data , enter the details", true);
            manage.EditBook(book);
        }

        public void GetAllBooks()
        {
            var res = manage.GetAllBooks();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            res.ForEach(io => { Console.WriteLine(io); });
            Console.ResetColor();
        }

        public void SearchUsingCaption()
        {
            var name = Helper.InputHelper.ReadDateforidentity("enter book caption To search");
            var book = manage.SearchUsingCaption(name);
            Console.WriteLine(book);
        }

        public void DeleteById()
        {
            var ID = Helper.InputHelper.ReadDateforidentity("Enter BOok ID for Delete!", true);
            manage.DeleteById(ID);
        }

        public void Exit()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hope  You Liked, Our APP, if you wonder, please Give US feadback.");
            Console.ResetColor();
        }
    }
}
