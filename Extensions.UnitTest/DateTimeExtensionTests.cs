﻿using System;
using System.Linq;
using Xunit;
using Extension.Methods;

namespace Extensions.UnitTest
{
    public class DateTimeExtensionTests
    {
        #region DateTimeExtensions.ToMMDDYY

        [Fact]
        public void ToMMDDYY_WithoutSeparator_ShouldPass()
        {
            var expected = "09/24/2019";

            var dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToMMDDYY();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToMMDDYY_WithSeparator_ShouldPass()
        {
            var expected = "09-24-2019";

            var dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToMMDDYY('-');

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToMMDDYY_ForNullableDateTime_WithoutSeparator_ShouldPass()
        {
            var expected = string.Empty;

            DateTime? dateTime = null;
            var actual = dateTime.ToMMDDYY();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToMMDDYY_ForNullableDateTime_WithSeparator_ShouldPass()
        {
            var expected = "09-24-2019";

            DateTime? dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToMMDDYY('-');

            Assert.Equal(actual, expected);
        }

        #endregion


        #region DateTimeExtensions.ToDDMMYY

        [Fact]
        public void ToDDMMYY_WithoutSeparator_ShouldPass()
        {
            var expected = "24/09/2019";

            var dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToDDMMYY();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToDDMMYY_WithSeparator_ShouldPass()
        {
            var expected = "24-09-2019";

            var dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToDDMMYY('-');

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToDDMMYY_ForNullableDateTime_WithoutSeparator_ShouldPass()
        {
            var expected = string.Empty;

            DateTime? dateTime = null;
            var actual = dateTime.ToDDMMYY();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ToDDMMYY_ForNullableDateTime_WithSeparator_ShouldPass()
        {
            var expected = "24-09-2019";

            DateTime? dateTime = new DateTime(2019, 09, 24);
            var actual = dateTime.ToDDMMYY('-');

            Assert.Equal(actual, expected);
        }

        #endregion
    }
}
