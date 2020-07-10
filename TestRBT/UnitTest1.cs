using NUnit.Framework;
using RUtil.Collections;

namespace TestRBT
{
    public class Tests
    {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestRBT() {
            var testdata = new int[] { 48, 100, 22, 57, 54, 35, 70, 81, 36, 97, 36, 60, 94, 76, 64, 51, 25, 61 };
            var rbt = new BTree<int>();
            foreach (var item in testdata)
                rbt.Insert(item);

            Assert.True(rbt.Search(36));


            //Assert.True();


            //Assert.Pass();
        }
    }
}