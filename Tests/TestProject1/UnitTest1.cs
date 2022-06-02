using NUnit.Framework;
using WpfApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Do_blah ()
        {
            var blaher = new Blahberry();

            var b= new Blahable ();

            blaher.DoThing(b);
            Assert.True(b.HasBlah);
        }
    }
}