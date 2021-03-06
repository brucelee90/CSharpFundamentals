using System;
using Xunit;

namespace GradeBook
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new InMemoryBook("", 50.0);
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert

            Assert.Equal(76.7, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(50.0, result.Low, 1);
            Assert.Equal('C', result.Letter);
        }

        [Fact]
        public void FieldTest()
        {
            var book = new InMemoryBook("Lee's Book", 50);
            book.Name = "New Name";

            Assert.Equal("New Name", book.Name);
            Assert.Equal("3", InMemoryBook.CATEGORY);
        }

        [Fact]
        public void DiskBookTest()
        {
            var diskBook = new DiskBook("DiskBook", 50);

            var result = diskBook.GetStatistics();

            Assert.Equal(50, result.Average, 1);
            Assert.Equal(50, result.High, 1);
            Assert.Equal(50, result.Low, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
