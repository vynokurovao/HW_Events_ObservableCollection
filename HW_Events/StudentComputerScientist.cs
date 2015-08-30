using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    public class StudentComputerScientist : Student
    {
        public override void OnBookChangeEvent(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Book book in e.NewItems)
                {
                    if (book.Genre.Equals("computer science"))
                    {
                        Console.WriteLine("The computer scientist is going to the library to take this book");
                    }
                }
            }
        }
    }
}
