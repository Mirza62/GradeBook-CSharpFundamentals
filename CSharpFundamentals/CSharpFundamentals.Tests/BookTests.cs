using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrades()
        {
            ////arrange 1st section  put test data that we are going to use
            //var x = 5;
            //var y = 2;
            //var expected = 7;
            var book = new Book(" ");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            ////act 2nd section invoke a method to perform computation or process that it produces the result.
            //var actual = x + y;
            var result = book.GetStatistics();


            ////assert 3rd section here we assert something about the value computed inside of act. 
            //Assert.Equal(expected, actual);
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
