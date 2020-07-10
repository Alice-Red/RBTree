using NUnit.Framework;
using RUtil.Collections;

namespace TestRBT
{
    public class Tests
    {

        BTree<int, string> rbt;
        [SetUp]
        public void Setup() {
            var testdata = new int[] { 48, 100, 22, 57, 54, 35, 70, 81, 36, 97, 36, 60, 94, 76, 64, 51, 25, 61 };
            rbt = new BTree<int, string>() {
                { 3, "3" },
                { 4, "4" },
                { 5, "5" },
            };


            foreach (var item in testdata)
                rbt.Insert(item, item + "");
        }

        [Test]
        public void TestRBT() {

            Assert.True(rbt.Search(36));
            Assert.True(rbt.Search(97));
            Assert.True(rbt.Search(3));
            Assert.True(rbt.Search(100));
            Assert.True(rbt.Search(94));
            Assert.False(rbt.Search(101));
            Assert.False(rbt.Search(-90));
            Assert.False(rbt.Search(1));
            Assert.False(rbt.Search(55));
            Assert.False(rbt.Search(5200));


            Assert.True(rbt.Length(36) != 0);
            Assert.True(rbt.Length(36) != 0);

            //Assert.True();


            //Assert.Pass();
        }
    }
}