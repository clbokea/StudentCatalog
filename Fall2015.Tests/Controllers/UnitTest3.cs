using System;
using System.Collections.Generic;
using System.Linq;
using Fall2015.TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fall2015.Tests.Controllers
{
   
    [TestClass]
    public class UnitTest3
    {
        //Arrange
        OurTimeSpan our1 = new OurTimeSpan
        {
            FromTime = new DateTime(2015, 1, 1, 12, 0, 0),
            ToTime = new DateTime(2015, 1, 1, 13, 30, 0)
        };


        [TestMethod]
        public void TestLINQ3()
        {
            int[] numbers = { 5, 9, 1, 3, 4, 8, 6, 7, 2, 0 };



            var allButFirst4Numbers = numbers.Where(a => a < 9).Skip(3).Take(4);



            Console.WriteLine("All but first 4 numbers:");

            foreach (var n in allButFirst4Numbers)

            {

                Console.WriteLine(n);

            }
        }

        [TestMethod]
        public void TestLINQ2()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords =
                from w in words
                select new { Upper = w.ToUpper(), Lower = w.ToLower() };
            

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }

        [TestMethod]
        public void TestLINQ1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            IEnumerable<int> lowNums =
                from n in numbers
                where n < 1
                select n;

            var nums2 = numbers.Where(a => a < 5);


            Console.WriteLine("Numbers < 1:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }


        [TestMethod]
        //[ExpectedException(typeof(ArgumentException),
        //"Some message")]
        public void TestMethod1()
        {
            OurTimeSpan our2 = new OurTimeSpan {
                FromTime = new DateTime(2015, 1, 1, 10, 0, 0),
                ToTime = new DateTime(2015,1,1, 11,0,0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsFalse(result);

        }

        
        [TestMethod]
        public void TestMethod2()
        {
            OurTimeSpan our2 = new OurTimeSpan
            {
                FromTime = new DateTime(2015, 1, 1, 12, 0, 0),
                ToTime = new DateTime(2015, 1, 1, 13, 30, 0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestMethod3()
        {
            OurTimeSpan our2 = new OurTimeSpan
            {
                FromTime = new DateTime(2015, 1, 1, 10, 0, 0),
                ToTime = new DateTime(2015, 1, 1, 12, 15, 0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            OurTimeSpan our2 = new OurTimeSpan
            {
                FromTime = new DateTime(2015, 1, 1, 12, 15, 0),
                ToTime = new DateTime(2015, 1, 1, 13, 15, 0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            OurTimeSpan our2 = new OurTimeSpan
            {
                FromTime = new DateTime(2015, 1, 1, 10, 0, 0),
                ToTime = new DateTime(2015, 1, 1, 14, 0, 0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            OurTimeSpan our2 = new OurTimeSpan
            {
                FromTime = new DateTime(2015, 1, 1, 13, 0, 0),
                ToTime = new DateTime(2015, 1, 1, 14, 0, 0)
            };

            Boolean result = our1.Overlap(our2);

            Assert.IsTrue(result);
        }
    }
}
