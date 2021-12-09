using System;
using Xunit;

namespace GradeBook
{
    public class TypeTests
    {
        public delegate string WriteLogDelegate(string logMessage);

        [Fact]
        public void PointToDelegateMethod()
        {
            WriteLogDelegate log;
            log = ReturnMessage;
            var logMessage = log("servus");
            Assert.Equal("servus", logMessage);
        }

        public string ReturnMessage(string log)
        {
            return log;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }
        [Fact]
        public void TwoVarsReferenceSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act

            // assert
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            var book = new InMemoryBook(name, 0.0);
            return book;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book = GetBook("Book 1");
            SetName(book, "New Name");

            Assert.Equal("New Name", book.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book = GetBook("Book 1");
            GetBookSetName(book, "New Name");

            Assert.Equal("Book 1", book.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new InMemoryBook(name, 0.0);
        }

        [Fact]
        public void CSharpPassByRef()
        {
            var book = GetBook("Book 1");
            GetBookSetName(ref book, "New Name");

            Assert.Equal("New Name", book.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new InMemoryBook(name, 0.0);
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            var y = GetInt();

            SetInt(ref y);

            Assert.Equal(3, x);
            Assert.Equal(42, y);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }
    }
}
