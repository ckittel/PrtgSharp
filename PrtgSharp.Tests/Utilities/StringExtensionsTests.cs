using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.Utilities;

namespace PrtgSharp.Tests.Utilities
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void When_String_Is_Under_Max_Length_Then_String_Should_Be_What_Was_Passed_In()
        {
            // Arrange / Act
            var result = "123456789".Truncate(10);

            // Assert
            result.Should().Be("123456789");
        }

        [TestMethod]
        public void When_String_Is_Max_Length_Then_String_Should_Be_What_Was_Passed_In()
        {
            // Arrange / Act
            var result = "123456789".Truncate(9);

            // Assert
            result.Should().Be("123456789");
        }

        [TestMethod]
        public void When_String_Is_Over_Max_Length_Then_String_Should_Be_Truncated()
        {
            // Arrange / Act
            var result = "12345678900".Truncate(9);

            // Assert
            result.Should().Be("123456789");
        }

        [TestMethod]
        public void Can_Truncate_To_1()
        {
            // Arrange / Act
            var result = "12345678900".Truncate(1);

            // Assert
            result.Should().Be("1");
        }

        [TestMethod]
        public void Empty_String_Returns_Empty_String()
        {
            // Arrange / Act
            var result = string.Empty.Truncate(10);

            // Assert
            result.Should().BeEmpty();
        }

        [TestMethod]
        public void Null_String_Returns_Null_String()
        {
            // Arrange
            string test = null;

            //Act
            // ReSharper disable once ExpressionIsAlwaysNull
            var result = test.Truncate(10);

            // Assert
            result.Should().BeNull();
        }

        [TestMethod]
        public void String_With_Whitespace_Is_Preseved()
        {
            // Arrange / Act
            var result = "  x    ".Truncate(5);

            // Assert
            result.Should().Be("  x  ");
        }

        [TestMethod]
        public void Truncate_To_Zero_Throws()
        {
            // Arrange / Act
            Action act = () => "x".Truncate(0);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void Truncate_To_Negative_Throws()
        {
            // Arrange / Act
            Action act = () => "x".Truncate(-1);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void Ellipsis_When_String_Is_Under_Max_Length_Then_String_Should_Be_What_Was_Passed_In()
        {
            // Arrange / Act
            var result = "123456789".TruncateWithEllipsis(10);

            // Assert
            result.Should().Be("123456789");
        }

        [TestMethod]
        public void Ellipsis_When_String_Is_Max_Length_Then_String_Should_Be_What_Was_Passed_In()
        {
            // Arrange / Act
            var result = "123456789".TruncateWithEllipsis(9);

            // Assert
            result.Should().Be("123456789");
        }

        [TestMethod]
        public void Ellipsis_When_String_Is_Over_Max_Length_Then_String_Should_Be_Truncated()
        {
            // Arrange / Act
            var result = "12345678900".TruncateWithEllipsis(9);

            // Assert
            result.Should().Be("12345678…");
        }

        [TestMethod]
        public void Ellipsis_Can_Truncate_To_2()
        {
            // Arrange / Act
            var result = "12345678900".TruncateWithEllipsis(2);

            // Assert
            result.Should().Be("1…");
        }

        [TestMethod]
        public void Ellipsis_Cannot_Truncate_To_1()
        {
            // Arrange / Act
            Action act = () => "12345678900".TruncateWithEllipsis(1);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void Ellipsis_Empty_String_Returns_Empty_String()
        {
            // Arrange / Act
            var result = string.Empty.TruncateWithEllipsis(10);

            // Assert
            result.Should().BeEmpty();
        }

        [TestMethod]
        public void Ellipsis_Null_String_Returns_Null_String()
        {
            // Arrange
            string test = null;

            //Act
            // ReSharper disable once ExpressionIsAlwaysNull
            var result = test.TruncateWithEllipsis(10);

            // Assert
            result.Should().BeNull();
        }

        [TestMethod]
        public void Ellipsis_String_With_Whitespace_Is_Preseved()
        {
            // Arrange / Act
            var result = "  x    ".TruncateWithEllipsis(5);

            // Assert
            result.Should().Be("  x …");
        }

        [TestMethod]
        public void Ellipsis_Truncate_To_Zero_Throws()
        {
            // Arrange / Act
            Action act = () => "x".TruncateWithEllipsis(0);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void Ellipsis_Truncate_To_Negative_Throws()
        {
            // Arrange / Act
            Action act = () => "x".TruncateWithEllipsis(-1);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

    }
}