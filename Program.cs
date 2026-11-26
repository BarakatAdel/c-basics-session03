namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int pages = 464;
                bool isAvilable = true;
                if (pages > 300 && isAvilable)
                {
                    Console.WriteLine("You can borrow this book");
                }
                Console.WriteLine("enter title");
                string title = Console.ReadLine();
                switch (title.ToLower())
                {
                    case "clean code":
                        Console.WriteLine("Great choice!");
                        break;
                    case "refactoring":
                        Console.WriteLine("Nice pick!");
                        break;
                    default:
                        Console.WriteLine("Never heard of it");
                        break;
                }
                string resutl = pages > 300 ? "Long Book" : "Short Book";
                Console.WriteLine(resutl);
                string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

                Console.WriteLine("By using For loop");
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] == "Refactoring")
                    {
                        break;
                    }
                    else if (books[i] == "The Pragmatic Programmer")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(books[i]);
                    }

                }
                Console.WriteLine("By using while loop");
                int index = 0;
                while (index < books.Length)
                {
                    if (books[index] == "Refactoring")
                    {
                        break;
                    }
                    else if (books[index] == "The Pragmatic Programmer")
                    {
                        index++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(books[index]);
                    }

                    index++;
                }
                Console.WriteLine("By using Do while loop");
                int j = 0;
                do
                {
                    if (books[j] == "Refactoring")
                    {
                        break;


                    }

                    else if (books[j] == "The Pragmatic Programmer")
                    {
                        j++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(books[j]);
                    }
                    j++;
                } while (j < books.Length);
                Console.WriteLine("By using Foreach loop");
                foreach (var book in books)
                {
                    if (book == "Refactoring")
                    {
                        break;
                    }
                    else if (book == "The Pragmatic Programmer")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(book);
                    }
                }


                PrintFirstBook(books);


            }
            public static void PrintFirstBook(string[] arr)
            {


                if (arr.Length == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine(arr[0]);
                }
            }

        }
    
}
