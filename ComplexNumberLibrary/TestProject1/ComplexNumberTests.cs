using ComplexNumberLibrary;

namespace TestProject1
{
    [TestFixture]
    public class ComplexNumberTests
    {
        private const double Precision = 1e-13;

        [Test]
        public void Constructor_SetsReAndImCorrectly()
        {
            var cn = new ComplexNumber(1.23, -4.56);
            Assert.That(cn.Re, Is.EqualTo(1.23).Within(Precision));
            Assert.That(cn.Im, Is.EqualTo(-4.56).Within(Precision));
        }

        [Test]
        public void Abs_CalculatesCorrectly()
        {
            var cn = new ComplexNumber(3, 4);
            Assert.That(cn.Abs, Is.EqualTo(5.0).Within(Precision));

            var cn2 = new ComplexNumber(-1, 0);
            Assert.That(cn2.Abs, Is.EqualTo(1.0).Within(Precision));

            var cn3 = new ComplexNumber(0, -2.5);
            Assert.That(cn3.Abs, Is.EqualTo(2.5).Within(Precision));

            var cn4 = new ComplexNumber(0, 0);
            Assert.That(cn4.Abs, Is.EqualTo(0.0).Within(Precision));
        }

        [TestCase(0, 0, "0")]
        [TestCase(3.14, 0, "3,14")]
        [TestCase(-2.5, 0, "-2,5")]
        [TestCase(0, 1, "i")]
        [TestCase(0, -1, "-i")]
        [TestCase(0, 5.5, "5,5i")]
        [TestCase(0, -2.7, "-2,7i")]
        [TestCase(1.2, 3.4, "1,2+3,4i")]
        [TestCase(-2.5, 3.45, "-2,5+3,45i")]
        [TestCase(1.2, -4, "1,2-4i")]
        [TestCase(7, 1, "7+i")]
        [TestCase(-6, -1, "-6-i")]
        [TestCase(1.0000000000001, 2.0000000000002, "1,0000000000001+2,0000000000002i")]
        public void ToString_FormatsCorrectly(double re, double im, string expected)
        {
            var cn = new ComplexNumber(re, im);
            Assert.That(cn.ToString(), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_NullObject_ThrowsArgumentException()
        {
            var cn1 = new ComplexNumber(1, 1);
            Assert.Throws<ArgumentException>(() => cn1.Equals(null));
        }

        [Test]
        public void Equals_DifferentType_ThrowsArgumentException()
        {
            var cn = new ComplexNumber(1, 1);
            var obj = new object();
            Assert.Throws<ArgumentException>(() => cn.Equals(obj));
        }

        [TestCase(1.0, 2.0, 1.0, 2.0, true)]
        [TestCase(1.0, 2.0, 1.00000000000001, 2.00000000000002, true)]
        [TestCase(0.1 + 0.2, 0.3, 0.3, 0.3, true)]
        [TestCase(1.0, 2.0, 1.0, 3.0, false)]
        [TestCase(1.0, 2.0, 2.0, 2.0, false)]
        [TestCase(1.0001, 2.0, 1.0, 2.0, false)]
        public void Equals_ComplexNumbers_ReturnsExpected(double re1, double im1, double re2, double im2, bool expected)
        {
            var cn1 = new ComplexNumber(re1, im1);
            var cn2 = new ComplexNumber(re2, im2);
            Assert.That(cn1.Equals(cn2), Is.EqualTo(expected));
        }

        [Test]
        public void GetHashCode_ForEqualObjects_ReturnsSameHashCode()
        {
            var cn1 = new ComplexNumber(1.2345678912345, 2.3456789123456);
            var cn2 = new ComplexNumber(1.234567891234500001, 2.345678912345600002);

            Assert.That(cn1.Equals(cn2), Is.True, "cn1 и cn2 должны быть равны");
            Assert.That(cn1.GetHashCode(), Is.EqualTo(cn2.GetHashCode()));
        }

        [Test]
        public void GetHashCode_ForDifferentObjects_LikelyReturnsDifferentHashCodes()
        {
            var cn1 = new ComplexNumber(1.0, 2.0);
            var cn2 = new ComplexNumber(2.0, 1.0);
            Assert.That(cn1.Equals(cn2), Is.False, "cn1 и cn2 не должны быть равны");
            Assert.That(cn1.GetHashCode(), Is.Not.EqualTo(cn2.GetHashCode()));
        }

        [Test]
        public void Operator_Equals_ComparesCorrectly()
        {
            var cn1 = new ComplexNumber(1.0, 2.0);
            var cn2 = new ComplexNumber(1.0, 2.0);
            var cn3 = new ComplexNumber(1.00000000000001, 2.00000000000002);
            var cn4 = new ComplexNumber(3.0, 4.0);

            Assert.That(cn1 == cn2, Is.True);
            Assert.That(cn1 == cn3, Is.True);
            Assert.That(cn1 == cn4, Is.False);
        }

        [Test]
        public void Operator_NotEquals_ComparesCorrectly()
        {
            var cn1 = new ComplexNumber(1.0, 2.0);
            var cn2 = new ComplexNumber(1.0, 2.0);
            var cn3 = new ComplexNumber(3.0, 4.0);

            Assert.That(cn1 != cn2, Is.False);
            Assert.That(cn1 != cn3, Is.True);
        }

        [Test]
        public void Operator_Add_AddsCorrectly()
        {
            var cn1 = new ComplexNumber(1.5, 2.5);
            var cn2 = new ComplexNumber(0.5, -1.0);
            var expected = new ComplexNumber(2.0, 1.5);
            var result = cn1 + cn2;

            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Precision));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Precision));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Operator_Subtract_SubtractsCorrectly()
        {
            var cn1 = new ComplexNumber(1.5, 2.5);
            var cn2 = new ComplexNumber(0.5, -1.0);
            var expected = new ComplexNumber(1.0, 3.5);
            var result = cn1 - cn2;

            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Precision));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Precision));
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}