using System;
using System.Collections.Generic;
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
        public bool IsAvailable { get; set; }
        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} Available: {IsAvailable}";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public void Borrow()
        {
            IsAvailable = false;
        }
        public void Return()
        {
            IsAvailable = true;
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
