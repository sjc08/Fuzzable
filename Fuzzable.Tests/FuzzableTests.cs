namespace Asjc.Fuzzable.Tests
{
    [TestClass]
    public class Fuzzable
    {
        [TestMethod]
        public void CompareTo()
        {
            Fuzzable<int> i46 = new(4, 6);
            Assert.AreEqual(1, i46.CompareTo(3));
            Assert.IsTrue(i46 > 3);
            Assert.AreEqual(0, i46.CompareTo(4));
            Assert.AreEqual(-1, i46.CompareTo(6));
            Assert.IsTrue(i46 < 6);

            Assert.IsTrue(i46.Value == i46);
        }
    }
}