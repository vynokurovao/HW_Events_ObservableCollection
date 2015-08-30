using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HW_Events
{
    public class Library : IEnumerable
    {
        private ObservableCollection<Book> _library = new ObservableCollection<Book>();

        public void registerStudent(Student student)
        {
            _library.CollectionChanged += new NotifyCollectionChangedEventHandler(student.OnBookChangeEvent);
        }

        public void AddBook(Book book)
        {
            _library.Add(book);
        }

        public Book TakeBook(Book book)
        {
            if (!_library.Contains(book))
            {
                throw new ArgumentException("There is no book with such name in the library");
            }

            _library.Remove(book);
            return book;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Book book in _library)
            {
                yield return book;
            }
        }
    }
}
