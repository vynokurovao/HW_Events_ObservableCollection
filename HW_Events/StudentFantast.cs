using System;
using System.Collections.Specialized;

namespace HW_Events
{
    public class StudentFantast : Student
    {
        public override void OnBookChangeEvent(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Book book in e.NewItems)
                {
                    if (book.Genre.Equals("fantasy"))
                    {
                        Console.WriteLine("The fantasy-lover ordered this book with a delivery");
                    }
                    else
                    {
                        Console.WriteLine("The fantasy-lover will not read this book");
                    }
                }
            }
        }
    }
}
