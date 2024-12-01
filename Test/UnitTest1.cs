using ClassLibrary;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(classofliblary.z_func1(5,6,9), 62.05104446411133);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(classofliblary.z_func2(1, 1, 1), 4);
        }
    }
}