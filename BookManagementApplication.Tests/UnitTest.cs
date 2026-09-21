using BookManagementApplication.Form;

namespace BookManagementApplication.Tests
{
    // UnitTestBookForm contains unit test for book form
    public class UnitTestBookForm
    {
        [Fact]
        // ToJSON tests read and load of books
        public void TestToJSON()
        {
            BookForm NewBook = new BookForm(
                "test",
                10,
                "N/A"
            );
            NewBook.ToFile();
            string fileName = NewBook.GetFileName();
            BookForm reloadedBook = BookForm.NewBookFormFromFile(
                fileName
            );
            bool equals = NewBook.Equals(reloadedBook);
            Assert.True(
                equals, 
                string.Format(
                    "{0} is not the same as {1}",
                    NewBook.ToString(),
                    reloadedBook.ToString()
                )
            );
        }

        [Fact]
        public void TestManager()
        {
            BookForm NewBook = new BookForm(
                "test",
                10,
                "N/A"
            );
            BookManager manager = new BookManager(
                "books"
            );
            manager.RegisterBook(NewBook);
            BookForm? Fetched = manager.GetBook("test");
            Assert.NotNull(
                Fetched
            );
        }
    }
}
