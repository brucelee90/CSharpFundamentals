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
            var book = new Book("", 5.0);
            book.AddGrade(1.0);
            book.AddGrade(2.0);
            book.AddGrade(3.0);

            // act
            var result = book.GetStatistics();

            // assert

            Assert.Equal(2.75, result.Average);
            Assert.Equal(5.0, result.High);
            Assert.Equal(1.0, result.Low);


        }
    }
}
