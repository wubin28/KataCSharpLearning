using NUnit.Framework;

namespace Com.Wubinben.Kata.CSharpLearning
{
    [TestFixture]
    public class StaticConstructorAndFieldInitializationOrderTest
    {
        [Test]
        public void StaticFieldInitializersRunInTheOrderInWhichTheFieldsAreDeclared()
        {
            // Given
            // When
            // Then
            Assert.AreEqual(0, StaticFieldOrder.X, "Failure - the static field X should be 0.");
        }
    }
}
