using NUnit.Framework;

namespace PicassoTest.Tests
{
    public class DemeritPointsTest   
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void demeritPoinst_for_minimumSpeed_is_ok()
        {

            var demerit = new DemeritPointsCalculator();

            Assert.That(demerit.CalculateDemeritPoints(65),Is.EqualTo(0));

        }

        [Test]
        public void demeritPoinst_for_less_than_minimumSpeed_is_ok()
        {

            var demerit = new DemeritPointsCalculator();

            Assert.That(demerit.CalculateDemeritPoints(60), Is.EqualTo(0));

        }

        [Test]
        public void demeritPoinst_for_minimumSpeed_not_return_0()
        {

            var demerit = new DemeritPointsCalculator();

            Assert.That(demerit.CalculateDemeritPoints(65), !Is.EqualTo(5));

        }

        [Test]
        public void demeritPoinst_for_more_than_minimumSpeed_not_return_0()
        {

            var demerit = new DemeritPointsCalculator();

            Assert.That(demerit.CalculateDemeritPoints(70), !Is.EqualTo(0));

        }

        [Test]
        public void demeritPoinst_for_speed_between_65_and_300_works()
        {

            var demerit = new DemeritPointsCalculator();

            var resultExpected = demerit.CalculateDemeritPoints(70);

            Assert.That(demerit.CalculateDemeritPoints(70), Is.EqualTo(resultExpected));

        }



    }
}