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
            var rbt = new BTree<string>();
            rbt.Insert("");
            rbt.Search("");


            //Assert.True();


            //Assert.Pass();
        }
    }
}