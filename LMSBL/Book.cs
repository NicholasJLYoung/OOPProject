using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Book : IBorrowable, INotifyPropertyChanged
    {
        private bool isavailable = true;
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable 
        {
            get
            {
                return this.isavailable;
            }

            set
            {
                this.isavailable = value;
                NotifyPropertyChanged();
            }
        }
        public int? BorrowedBy { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} Available: {IsAvailable}";
        }
        public override bool Equals(object? obj)
        {
            if (this.Title == ((Book)obj).Title && this.Author == ((Book)obj).Author && this.IsAvailable == (obj as Book).IsAvailable && this.BorrowedBy == (obj as Book).BorrowedBy)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public static bool operator == (Book left, Book right)
        {
            return left.Title.Equals(right.Title);
        }
        public static bool operator != (Book left, Book right)
        {
            return !left.Title.Equals(right.Title);
        }
    }
}
