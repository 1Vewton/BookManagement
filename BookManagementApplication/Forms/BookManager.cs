using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace BookManagementApplication.Form
{
    // BookManager defines the manager for book
    public class BookManager
    {
        string fileName;
        List<StringMap> books;
        
        // Constructor initializes the BookManager class
        public BookManager(
            string fileName
        )
        {
            this.fileName = Strings.Format(
                "{0}.manager.json",
                fileName
            );
            this.books = new List<StringMap>();
        }

        // AddBook adds new book
        public void AddBook(
            string bookName,
            string path
        )
        {
            StringMap newBook = new StringMap(bookName, path);
            this.books.Add(newBook);
        }

        // RegisterBook registers new book
        public void RegisterBook(
            BookForm book
        )
        {
            book.ToFile();
            string savedFileName = book.GetFileName();
            this.AddBook(
                book.title,
                savedFileName
            );
        }

        // GetAllBooks gets all books
        public List<StringMap> GetAllBooks()
        {
            List<StringMap> newMap = new List<StringMap>(
                this.books.ToArray()
            );
            return newMap;
        }

        // GetBook gets certain book
        public BookForm? GetBook(
            string bookName
        )
        {
            string resultFilePath = "";
            for(int i = 0; i < this.books.Count; i++)
            {
                if (this.books[i].key == bookName)
                {
                    resultFilePath = this.books[i].value;
                }
            }
            if(resultFilePath.Equals(""))
            {
                return null;
            }
            BookForm resultBook = BookForm.NewBookFormFromFile(resultFilePath);
            return resultBook;
        }
    }
}