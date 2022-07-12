namespace Bowling
{
    public class Tests
    {
        private Solver Solver;
        [SetUp]
        public void Setup()
        {
            Solver = new Solver();
        }

        [Test]
        public void Test1()
        {
            Assert.That(Solver.Score(new char[] { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' }), Is.EqualTo(300) );

            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.That(Solver.Score(new char[] { '9', '-', '9', '-', '9', '-', '9', '-', '9', '-', '9', '-', '9', '-', '9', '-', '9', '-', '9', '-' }),Is.EqualTo(90));
        }
        [Test]
        public void Test3()
        {
            Assert.That(Solver.Score(new char[] { '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5', '/', '5' }), Is.EqualTo(150));
        }
    }
}