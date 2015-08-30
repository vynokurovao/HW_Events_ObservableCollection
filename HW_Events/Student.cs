using System;
using System.Collections.Specialized;

namespace HW_Events
{
    public abstract class Student
    {
        public abstract void OnBookChangeEvent(object sender, NotifyCollectionChangedEventArgs e);
    }
}
