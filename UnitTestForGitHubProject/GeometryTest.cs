using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProjectForGitHub;

namespace UnitTestForGitHubProject
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPerimetr_3and5_16returned()
        {
            int a = 3;
            int b = 5;
            int expected = 16;

            Geometry g = new Geometry();
            int actual = g.GetPerimeter(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStatistic_2and7()
        {
            int a = 2;
            int b = 7;
            string expected = "Периметр = 18, площадь = 14";

            Geometry g = new Geometry();
            string actual = g.GetStatistic(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
