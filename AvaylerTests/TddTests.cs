namespace TddTests
{
    using NUnit.Framework;
    using System.Linq;
    using TecTestAvayler;

    [TestFixture]
    public class ElementalFormsTests
    {
        [Test]
        public void Test_EmptyString_ReturnsEmptyArray()
        {
            var result = Elements.ElementalForms(string.Empty);
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_SingleElementMatch()
        {
            var result = Elements.ElementalForms("H");
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.That(result.First(), Is.EqualTo(new[] { "Hydrogen (H)" }));
        }

        [Test]
        public void Test_NoMatchFound()
        {
            var result = Elements.ElementalForms("XYZ");
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_MixedValidAndInvalidSymbols()
        {
            var result = Elements.ElementalForms("Hxyz");
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_MultipleElementMatches()
        {
            var result = Elements.ElementalForms("HeLi");
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.Contains(new[] { "Helium (He)", "Lithium (Li)" }, result);
        }

        [Test]
        public void Test_RepeatedElementSymbols()
        {
            var result = Elements.ElementalForms("HHeHe");
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.Contains(new[] { "Hydrogen (H)", "Helium (He)", "Helium (He)" }, result);
        }

        // Additional tests
        [Test]
        public void Test_MultipleCombinations_DifferentLengthSymbols()
        {
            var result = Elements.ElementalForms("snack");
            Assert.That(result.Length, Is.EqualTo(3));
            Assert.Contains(new[] { "Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)" }, result);
            Assert.Contains(new[] { "Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)" }, result);
            Assert.Contains(new[] { "Tin (Sn)", "Actinium (Ac)", "Potassium (K)" }, result);
        }

        [Test]
        public void Test_SingleCombination_MixedCase()
        {
            var result = Elements.ElementalForms("BeAcH");
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.Contains(new[] { "Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)" }, result);
        }

        [Test]
        public void Test_ThreeCharacterElements()
        {
            var result = Elements.ElementalForms("uUt");
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.Contains(new[] { "Ununtrium (Uut)" }, result);
        }
    }
}
