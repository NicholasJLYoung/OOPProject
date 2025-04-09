using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} Available: {IsAvailable}";
        }
        public override bool Equals(object? obj)
        {
            return this.Equals(obj);
        }
        public void Borrow(User u)
        {
            IsAvailable = false;
            Debug.WriteLine($"{u.Name} has borrowed {Title}");
        }
        public void Return(User u)
        {
            IsAvailable = true;
            Debug.WriteLine($"{u.Name} has returned {Title}");
        }
        public static bool operator ==(Book left, Book right)
        {
            return left.Title.Equals(right.Title);
        }
        public static bool operator !=(Book left, Book right)
        {
            return !left.Title.Equals(right.Title);
        }
    }
}
