using NUnit.Framework;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "It is ClassTest1", "It is ClassTest1", "It is ClassTest2" }, 3)]
        [Ignore("Убрать после реализации метода")]
        public void Test1(string[] verificationData, int count)
        {
            // // ?[] objs = { new ?(), new ?(), new ?() };
            // string[] tempString = new string[objs.Length];
            // for (int i = 0; i < objs.Length; i++)
            // {
            //     tempString[i] = objs[i].Print();
            // }
            // Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase(new string[] { "It is ClassTest1Interface", "It is ClassTest1Interface", "It is ClassTest2Interface" }, 3)]
        [Ignore("Убрать после реализации метода")]
        public void Test2(string[] verificationData, int count)
        {
            // // ?[] objs = { new ?(), new ?(), new ?() };
            // string[] tempString = new string[objs.Length];
            // for (int i = 0; i < objs.Length; i++)
            // {
            //     tempString[i] = objs[i].PringFromInterface();
            // }
            // Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}