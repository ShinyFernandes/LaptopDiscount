using LaptopDiscount;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopDiscountTest
{
   public class Program
    {
        static void Main(string[] args)
        {
        }
        public class EmployeeDiscountTests
        {
            [Test]
            public void CalculateDiscountedPrice_PartTime_NoDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartTime,
                    Price = 1000m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(1000m));
            }

            [Test]
            public void CalculateDiscountedPrice_PartialLoad_5PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartialLoad,
                    Price = 1000m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(950m));
            }

            [Test]
            public void CalculateDiscountedPrice_FullTime_10PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.FullTime,
                    Price = 1000m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(900m));
            }

            [Test]
            public void CalculateDiscountedPrice_CompanyPurchasing_20PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.CompanyPurchasing,
                    Price = 1000m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(800m));
            }

            [Test]
            public void CalculateDiscountedPrice_NegativePrice_ShouldReturnZero()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.FullTime,
                    Price = -1000m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(0m));
            }

            [Test]
            public void CalculateDiscountedPrice_ZeroPrice_ShouldReturnZero()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartTime,
                    Price = 0m
                };

                // Act
                var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(discountedPrice, Is.EqualTo(0m));
            }
        }
    }
}