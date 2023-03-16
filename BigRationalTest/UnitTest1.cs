using BigRationalLib;
using System.Numerics;


namespace BigRationalTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1,2)]
        [DataRow(2,3)]
        [DataRow(0,1)]
        public void TestTest_Ctor_2args(int a, int b)
        {
            var u = new BigRational(a, b);
            Assert.AreEqual(a, u.Numerator);
            Assert.AreEqual(b, u.Denominator);  
        }
        [DataTestMethod]
        [DataRow(1, -2, -1, 2)]
        [DataRow(-2, 3, -2, 3)]
        [DataRow(-1, -2, 1, 2)]
        [DataRow(1, 2, 1, 2)]
        [DataRow(0, -1, 0, 1)]
      

     
        public void TestTest_Ctor_SingNormalize(int a, int b, int x, int y )
        {
            var u = new BigRational(a, b);
            Assert.AreEqual(x, u.Numerator);
            Assert.AreEqual(y, u.Denominator);
        }
        [DataTestMethod]
        [DataRow(2,4,1,2)]
        [DataRow(2,2,1,1)]
        [DataRow(1,2,1,2)]
        public void TestTest_Ctor_Reduction(int a, int b, int x, int y)
        {
            var u = new BigRational(a, b);
            Assert.AreEqual(x, u.Numerator);
            Assert.AreEqual(y, u.Denominator);
        }
        [DataTestMethod]
        [DataRow(0,1,0,1)]
        [DataRow(0,2,0,1)]
        [DataRow(0,-2,0,1)]
        [DataRow(-0,-2,0,1)]
        public void TestTest_Ctor_ZeeroBuOne(int a, int b, int x, int y)
        {
            var u = new BigRational(a, b);
            Assert.AreEqual(x, u.Numerator);
            Assert.AreEqual(y, u.Denominator);
        }
    }
}