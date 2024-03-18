//using System;

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }

//    public Book(string title, string author, int year)
//    {
//        Title = title;
//        Author = author;
//        Year = year;
//    }
//}

//public class HomeLibrary
//{
//    private Book[] books;
//    private int count;

//    public HomeLibrary(int initialSize = 10)
//    {
//        books = new Book[initialSize];
//        count = 0;
//    }

//    public void AddBook(Book book)
//    {
//        if (count == books.Length)
//        {
//            IncreaseSize();
//        }
//        books[count++] = book;
//    }

//    private void IncreaseSize()
//    {
//        var newSize = books.Length * 2;
//        var newBooks = new Book[newSize];
//        books.CopyTo(newBooks, 0);
//        books = newBooks;
//    }

//    public bool RemoveBook(string title)
//    {
//        for (int i = 0; i < count; i++)
//        {
//            if (books[i].Title == title)
//            {
//                for (int j = i; j < count - 1; j++)
//                {
//                    books[j] = books[j + 1];
//                }
//                count--;
//                return true;
//            }
//        }
//        return false;
//    }

//    public Book[] SearchByAuthor(string author)
//    {
//        int resultCount = 0;
//        foreach (var book in books)
//        {
//            if (book != null && book.Author.Contains(author))
//            {
//                resultCount++;
//            }
//        }

//        Book[] result = new Book[resultCount];
//        int index = 0;
//        foreach (var book in books)
//        {
//            if (book != null && book.Author.Contains(author))
//            {
//                result[index++] = book;
//            }
//        }

//        return result;
//    }

//    public Book[] SearchByYear(int year)
//    {
//        int resultCount = 0;
//        foreach (var book in books)
//        {
//            if (book != null && book.Year == year)
//            {
//                resultCount++;
//            }
//        }

//        Book[] result = new Book[resultCount];
//        int index = 0;
//        foreach (var book in books)
//        {
//            if (book != null && book.Year == year)
//            {
//                result[index++] = book;
//            }
//        }

//        return result;
//    }

//    public void PrintBooks()
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"Title: {books[i].Title}, Author: {books[i].Author}, Year: {books[i].Year}");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        HomeLibrary myLibrary = new HomeLibrary();

//        myLibrary.AddBook(new Book("Pride and Prejudice", "Jane Austen", 1813));
//        myLibrary.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
//        myLibrary.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
//        myLibrary.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));

//        Console.WriteLine("Initial library contents:");
//        myLibrary.PrintBooks();

//        Console.WriteLine("\nSearching for books by 'J.R.R. Tolkien':");
//        var tolkienBooks = myLibrary.SearchByAuthor("J.R.R. Tolkien");
//        foreach (var book in tolkienBooks)
//        {
//            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
//        }

//        Console.WriteLine("\nSearching for books published in 1960:");
//        var books1960 = myLibrary.SearchByYear(1960);
//        foreach (var book in books1960)
//        {
//            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
//        }

//        Console.WriteLine("\nRemoving 'The Hobbit' from the library...");
//        if (myLibrary.RemoveBook("The Hobbit"))
//        {
//            Console.WriteLine("'The Hobbit' was removed successfully.");
//        }
//        else
//        {
//            Console.WriteLine("'The Hobbit' was not found in the library.");
//        }

//        Console.WriteLine("\nLibrary contents after removal:");
//        myLibrary.PrintBooks();

//        Console.ReadLine();
//    }
//}



