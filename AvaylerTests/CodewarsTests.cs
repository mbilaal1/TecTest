namespace SolutionTests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using TecTestAvayler;

    [TestFixture, Description("Basic Coverage")]
    class BasicCoverage
    {
        [Test, Description("Works with empty string")]
        public void EmptyString()
        {
            Assert.That(Elements.ElementalForms(""), Is.EqualTo(new string[0][]));
        }

        [Test, Description("Works with non-elemental words")]
        public void NonElements()
        {
            var cases = new[] { "z", "27", " ", "   ", "!!!", "apple", "codewars", "foo bar", " a b c " };
            foreach (var word in cases)
            {
                Assert.That(Elements.ElementalForms(word), Is.EqualTo(new string[0][]));
            }
        }

        [Test, Description("Works with each element in the periodic table")]
        public void EveryElementInPeriodicTable()
        {
            var cases = new[] {
                ("H", new[] { new[] {"Hydrogen (H)"}}),
                ("He", new[] { new[] {"Helium (He)"}}),
                ("Li", new[] { new[] {"Lithium (Li)"}}),
                ("Be", new[] { new[] {"Beryllium (Be)"}}),
                ("B", new[] { new[] {"Boron (B)"}}),
                ("C", new[] { new[] {"Carbon (C)"}}),
                ("N", new[] { new[] {"Nitrogen (N)"}}),
                ("O", new[] { new[] {"Oxygen (O)"}}),
                ("F", new[] { new[] {"Fluorine (F)"}}),
                ("Ne", new[] { new[] {"Neon (Ne)"}}),
                ("Na", new[] { new[] {"Sodium (Na)"}}),
                ("Mg", new[] { new[] {"Magnesium (Mg)"}}),
                ("Al", new[] { new[] {"Aluminium (Al)"}}),
                ("Si", new[] { new[] {"Silicon (Si)"}, new[] {"Sulfur (S)", "Iodine (I)"}}),
                ("P", new[] { new[] {"Phosphorus (P)"}}),
                ("S", new[] { new[] {"Sulfur (S)"}}),
                ("Cl", new[] { new[] {"Chlorine (Cl)"}}),
                ("Ar", new[] { new[] {"Argon (Ar)"}}),
                ("K", new[] { new[] {"Potassium (K)"}}),
                ("Ca", new[] { new[] {"Calcium (Ca)"}}),
                ("Sc", new[] { new[] {"Scandium (Sc)"}, new[] {"Sulfur (S)", "Carbon (C)"}}),
                ("Ti", new[] { new[] {"Titanium (Ti)"}}),
                ("V", new[] { new[] {"Vanadium (V)"}}),
                ("Cr", new[] { new[] {"Chromium (Cr)"}}),
                ("Mn", new[] { new[] {"Manganese (Mn)"}}),
                ("Fe", new[] { new[] {"Iron (Fe)"}}),
                ("Co", new[] { new[] {"Carbon (C)", "Oxygen (O)"}, new[] {"Cobalt (Co)"}}),
                ("Ni", new[] { new[] {"Nickel (Ni)"}, new[] {"Nitrogen (N)", "Iodine (I)"}}),
                ("Cu", new[] { new[] {"Carbon (C)", "Uranium (U)"}, new[] {"Copper (Cu)"}}),
                ("Zn", new[] { new[] {"Zinc (Zn)"}}),
                ("Ga", new[] { new[] {"Gallium (Ga)"}}),
                ("Ge", new[] { new[] {"Germanium (Ge)"}}),
                ("As", new[] { new[] {"Arsenic (As)"}}),
                ("Se", new[] { new[] {"Selenium (Se)"}}),
                ("Br", new[] { new[] {"Bromine (Br)"}}),
                ("Kr", new[] { new[] {"Krypton (Kr)"}}),
                ("Rb", new[] { new[] {"Rubidium (Rb)"}}),
                ("Sr", new[] { new[] {"Strontium (Sr)"}}),
                ("Y", new[] { new[] {"Yttrium (Y)"}}),
                ("Zr", new[] { new[] {"Zirconium (Zr)"}}),
                ("Nb", new[] { new[] {"Niobium (Nb)"}, new[] {"Nitrogen (N)", "Boron (B)"}}),
                ("Mo", new[] { new[] {"Molybdenum (Mo)"}}),
                ("Tc", new[] { new[] {"Technetium (Tc)"}}),
                ("Ru", new[] { new[] {"Ruthenium (Ru)"}}),
                ("Rh", new[] { new[] {"Rhodium (Rh)"}}),
                ("Pd", new[] { new[] {"Palladium (Pd)"}}),
                ("Ag", new[] { new[] {"Silver (Ag)"}}),
                ("Cd", new[] { new[] {"Cadmium (Cd)"}}),
                ("In", new[] { new[] {"Indium (In)"}, new[] {"Iodine (I)", "Nitrogen (N)"}}),
                ("Sn", new[] { new[] {"Sulfur (S)", "Nitrogen (N)"}, new[] {"Tin (Sn)"}}),
                ("Sb", new[] { new[] {"Antimony (Sb)"}, new[] {"Sulfur (S)", "Boron (B)"}}),
                ("Te", new[] { new[] {"Tellurium (Te)"}}),
                ("I", new[] { new[] {"Iodine (I)"}}),
                ("Xe", new[] { new[] {"Xenon (Xe)"}}),
                ("Cs", new[] { new[] {"Caesium (Cs)"}, new[] {"Carbon (C)", "Sulfur (S)"}}),
                ("Ba", new[] { new[] {"Barium (Ba)"}}),
                ("La", new[] { new[] {"Lanthanum (La)"}}),
                ("Ce", new[] { new[] {"Cerium (Ce)"}}),
                ("Pr", new[] { new[] {"Praseodymium (Pr)"}}),
                ("Nd", new[] { new[] {"Neodymium (Nd)"}}),
                ("Pm", new[] { new[] {"Promethium (Pm)"}}),
                ("Sm", new[] { new[] {"Samarium (Sm)"}}),
                ("Eu", new[] { new[] {"Europium (Eu)"}}),
                ("Gd", new[] { new[] {"Gadolinium (Gd)"}}),
                ("Tb", new[] { new[] {"Terbium (Tb)"}}),
                ("Dy", new[] { new[] {"Dysprosium (Dy)"}}),
                ("Ho", new[] { new[] {"Holmium (Ho)"}, new[] {"Hydrogen (H)", "Oxygen (O)"}}),
                ("Er", new[] { new[] {"Erbium (Er)"}}),
                ("Tm", new[] { new[] {"Thulium (Tm)"}}),
                ("Yb", new[] { new[] {"Ytterbium (Yb)"}, new[] {"Yttrium (Y)", "Boron (B)"}}),
                ("Lu", new[] { new[] {"Lutetium (Lu)"}}),
                ("Hf", new[] { new[] {"Hafnium (Hf)"}, new[] {"Hydrogen (H)", "Fluorine (F)"}}),
                ("Ta", new[] { new[] {"Tantalum (Ta)"}}),
                ("W", new[] { new[] {"Tungsten (W)"}}),
                ("Re", new[] { new[] {"Rhenium (Re)"}}),
                ("Os", new[] { new[] {"Osmium (Os)"}, new[] {"Oxygen (O)", "Sulfur (S)"}}),
                ("Ir", new[] { new[] {"Iridium (Ir)"}}),
                ("Pt", new[] { new[] {"Platinum (Pt)"}}),
                ("Au", new[] { new[] {"Gold (Au)"}}),
                ("Hg", new[] { new[] {"Mercury (Hg)"}}),
                ("Tl", new[] { new[] {"Thallium (Tl)"}}),
                ("Pb", new[] { new[] {"Lead (Pb)"}, new[] {"Phosphorus (P)", "Boron (B)"}}),
                ("Bi", new[] { new[] {"Bismuth (Bi)"}, new[] {"Boron (B)", "Iodine (I)"}}),
                ("Po", new[] { new[] {"Phosphorus (P)", "Oxygen (O)"}, new[] {"Polonium (Po)"}}),
                ("At", new[] { new[] {"Astatine (At)"}}),
                ("Rn", new[] { new[] {"Radon (Rn)"}}),
                ("Fr", new[] { new[] {"Francium (Fr)"}}),
                ("Ra", new[] { new[] {"Radium (Ra)"}}),
                ("Ac", new[] { new[] {"Actinium (Ac)"}}),
                ("Th", new[] { new[] {"Thorium (Th)"}}),
                ("Pa", new[] { new[] {"Protactinium (Pa)"}}),
                ("U", new[] { new[] {"Uranium (U)"}}),
                ("Np", new[] { new[] {"Neptunium (Np)"}, new[] {"Nitrogen (N)", "Phosphorus (P)"}}),
                ("Pu", new[] { new[] {"Phosphorus (P)", "Uranium (U)"}, new[] {"Plutonium (Pu)"}}),
                ("Am", new[] { new[] {"Americium (Am)"}}),
                ("Cm", new[] { new[] {"Curium (Cm)"}}),
                ("Bk", new[] { new[] {"Berkelium (Bk)"}, new[] {"Boron (B)", "Potassium (K)"}}),
                ("Cf", new[] { new[] {"Californium (Cf)"}, new[] {"Carbon (C)", "Fluorine (F)"}}),
                ("Es", new[] { new[] {"Einsteinium (Es)"}}),
                ("Fm", new[] { new[] {"Fermium (Fm)"}}),
                ("Md", new[] { new[] {"Mendelevium (Md)"}}),
                ("No", new[] { new[] {"Nitrogen (N)", "Oxygen (O)"}, new[] {"Nobelium (No)"}}),
                ("Lr", new[] { new[] {"Lawrencium (Lr)"}}),
                ("Rf", new[] { new[] {"Rutherfordium (Rf)"}}),
                ("Db", new[] { new[] {"Dubnium (Db)"}}),
                ("Sg", new[] { new[] {"Seaborgium (Sg)"}}),
                ("Bh", new[] { new[] {"Bohrium (Bh)"}, new[] {"Boron (B)", "Hydrogen (H)"}}),
                ("Hs", new[] { new[] {"Hassium (Hs)"}, new[] {"Hydrogen (H)", "Sulfur (S)"}}),
                ("Mt", new[] { new[] {"Meitnerium (Mt)"}}),
                ("Ds", new[] { new[] {"Darmstadtium (Ds)"}}),
                ("Rg", new[] { new[] {"Roentgenium (Rg)"}}),
                ("Cn", new[] { new[] {"Carbon (C)", "Nitrogen (N)"}, new[] {"Copernicium (Cn)"}}),
                ("Uut", new[] { new[] {"Ununtrium (Uut)"}}),
                ("Fl", new[] { new[] {"Flerovium (Fl)"}}),
                ("Uup", new[] { new[] {"Ununpentium (Uup)"}, new[] {"Uranium (U)", "Uranium (U)", "Phosphorus (P)"}}),
                ("Lv", new[] { new[] {"Livermorium (Lv)"}}),
                ("Uus", new[] { new[] {"Ununseptium (Uus)"}, new[] {"Uranium (U)", "Uranium (U)", "Sulfur (S)"}}),
                ("Uuo", new[] { new[] {"Ununoctium (Uuo)"}, new[] {"Uranium (U)", "Uranium (U)", "Oxygen (O)"}}),
            };
            foreach (var (word, expected) in cases)
            {
                var actual = Elements.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }
    }

    [TestFixture, Description("Simple Elemental Forms")]
    class SimpleElementalForms
    {
        [Test, Description("Words that have 1 elemental form")]
        public void OneElementalForm()
        {
            var cases = new[] {
                ("acceptance", new[] { new[] {"Actinium (Ac)", "Cerium (Ce)", "Phosphorus (P)", "Tantalum (Ta)", "Nitrogen (N)", "Cerium (Ce)"} }),
                ("beach", new[] { new[] {"Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"} }),
                ("fictitious", new[] { new[] {"Fluorine (F)", "Iodine (I)", "Carbon (C)", "Titanium (Ti)", "Titanium (Ti)", "Oxygen (O)", "Uranium (U)", "Sulfur (S)"} }),
                ("namaste", new [] { new[] {"Nitrogen (N)", "Americium (Am)", "Arsenic (As)", "Tellurium (Te)"} }),
                ("precipitation", new [] { new[] {"Phosphorus (P)", "Rhenium (Re)", "Carbon (C)", "Iodine (I)", "Phosphorus (P)", "Iodine (I)", "Tantalum (Ta)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"} }),
            };
            foreach (var (word, expected) in cases)
            {
                var actual = Elements.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

        [Test, Description("Words that have 2 elemental forms")]
        public void TwoElementalForms()
        {
            var cases = new[] {
                ("biblical", new[] {
                    new[] {"Bismuth (Bi)", "Boron (B)", "Lithium (Li)", "Carbon (C)", "Aluminium (Al)"},
                    new[] {"Boron (B)", "Iodine (I)", "Boron (B)", "Lithium (Li)", "Carbon (C)", "Aluminium (Al)"}
                }),
                ("calculation", new[] {
                    new[] {"Carbon (C)", "Aluminium (Al)", "Carbon (C)", "Uranium (U)", "Lanthanum (La)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Carbon (C)", "Aluminium (Al)", "Copper (Cu)", "Lanthanum (La)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"}
                }),
                ("helicopter", new[] {
                    new[] {"Helium (He)", "Lithium (Li)", "Carbon (C)", "Oxygen (O)", "Platinum (Pt)", "Erbium (Er)"},
                    new[] {"Helium (He)", "Lithium (Li)", "Cobalt (Co)", "Platinum (Pt)", "Erbium (Er)"}
                }),
                ("odysseus", new[] {
                    new[] {"Oxygen (O)", "Dysprosium (Dy)", "Sulfur (S)", "Selenium (Se)", "Uranium (U)", "Sulfur (S)"},
                    new[] {"Oxygen (O)", "Dysprosium (Dy)", "Sulfur (S)", "Sulfur (S)", "Europium (Eu)", "Sulfur (S)"}
                }),
                ("probabilities", new[] {
                    new[] {"Praseodymium (Pr)", "Oxygen (O)", "Barium (Ba)", "Bismuth (Bi)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Praseodymium (Pr)", "Oxygen (O)", "Barium (Ba)", "Boron (B)", "Iodine (I)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"}
                }),
            };
            foreach (var (word, expected) in cases)
            {
                var actual = Elements.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

        [Test, Description("Words that have 3 elemental forms")]
        public void ThreeElementalForms()
        {
            var cases = new[] {
                ("agnostic", new[] {
                    new[] {"Silver (Ag)", "Nitrogen (N)", "Osmium (Os)", "Titanium (Ti)", "Carbon (C)"},
                    new[] {"Silver (Ag)", "Nitrogen (N)", "Oxygen (O)", "Sulfur (S)", "Titanium (Ti)", "Carbon (C)"},
                    new[] {"Silver (Ag)", "Nobelium (No)", "Sulfur (S)", "Titanium (Ti)", "Carbon (C)"}
                }),
                ("hallucination", new[] {
                    new[] {"Hydrogen (H)", "Aluminium (Al)", "Lutetium (Lu)", "Carbon (C)", "Indium (In)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Hydrogen (H)", "Aluminium (Al)", "Lutetium (Lu)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Hydrogen (H)", "Aluminium (Al)", "Lutetium (Lu)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"}
                }),
                ("rainbow", new [] {
                    new[] {"Radium (Ra)", "Indium (In)", "Boron (B)", "Oxygen (O)", "Tungsten (W)"},
                    new[] {"Radium (Ra)", "Iodine (I)", "Niobium (Nb)", "Oxygen (O)", "Tungsten (W)"},
                    new[] {"Radium (Ra)", "Iodine (I)", "Nitrogen (N)", "Boron (B)", "Oxygen (O)", "Tungsten (W)"}
                }),
                ("snack", new[] {
                    new[] {"Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
                    new[] {"Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
                    new[] {"Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
                }),
                ("vaccination", new[] {
                    new[] {"Vanadium (V)", "Actinium (Ac)", "Carbon (C)", "Indium (In)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Vanadium (V)", "Actinium (Ac)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Vanadium (V)", "Actinium (Ac)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"}
                }),
            };
            foreach (var (word, expected) in cases)
            {
                var actual = Elements.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

        [Test, Description("Words that have many elemental forms")]
        public void ManyElementalForms()
        {
            var cases = new[] {
                ("cocopuffs", new[] {
                    new[] {"Carbon (C)", "Oxygen (O)", "Carbon (C)", "Oxygen (O)", "Phosphorus (P)", "Uranium (U)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Oxygen (O)", "Carbon (C)", "Oxygen (O)", "Plutonium (Pu)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Oxygen (O)", "Cobalt (Co)", "Phosphorus (P)", "Uranium (U)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Oxygen (O)", "Cobalt (Co)", "Plutonium (Pu)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Cobalt (Co)", "Carbon (C)", "Oxygen (O)", "Phosphorus (P)", "Uranium (U)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Cobalt (Co)", "Carbon (C)", "Oxygen (O)", "Plutonium (Pu)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Cobalt (Co)", "Cobalt (Co)", "Phosphorus (P)", "Uranium (U)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"},
                    new[] {"Cobalt (Co)", "Cobalt (Co)", "Plutonium (Pu)", "Fluorine (F)", "Fluorine (F)", "Sulfur (S)"}
                }),
                ("responsibilities", new[] {
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Phosphorus (P)", "Oxygen (O)", "Nitrogen (N)", "Silicon (Si)", "Bismuth (Bi)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Phosphorus (P)", "Oxygen (O)", "Nitrogen (N)", "Silicon (Si)", "Boron (B)", "Iodine (I)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Phosphorus (P)", "Oxygen (O)", "Nitrogen (N)", "Sulfur (S)", "Iodine (I)", "Bismuth (Bi)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Phosphorus (P)", "Oxygen (O)", "Nitrogen (N)", "Sulfur (S)", "Iodine (I)", "Boron (B)", "Iodine (I)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Polonium (Po)", "Nitrogen (N)", "Silicon (Si)", "Bismuth (Bi)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Polonium (Po)", "Nitrogen (N)", "Silicon (Si)", "Boron (B)", "Iodine (I)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Polonium (Po)", "Nitrogen (N)", "Sulfur (S)", "Iodine (I)", "Bismuth (Bi)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"},
                    new[] {"Rhenium (Re)", "Sulfur (S)", "Polonium (Po)", "Nitrogen (N)", "Sulfur (S)", "Iodine (I)", "Boron (B)", "Iodine (I)", "Lithium (Li)", "Titanium (Ti)", "Einsteinium (Es)"}
                }),
                ("possession", new[] {
                    new[] {"Phosphorus (P)", "Osmium (Os)", "Selenium (Se)", "Sulfur (S)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Osmium (Os)", "Selenium (Se)", "Sulfur (S)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Osmium (Os)", "Sulfur (S)", "Einsteinium (Es)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Osmium (Os)", "Sulfur (S)", "Einsteinium (Es)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Oxygen (O)", "Sulfur (S)", "Selenium (Se)", "Sulfur (S)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Oxygen (O)", "Sulfur (S)", "Selenium (Se)", "Sulfur (S)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Oxygen (O)", "Sulfur (S)", "Sulfur (S)", "Einsteinium (Es)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Phosphorus (P)", "Oxygen (O)", "Sulfur (S)", "Sulfur (S)", "Einsteinium (Es)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Polonium (Po)", "Sulfur (S)", "Selenium (Se)", "Sulfur (S)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Polonium (Po)", "Sulfur (S)", "Selenium (Se)", "Sulfur (S)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Polonium (Po)", "Sulfur (S)", "Sulfur (S)", "Einsteinium (Es)", "Silicon (Si)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Polonium (Po)", "Sulfur (S)", "Sulfur (S)", "Einsteinium (Es)", "Sulfur (S)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"}
                }),
                ("casinos", new[] {
                    new[] {"Calcium (Ca)", "Silicon (Si)", "Nitrogen (N)", "Osmium (Os)"},
                    new[] {"Calcium (Ca)", "Silicon (Si)", "Nitrogen (N)", "Oxygen (O)", "Sulfur (S)"},
                    new[] {"Calcium (Ca)", "Silicon (Si)", "Nobelium (No)", "Sulfur (S)"},
                    new[] {"Calcium (Ca)", "Sulfur (S)", "Indium (In)", "Osmium (Os)"},
                    new[] {"Calcium (Ca)", "Sulfur (S)", "Indium (In)", "Oxygen (O)", "Sulfur (S)"},
                    new[] {"Calcium (Ca)", "Sulfur (S)", "Iodine (I)", "Nitrogen (N)", "Osmium (Os)"},
                    new[] {"Calcium (Ca)", "Sulfur (S)", "Iodine (I)", "Nitrogen (N)", "Oxygen (O)", "Sulfur (S)"},
                    new[] {"Calcium (Ca)", "Sulfur (S)", "Iodine (I)", "Nobelium (No)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Arsenic (As)", "Indium (In)", "Osmium (Os)"},
                    new[] {"Carbon (C)", "Arsenic (As)", "Indium (In)", "Oxygen (O)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Arsenic (As)", "Iodine (I)", "Nitrogen (N)", "Osmium (Os)"},
                    new[] {"Carbon (C)", "Arsenic (As)", "Iodine (I)", "Nitrogen (N)", "Oxygen (O)", "Sulfur (S)"},
                    new[] {"Carbon (C)", "Arsenic (As)", "Iodine (I)", "Nobelium (No)", "Sulfur (S)"}
                }),
                ("floccinaucinihilipilification", new[] {
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Indium (In)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Gold (Au)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Indium (In)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Iodine (I)", "Nickel (Ni)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Calcium (Ca)", "Titanium (Ti)", "Oxygen (O)", "Nitrogen (N)"},
                    new[] {"Flerovium (Fl)", "Oxygen (O)", "Carbon (C)", "Carbon (C)", "Iodine (I)", "Sodium (Na)", "Uranium (U)", "Carbon (C)", "Iodine (I)", "Nitrogen (N)", "Iodine (I)", "Hydrogen (H)", "Iodine (I)", "Lithium (Li)", "Phosphorus (P)", "Iodine (I)", "Lithium (Li)", "Fluorine (F)", "Iodine (I)", "Carbon (C)", "Astatine (At)", "Iodine (I)", "Oxygen (O)", "Nitrogen (N)"}
                }),
            };
            foreach (var (word, expected) in cases)
            {
                var actual = Elements.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }
    }

    [TestFixture, Description("Random Tests")]
    class RandomTests
    {
        private readonly Random rng = new Random();
        private readonly string[] ELEMENTAL_WORDS = new[] {
            "of","in","is","on","that","by","this","with","i","you","be","at","as","new","more","was","can","us","if","page","has","search","one","other","no","site","he","up","what","which","news","use","so","his",
            "when","here","business","who","also","now","pm","online","c","am","how","s","services","click","service","find","price","back","over","state","health","n","re","b","buy","her","policy","such","where",
            "info","public","books","links","she","very","privacy","book","user","under","general","research","life","know","p","real","f","international","off","line","before","send","because","those","office","national",
            "car","within","states","phone","w","show","o","black","check","prices","link","south","case","pages","uk","version","section","own","found","house","both","american","power","care","place","h","per","access",
            "think","law","water","personal","since","shop","white","rate","v","sites","previous","non","k","y","insurance","why","class","cd","money","movies","press","u","around","process","sales","team","estate",
            "conditions","windows","gay","note","library","action","series","features","plan","yes","second","la","server","pc","staff","articles","play","issues","never","users","financial","person","offers","park",
            "social","options","rates","body","america","few","paper","ii","activities","club","ca","pay","poker","browse","range","february","war","nov","offer","al","china","professional","month","space","sun","cards",
            "porn","reference","baby","run","co","notice","once","others","months","sure","cars","association","fun","close","several","feb","sep","ask","solutions","beach","whether","upon","official","land","technical",
            "window","france","pro","island","conference","sound","ago","final","kids","finance","tips","plus","cover","function","tech","far","player","often","subscribe","watch","bank","various","choose","archives",
            "protection","policies","position","known","half","cases","step","none","license","basic","sony","shows","response","practice","fire","chat","brand","standards","political","base","near","french","oh","shoes",
            "stay","nature","notes","copy","pics","western","cash","bay","players","supplies","bar","plans","soon","lines","season","ny","condition","casino","pdf","cross","silver","wish","solution","rather","certain",
            "usr","necessary","union","mon","fine","names","gas","bush","islands","career","british","pre","huge","sat","facilities","kind","values","nice","score","statistics","ok","shown","band","flash","choice","fri",
            "hi","phones","fund","super","inn","cause","potential","hp","focus","late","inc","win","cancer","reason","browser","foundation","voice","feature","police","ip","cameras","brown","physical","chicago","smith",
            "population","pa","secure","navigation","operations","ass","station","paypal","understand","option","recently","thu","publications","connection","publisher","larger","kitchen","carolina","properties","ship","owners",
            "classic","basis","cities","thus","pussy","success","operation","boy","wine","vote","flowers","owner","son","takes","iii","searches","mother","bin","ireland","charge","ships","md","fl","chinese","opinion",
            "uses","funds","resolution","publication","pass","relations","contains","session","republic","fees","vacation","assistance","skin","prev","pacific","mountain","pop","behind","boys","otherwise","protein","politics",
            "boards","parties","fish","sense","pack","stage","internal","born","race","usb","functions","brands","places","php","spain","southern","youth","pressure","core","papers","las","remote","visual","teachers","isbn",
            "repair","associates","updates","classes","paris","ohio","un","fat","father","officer","businesses","unknown","teacher","relationship","campus","sub","fiction","hear","watches","careers","beyond","families","wife",
            "ten","th","cat","references","flat","flow","spanish","stand","critical","path","kb","packages","francisco","laws","switch","titles","cup","pp","suite","na","attention","skip","auction","gear","os","nation",
            "certificate","motion","fashion","whose","vision","actions","listen","accept","wind","clinical","lives","bob","persons","pain","www","buyer","functional","au","fi","ice","pink","balance","replies","nc","initial",
            "sec","canon","waste","bus","optional","sections","bag","po","sc","surgery","patch","heat","generation","task","se","processes","servers","alone","seconds","walk","fuck","paperback","fresh","pick","auctions",
            "upper","serious","began","steps","shops","ga","ac","practices","essential","recovery","cock","universal","cds","presentation","orange","vs","ar","porno","acceptance","mo","hire","branch","charges","reasons",
            "ones","latin","corner","rank","birth","virus","separate","column","reach","inch","attack","lab","recipes","cvs","plastic","snow","eu","camp","cc","clubs","kinds","teams","cm","wi","senate","funny","brother",
            "gene","pattern","hentai","boat","laser","classical","icon","taxes","mouse","brain","wisconsin","false","flower","pic","opinions","promote","professionals","flag","covers","clips","iv","iron","script","atlanta",
            "vhs","vice","ne","ray","votes","bear","gain","festival","lack","laptop","vintage","spa","concept","knew","con","ups","nations","frank","clip","es","provisions","wire","sounds","spam","bytes","netherlands",
            "obtain","bc","recreation","offices","pr","banks","fr","bath","austin","var","healthy","mt","lawyer","proposal","beta","officials","won","bags","houses","relationships","wales","finish","physics","rare","bars",
            "contain","accuracy","mg","creation","static","scene","lady","famous","dynamic","gender","practical","seat","concerns","utilities","officers","bids","tip","secondary","ski","soccer","presence","healthcare","ch",
            "moon","participation","fly","libraries","proper","singapore","fear","inches","shares","principal","wars","cisco","cruise","bonus","certification","hey","beat","bbc","positions","subscription","sky","utah",
            "nearby","panasonic","refer","provision","clothes","babes","frames","viagra","newspaper","layer","removal","src","hip","nine","mostly","eric","americans","optical","promotion","clock","hiv","suites","conversion",
            "serial","revision","ratio","rain","copies","proof","tennis","bass","prescription","instance","bureau","conservation","pair","parks","lawyers","cream","ss","runs","patterns","boxes","mn","nd","irish",
            "certificates","stations","op","acc","generic","cap","ink","census","suppliers","preparation","noise","array","accurate","stephen","reservations","pin","playstation","raw","establish","sharp","ben","lane",
            "paragraph","ce","versions","percentage","knows","concern","backup","heritage","personals","coach","ages","participate","cook","virgin","investigation","hat","lib","plate","indicate","utc","cheats","continues",
            "cam","prince","responses","atlantic","respond","plain","iran","launch","costa","fiscal","bond","ericsson","notify","blues","chocolate","pub","hampshire","supplier","representatives","causes","notebook","tm",
            "husband","britain","scores","sp","linear","bears","hop","mouth","concepts","nh","pure","wonder","fm","neither","offline","replace","connections","suck","babe","checks","crew","sam","stick","relation","genre",
            "montana","volunteer","rear","bound","laptops","brothers","ref","tank","navy","continuous","db","pan","increases","winner","ph","plays","pt","indicates","universe","psp","ds","sessions","boobs","buyers","und",
            "chosen","swiss","clark","publishers","behalf","salary","reservation","foods","nfl","raise","prepare","vary","hundreds","nw","bands","ff","lunch","push","chamber","iso","attend","shower","province","catholic",
            "vat","beer","catch","pakistan","ps","sir","finder","periods","tasks","attacks","resistance","baltimore","ky","alumni","preferences","spy","bruce","powers","br","classification","bargain","chip","res","wow",
            "simon","birds","satisfaction","char","moore","choices","carbon","interaction","crisis","outlook","cs","revolution","voip","banner","barbara","cooperation","counties","sf","notification","stands","teach","reverse",
            "latina","tab","concrete","si","poland","css","universities","notices","subscriptions","calculate","nick","representation","smooth","conferences","threat","ownership","researchers","unsubscribe","bio","philippines",
            "statistical","beds","innovation","pcs","von","ag","scan","reaction","blank","generate","newspapers","vi","sci","capabilities","sin","berlin","cute","ba","para","cr","capture","pounds","buffalo","plane","rubber",
            "conclusion","ks","python","bone","columns","cookies","inner","cruises","gate","proposals","sw","lawrence","erotic","forever","busy","captain","neck","scripts","stereo","taste","tiny","operational","liberal",
            "gap","cache","er","hobbies","seats","nintendo","usual","franklin","argentina","garage","volunteers","finland","asp","prayer","luck","postage","responsibilities","crown","par","crack","picks","vacations","fetish",
            "casinos","nv","notebooks","blind","coins","cafe","proteins","su","familiar","cpu","ran","finds","seal","fifth","vertical","sr","substance","lies","initiatives","classics","lay","bankruptcy","substances",
            "genetic","waters","thin","prefer","sick","buffer","limousines","li","prison","mountains","moves","sierra","cats","nba","navigate","spaces","coupons","receiver","substantial","cialis","bb","boats","championship",
            "obvious","fiber","testimonials","bonds","alberta","org","cincinnati","subsection","crash","closer","infection","clinic","princess","spray","observations","winners","pat","te","creates","faces","cocks",
            "presentations","tion","hence","wiki","occupation","lakes","associations","nsw","flags","pci","baker","shock","walker","atmosphere","kiss","ra","overseas","yards","rush","ukraine","whereas","yoga","serves",
            "woods","partial","shoppers","ceo","palace","wins","verify","copper","rack","rep","receipt","nobody","violation","boss","champion","cloudy","sentence","brass","pdas","publish","sri","whenever","pioneer","plates",
            "acres","cf","obligation","lan","sms","republican","lucky","thick","philips","nec","vista","chips","orgy","tabs","casual","polish","clause","lands","broker","pine","tend","cp","laura","shopper","partly","nikon",
            "candy","scenes","icons","pound","burn","labs","dynamics","rf","conversation","fe","precision","reserves","amp","sb","franchise","sm","nancy","promotions","passion","clay","patches","refund","usc","reception",
            "wise","cyprus","wv","ns","phrase","genuine","sons","versus","bs","cuba","promotional","babies","bi","cal","kick","ta","img","warren","slip","involves","funeral","francis","caps","facial","boundary","philip",
            "spin","stages","winds","assess","wash","rev","shore","cl","ho","alternatives","parker","sh","cooper","nyc","unusual","titans","genes","scanner","herein","occupational","horny","hs","hero","basics","binary",
            "genetics","punk","coalition","pi","pace","arc","interfaces","atlas","observation","coat","opposition","container","warner","liver","peripherals","brochure","bikini","brokers","ion","ic","seasons","peru",
            "interactions","refine","literacy","invite","alice","latinas","suppose","opposite","ban","assurance","clerk","outline","receives","verification","wrap","refers","occasion","beam","obligations","moreover","licence",
            "amy","camps","packs","ge","switches","thou","coal","cry","refinance","lion","canyon","conclusions","passes","hats","sharon","tcp","surf","rainbow","hook","facilitate","subscriber","val","flickr","knife","crop",
            "fy","lite","hub","founder","steam","voices","acute","albany","stack","housewares","reputation","amber","variation","pierre","chi","sauce","criticism","rfc","athens","seo","isp","ins","populations","acoustic",
            "hb","tc","fusion","ruby","preference","canvas","parish","planner","flows","fewer","coupon","opt","flu","bikes","gates","rap","bishop","corn","seasonal","perfectly","tin","instantly","litigation","heroes","ir",
            "ties","fisher","artificial","activation","subscribers","lawn","basin","soup","ranch","byte","nose","branches","oclc","nepal","constantly","moscow","thesis","thru","bargains","hispanic","cv","cb","gen","espn",
            "bunch","inclusion","ti","fc","civic","fw","sees","wishes","monica","repairs","breath","bp","herbal","gains","renewal","panties","critics","oo","hacker","coin","bbw","salon","cure","arch","ni","thinks","thats",
            "asin","brush","investigate","thy","spare","pal","florence","honey","scenario","fs","gauge","essentials","nn","noon","supervision","cheat","separation","testimony","sender","boundaries","crucial","syndication",
            "spouse","threats","vb","cams","piss","surgical","citation","pitch","yo","cloth","salmon","proc","cargo","tan","likes","chef","tapes","races","offshore","cbs","bow","phpbb","probe","recover","catherine","chuck",
            "hon","calculation","boob","occasions","brooks","sept","spatial","ceramic","precious","scanners","pays","sunny","necklace","uv","blair","hopes","cms","burns","sg","vic","pos","attach","licenses","brunswick",
            "phys","ranges","pairs","preservation","hudson","chose","syndicate","pickup","mothers","nascar","iceland","bend","variations","oliver","nav","synthesis","cyber","clone","relay","tears","oasis","baseline","cab",
            "silicon","honolulu","lips","retention","pond","barnes","profession","cnn","tire","recreational","heather","unions","sys","scales","observer","sunshine","ceremony","provincial","investigations","hebrew","scsi",
            "focuses","possession","cu","vocal","pty","ws","span","satisfy","layers","bahamas","bench","univ","hampton","pads","inns","bobby","wines","cups","ash","ali","np","tender","violations","foam","paste","clouds",
            "praise","realistic","showcase","asks","synopsis","reunion","float","colin","bias","paths","acids","viruses","tap","stickers","fisheries","reactions","lauren","ci","relate","wages","suffer","nano","retain",
            "genres","yn","wheat","bases","vii","instances","indigenous","cfr","socks","incentives","beaches","surfaces","clocks","bios","wallace","fever","pmc","cuisine","practitioners","inflation","nb","ruth","pray",
            "chicks","bare","tanks","mono","particles","inspiration","rebate","rec","cycles","ampland","prep","pb","butler","cookbook","americas","pros","techno","genesis","arise","irc","perception","wy","bra","bitch",
            "infections","chess","operates","brisbane","oscar","festivals","possibilities","canal","amino","phi","herbs","clinics","cow","watson","circulation","offense","hobby","inline","closure","ppc","intense","showers",
            "screw","publicly","acer","ons","sink","assure","invitation","randy","timothy","brick","naval","cameron","pins","reno","cabin","consensus","horn","pd","perth","intention","tires","snap","auckland","geo",
            "calculations","ati","wal","crops","flip","nervous","refuse","fragrance","replica","superb","champions","vocational","batch","latino","uc","harmony","buf","chick","confusion","warranties","paperbacks","coaches",
            "walks","sucks","knives","arrange","artistic","bat","booth","bones","precise","notifications","invoice","lip","gather","suse","carey","rebecca","foundations","nu","browsers","patio","optics","ou","oops","plains",
            "sku","raymond","hereby","containers","racial","pts","rh","playboy","finite","fixes","sends","wichita","ooo","verse","scratch","launches","henderson","bk","britannica","nhs","racks","lace","consciousness","ste",
            "resolutions","sk","nicholas","yu","invasion","runner","notion","skins","oc","arctic","rewards","beneath","une","wp","neo","motivation","agrees","consistently","cons","sonic","cheers","belarus","nat","essence",
            "worn","vp","cn","ranks","generations","bali","fraction","cube","monaco","beneficial","vaccine","crap","volvo","republicans","ver","rn","alpine","alias","thesaurus","newer","spice","oval","ser","ascii",
            "citations","tension","href","wifi","tier","championships","rapids","aus","hwy","cashiers","cite","nam","eugene","gdp","una","chorus","precipitation","lions","findlaw","tb","claire","isolation","rational",
            "chambers","vocals","fountain","chubby","burner","foo","plaintiff","finnish","prisoners","hose","footage","valuation","punch","cowboy","bahrain","pubs","lucas","vip","clicks","honduras","harper","algebra","soc",
            "fence","infinite","relatives","clan","revolutionary","sync","fatal","thickness","genius","flesh","wherever","estates","brandon","ham","partition","funk","fbi","sheer","bind","rand","hopkins","cylinder","witch",
            "buck","indication","cohen","usgs","puppy","kathy","acre","chen","finances","accepts","hc","fp","carnival","sticker","satin","bon","promo","representations","beth","phrases","reaches","renew","viii","floppy",
            "thunder","caution","hack","pirates","cos","pac","erp","ui","hindu","fragrances","vpn","fcc","lucy","conspiracy","whats","saturn","planes","condo","amplifier","vernon","irs","occasional","casio","innovations",
            "postcards","monte","fires","luis","panic","sticks","onion","pf","uw","hierarchy","banners","circles","italic","beats","scuba","cage","courage","scenarios","hitachi","lap","beverages","calibration","luther",
            "frontier","refugees","hypothesis","pontiac","scenic","consistency","propose","hh","rage","uh","pavilion","tactics","induction","provinces","finals","steal","bo","fears","rays","asn","acne","palestine","libs",
            "undo","atmospheric","pk","halo","ppm","proposition","gays","gasoline","inf","bucks","vcr","raises","heath","plastics","salaries","psi","buses","wb","creatures","smilies","vids","corners","newfoundland","sn",
            "pas","intend","findarticles","yukon","bite","issn","infectious","sas","brook","fu","insulin","biblical","conscious","wives","prostate","auburn","vampire","relates","firewire","mods","revisions","varies","wn",
            "ccd","sv","buys","researcher","occupations","viral","pipes","aruba","chassis","barn","boc","asus","pierce","allan","techrepublic","craps","fo","prefers","brochures","herb","tmp","breach","stationery","fin","io",
            "calvin","uni","shark","phases","cliff","shine","pn","conversations","pasta","focal","vagina","incl","champagne","nbc","samba","housewives","wound","conviction","hash","hamburg","cindy","fathers","carb","cas",
            "cio","rb","upc","cubic","kinase","pvc","sheriff","spies","blah","feof","bunny","chevy","tions","sentences","flyer","receivers","cameroon","baths","brakes","ko","owns","invision","sticky","generous","landscapes",
            "ww","sparc","salvation","vatican","gd","convergence","dylan","bras","blacks","rebates","clara","bw","hepatitis","waterproof","flush","invitations","moses","valves","gaps","tear","teaches","pam","nato","prayers",
            "funky","nowhere","cop","paragraphs","scary","brunei","banana","cakes","stan","reservoir","wc","stays","washer","rebound","helicopter","hk","sphere","moss","ratios","lance","unnecessary","lanes","mtv","caroline",
            "namespace","peripheral","condos","gently","casey","fraser","possess","sip","flashers","subaru","picnic","spank","cw","practitioner","rg","wires","vc","bacon","heater","cannon","circus","forbes","spine","feat",
            "sic","usps","fireplace","planners","closes","conf","violin","cir","erik","hu","newark","kw","paso","playback","ips","dsc","creations","scoop","movers","verbal","blink","presently","seas","voyuer","ru","pose",
            "render","ira","sen","erotica","southampton","sega","cdna","wu","gage","whore","lu","wagon","knock","smtp","generates","replication","neon","creature","syracuse","internship","refresh","canberra","kirk","choir",
            "cho","promotes","bbs","spas","ind","fibre","indices","intl","prisoner","yarn","conditional","bother","conceptual","bhutan","allah","ob","unwrap","fares","insertion","ids","wagner","insulation","laos","poison",
            "lunatic","unwise","assassin","tan","seneca","pauses","broth","boar","overseer","sagacious","nap","crater","shrub","births","paw","forbes","shyness","spotless","euphrates","visionary","archives","hindrance",
            "omnibus","lute","slander","pronunciation","clover","retains","cyprus","spruce","undo","pericles","fictitious","heather","rupture","nw","stew","fibre","pans","recite","pigeon","offender","par","unawares","creates",
            "gauge","spartan","hip","sash","conflagration","bailiff","monastic","aspire","papal","flowery","verbs","slack","gaudy","viceroy","ny","sensuous","festivities","shewn","lure","precept","provisional","teams",
            "spiral","hypocrite","refresh","spire","lick","potential","lisbon","persistence","prosecute","licence","lucas","fir","violate","tennis","prelate","kids","windy","asses","vatican","tack","parsons","artifice",
            "convoy","spine","colin","amos","napkin","fry","focus","arc","smash","facilitate","attends","hose","overflow","stitch","sampson","separates","ascribe","politic","stab","chop","coup","uncanny","moth","thinker",
            "ravages","civic","halves","atone","atlas","bacchus","listless","slab","switch","aspiration","oration","tidy","isis","claire","finn","atlanta","hack","teaspoon","hoc","clap","rapt","moat","suns","tenure",
            "sheath","cone","planes","latch","priestly","participate","stealthy","odysseus","shipwreck","chess","nucleus","se","usages","swarthy","bluntly","finery","scalp","auction","bunk","babes","privy","tho","pies",
            "showy","cowper","hips","beau","cubic","reservation","nouns","chuck","sw","tawny","sew","suck","bankrupt","carcass","visitation","fern","clown","fergus","husky","katharine","census","heretic","sustenance",
            "unhealthy","pp","satirical","syrup","slap","hoary","fernando","rend","consistently","reciprocal","prescription","halo","vassal","bias","frolic","vista","hammock","shiny","whichever","finite","policies","forgery",
            "swoon","hoof","packages","iceland","spat","barbaric","cask","foxes","soar","condescend","southampton","smoky","osiris","pronoun","broker","inarticulate","carnal","spice","pouch","sharpness","gases","reparation",
            "niche","rap","baseness","artless","liberation","vibration","franchise","palate","poise","proverbs","oblivious","astern","wither","knob","unconsciousness","racial","crags","neptune","innovation","vestige","ban",
            "inconsistency","prop","sundown","saucy","eruption","cinnamon","moody","calumny","plastic","secession","calvin","tens","hey","propitious","ratification","pretense","vindicate","woo","newfoundland","prescribe","hiss",
            "novice","incarnation","steals","consecration","paralysis","reservoir","ferguson","hark","wards","conical","instantaneous","ne","profuse","crab","rehearsal","chip","oppress","insistence","hag","kine","gen","nassau",
            "eunuch","hop","housewife","prow","casey","articulate","cipher","seth","saucepan","assassins","syracuse","profligate","crook","overrun","irrational","clocks","bier","shorn","voluptuous","cowboy","pore","tic",
            "flakes","prophesy","ponds","stepmother","parsonage","renunciation","parishes","infatuation","runner","unborn","prick","flap","option","puppy","bankruptcy","pane","froth","odyssey","cornish","shoal","orb","shark",
            "hatch","flicker","acids","cashier","birthplace","coalition","ponder","usher","lancashire","flaw","sensational","realism","lair","kite","cafe","ambulance","proverbial","caricature","hypocritical","tenacious",
            "kinship","irresolute","reticence","seer","newer","realistic","honeymoon","chips","natal","arsenal","cite","staunch","taper","saucer","prays","forage","urges","ire","bland","verify","scribe","yo","backbone",
            "whales","lilac","pal","panther","ocr","respiration","alias","allay","urn","sheila","chevalier","skip","crag","acuteness","hir","pyrenees","nods","psychic","noose","crank","fin","palatine","cravat","woody",
            "surgery","sine","nicer","pauper","bruno","poop","saturn","pop","undress","reunion","atmospheric","wrench","indigenous","crete","cancer","capacious","pawn","fete","stack","perfidy","sensibilities","contingency",
            "prolific","vindication","carnage","spasm","bluish","wag","moths","puny","snatches","dynamite","beacon","cuckoo","induction","chew","recitation","caustic","alaric","piers","tanks","fallacy","pranks","tinker",
            "bane","phone","nether","tiber","capabilities","pooh","spartans","moi","cypress","hitch","flare","bats","booth","incarnate","cosmopolitan","crevice","indisposition","sal","slayer","smack","verona","volition",
            "scholastic","una","alfonso","hierarchy","progeny","relapse","varnish","hackers","canes","acclamations","pretension","hover","fleshy","cans","ish","serfs","atlantis","baroness","negation","winner","solutions",
            "lunar","potash","seashore","thorny","retaliation","canvass","bruise","heralds","fiber","sip","persecute","nautical","buyer","visual","vivacious","herbage","spar","falcon","carbonic","bananas","capita","claw",
            "plaintiff","cocks","canna","arrears","pretentious","thrush","ira","ga","thatch","baal","tapers","calcareous","bo","cub","pascal","untidy","whine","infectious","postage","confiscation","warp","confuse","coinage",
            "tara","surgical","wrapper","nasal","ba","perseus","carbonate","probabilities","nearby","upland","preoccupation","slipper","obscene","shack","populations","stealth","sunbeam","initiation","fraternal","crabs","lank",
            "concise","valise","brock","archer","precipitation","bribery","alison","hobby","tacitly","fatherland","insertion","hubbub","chastise","cruiser","wiry","erratic","moose","knack","lucifer","sever","uk","ostentatious",
            "sr","erik","financier","accuser","fusion","cosy","brine","hoop","caliph","sticky","oasis","instigation","cession","botany","byte","sirrah","carnival","secretion","scan","narcissus","flirtation","socialism",
            "copse","nowise","vishnu","cosmic","tipsy","sharks","finland","buff","propagation","overthrew","smoothness","bonfire","butchers","fife","refute","practitioner","rhone","stench","pesos","conservation","hamper",
            "valuation","xenophon","probation","cuban","pacify","psyche","infusion","sallies","notebook","vas","cinders","scamp","batch","chops","cones","vintage","sniff","spinal","piracy","consecrate","reversion","garage",
            "crutch","tier","recluse","ostend","charioteer","blasphemous","inundation","catechism","phosphorus","brooch","falstaff","circulate","orbs","crane","perversion","officious","hops","notify","fresher","schism","thesis",
            "harass","brawny","pry","businesses","notch","ruse","calvary","heretical","crackers","banana","bran","sinewy","fuse","chink","bach","unction","resound","hallucination","asceticism","balsam","wicker","invocation",
            "precocious","ceres","reprobate","wharves","alf","ps","pi","bus","thrace","whiff","canary","fruition","priestess","hacker","homogeneous","bookcase","rhinoceros","fran","pith","bivouac","inflation","liberate","pip",
            "licentiousness","bruges","concierge","chef","vagaries","pores","ungenerous","hun","res","un","parasite","crockery","fins","parody","supercilious","buckskin","intentional","algebra","coercion","generic","hoops",
            "concepts","optical","heinous","harps","personification","potency","gelatine","alcoholic","crib","alkali","perth","subaltern","spherical","burner","papyrus","crucial","eskimo","fob","cam","ferrara","rapacious",
            "agitate","hic","moonshine","browser","sis","stipulation","overhear","slick","singapore","tins","firstborn","creamy","fissure","cassock","titanic","attica","hearse","versus","hi","omnipotence","wat","whoop",
            "lucca","shears","alluvial","gens","fibrous","pup","watcher","versification","unsound","hostage","inca","convalescence","insinuation","forerunner","nip","peruse","botanical","preposition","inborn","conspire","nu",
            "seam","clip","scoff","rehearse","supra","ashen","wick","vouch","refutation","hew","remoteness","tick","bishopric","swoop","vat","atheism","franc","bi","severn","fresco","reactionary","thessaly","conditional",
            "retention","braces","plucky","pun","horus","vibrate","propagate","phial","probe","puppies","nag","vernal","scandals","celibacy","gender","almond","preferences","shirk","intestine","pontiff","luscious","blues",
            "th","posthumous","erin","burgher","coy","morass","inferno","synthesis","taps","vis","potentate","cossack","husk","whore","horny","culinary","resin","pyre","super","relay","fallacious","obliterate","allure",
            "rebuff","poppy","slavish","incite","knocker","cistern","hypotheses","io","lioness","funereal","gasoline","caucasus","auctioneer","pate","unconcern","factious","flabby","canonical","scion","unconditional","dynamic",
            "bairn","clandestine","revise","atkins","suffocation","thrash","arsenic","campus","canine","serial","asparagus","viper","sp","undertaker","mo","sprite","siren","plush","statistical","cuss","facial","insecure",
            "subterfuge","buoy","regenerate","overpower","potion","allison","flaxen","mourner","prep","cuff","fm","spurn","narrate","blink","samaritan","tinder","gala","broods","cherub","brigand","fender","hostelry",
            "libertine","braids","beck","chalice","paganism","uncover","genii","nunnery","infuse","sewn","kerosene","barrack","ss","proffer","snub","preaches","wisp","articulation","eros","cerebral","chubby","espouse",
            "tibetan","flagship","confessional","waterproof","accuses","ironic","ob","conscription","overseas","fauna","insincere","sewer","snore","profligacy","brownish","cannibal","ratify","spicy","argentine","certify",
            "cynic","monica","paraphrase","consulate","gash","fluffy","hinge","berkshire","brutish","crypt","italics","pretender","hussy","kraal","assassinate","brew","lucknow","fussy","shire","unbound","garnish","syndicate",
            "sinuous","honduras","auburn","serf","sou","heifer","crouch","cramp","generate","mop","wasp","bounteous","artificers","caribou","vicarage","ag","nauseous","sc","acclamation","championship","albion","classify",
            "oneness","lasso","flutes","caracalla","obsession","palermo","berne","eu","teas","convivial","moisten","conduce","parochial","wince","script","repine","carbine","stacy","sarcophagus","pounce","erotic","concussion",
            "flinch","bonus","punctilious","prate","fornication","cupola","sith","opal","palsy","swish","ser","premonition","regency","urns","refraction","wherewithal","bitch","brackish","itch","bestial","covertly","calibre",
            "cheshire","laconic","windlass","sharon","heracles","subconscious","cartilage","archery","indus","ores","biblical","occupancy","sonny","clink","scarecrow","bastion","taboo","hinduism","vespers","protein","passover",
            "chi","gaseous","rebound","smithy","necessitate","cohesion","tahiti","ups","holier","baptismal","refine","cos","scrip","gene","cob","cracker","operatic","piper","reversal","cavernous","punic","titan","withers",
            "nanny","coyote","sceptic","ruff","scaly","brat","heron","carp","rectify","como","skinny","neal","voracious","pus","monsoon","sparse","fisher","scoop","alibi","honolulu","chirp","navigate","bergen","clamber",
            "backwoods","sinew","stepfather","scenic","partakes","woof","mote","inversion","parasitic","acceptation","cyclone","crier","congestion","cube","finesse","incendiary","hash","liner","tactical","narcotic","sac",
            "sycamore","parsimony","functional","coffer","barnaby","testimonial","irwin","slav","craters","iceberg","aloofness","alternation","athena","harpoon","octavo","whack","opus","blubber","stink","bilious","paragon",
            "baton","props","bison","fiat","ascension","orgy","fascinate","argentina","cute","clods","mover","ner","stiffen","ticklish","inkstand","lunacy","wallis","literacy","concubine","dynamo","espionage","taurus","gavin",
            "nondescript","chamois","alkaline","homo","sec","beckon","careworn","buffoon","scow","nefarious","friesland","escutcheon","cabal","fatuous","hectic","subscriber","causal","lire","onerous","fen","bevy","prism",
            "hypnotic","sonata","verification","spawn","ge","lateness","overran","vial","hesse","sen","papacy","skunk","palatial","saline","slavic","southwark","fatten","retainer","erica","tacks","blare","perishes","mow",
            "vita","lisp","nepal","cookies","hoar","filipino","gage","vesta","coherence","rhubarb","vicarious","firstly","protege","laundress","caucus","chick","colic","iran","paraffin","secrete","cuirass","incantation",
            "sirup","convocation","spinach","operatives","racy","uproarious","whitewash","cronies","pristine","brigantine","fop","parlance","acorn","hearths","cram","parenthesis","smock","rebus","slush","vociferous","samos",
            "ww","causation","cm","flagon","uterus","lucerne","inception","obelisk","nonsensical","caper","capuchin","pater","agone","lice","youse","fy","patois","incision","churn","intensify","nb","warwickshire","hesitancy",
            "ionic","kith","notation","retina","bounce","lichen","tish","limousine","vampire","laps","randy","pres","cretaceous","patio","ashy","brewer","oblation","bravo","lascivious","plantains","feline","spa","inverse",
            "wren","icelandic","tether","cache","prank","nonce","pare","factitious","linear","benefice","shear","frankincense","broach","staccato","atop","pertain","slash","sambo","erosion","plantain","espy","movies","smoker",
            "sententious","coop","irate","battleship","amidships","cockney","hw","sunder","ce","hunch","pithy","uh","beautify","lanky","chary","pincers","foray","inconspicuous","fu","libation","amputation","chas","cop",
            "interaction","recondite","fetish","slavonic","caracas","britannica","pali","snob","valparaiso","chine","tanker","clam","brewery","bray","scamper","inane","shrew","spans","switches","infringe","genre","vin",
            "flounder","forger","subversion","lunge","isolate","nc","uno","indigence","lac","unofficial","benny","canny","palaver","hives","cauliflower","coerce","cinder","inaccuracy","lucre","artificer","shin","monaco",
            "sock","chunk","syphilis","clinch","cereal","captious","container","sinecure","cb","incubus","hera","aura","bate","fatalism","heartache","unintentional","convinces","hebe","charlatan","snaps","voluptuousness",
            "cosmos","crosswise","cranny","seneschal","coon","auckland","reinstate","hiv","innocuous","citation","sunderland","buckwheat","phonetic","tanner","winder","berber","puns","booby","funk","capitalism","postmark",
            "lite","profitless","propound","hosiery","ski","irruption","whaler","flagstaff","nevermore","confiscate","vise","whisk","balk","prune","hater","ufo","unpretentious","pertinacious","recline","carouse","caption","lv",
            "static","cranks","converge","ovation","incautious","paunch","sop","tendon","bandy","puss","witless","ostler","baboon","contemn","satiric","mountebank","ok","sucker","cate","inclusion","croup","slanderous",
            "amphibious","basilica","staffs","beneficiary","opprobrious","farcical","infraction","peroration","barony","halcyon","bystander","carboniferous","baste","confounds","alpine","banns","hereupon","hostler","inverness",
            "hu","resonance","foal","procrastination","stationery","nh","pawnbroker","varuna","ioc","plash","persona","sucks","rn","wooer","lapland","lather","walrus","protestation","caretaker","whey","saturnine","slink",
            "calculus","pap","cataclysm","crucify","bureaucracy","consistence","hoover","raucous","browse","icao","liberalism","uptown","wrestler","frothy","basal","chen","clinical","carnation","bicycles","outhouse","charon",
            "fishy","ukraine","optics","persephone","tarnish","washstand","hindostan","sikh","voyager","barb","nebula","arras","newborn","sark","crate","optic","bri","cannibalism","swag","cringe","tiberias","unification",
            "wmo","circa","inscribe","pussy","offal","iso","ochre","vertebrate","vaccination","bun","wraith","brawn","whir","inoculation","sluice","viscera","iota","houseboat","optional","iteration","fere","harmonic",
            "pansies","chunks","infra","pre","wc","warship","attestation","capstan","campfire","whiten","spry","coppice","foamy","sago","crayon","rubicon","oc","parsimonious","hyacinth","teacup","consensus","cocoon",
            "concupiscence","frisky","passer","fag","vixen","brats","literati","pc","contentious","seraglio","supervise","bootless","salubrious","bengali","breviary","crevasse","lath","corfu","scrubs","tine","uranus","chic",
            "crescendo","carver","cobra","overtakes","continence","ns","arran","forensic","whitby","dynastic","tannin","procures","unpropitious","bakery","herbaceous","lush","inauspicious","firebrand","healer","flippancy",
            "reprisal","landau","wrack","gaff","briar","bartender","knickerbockers","cower","fib","pakistan","palpitation","fend","unicorn","hypnotism","smirk","synopsis","samurai","chute","unicameral","crispin","largesse",
            "eschew","unwound","brier","kimono","scab","ares","cremona","crunch","bah","crowbar","reich","coiffure","bronchitis","cacao","reiterate","sunflower","hock","laplace","imo","cuisine","amass","bewitch","butch",
            "seasick","americas","prosy","agnostic","bern","python","uncritical","vagina","ion","gesticulation","caitiff","hussar","tapioca","eucalyptus","ravish","sear","siliceous","seraphic","hub","ofries","vats","canticles",
            "incubation","percussion","stipulate","faro","procreation","ws","falsify","seasonal","ref","pico","fractional","pinafore","fiasco","lige","bayou","litany","moccasin","overlap","bunsen","catarrh","pers","proboscis",
            "buccaneer","mown","americanism","bras","assam","cops","finder","unco","beatific","fertilisation","huh","arson","purblind","supernal","bookish","carbolic","itinerary","almoner","tarn","crony","flier","gander",
            "silica","hoes","underrate","suffocate","hiatus","nationalism","frees","hopper","cowslip","iambic","barrage","casino","blanch","incarceration","popish","cherubs","constipation","seraph","benin","calabash","chios",
            "kat","gelatinous","ccc","flop","moira","rebirth","serb","conscripts","ovary","blunderbuss","recession","satrap","bosh","conscript","condone","moraine","bevis","celibate","insulation","liberals","cc","probate",
            "cramps","motif","accessions","cameras","sealskin","wuss","ar","conch","nite","bahamas","phosphorescence","concertina","reciprocate","indite","pander","coo","invoice","presuppose","buffer","crossbow","reborn",
            "coalesce","reunite","cd","americana","cryptic","palliation","pcb"
        };

        private readonly string LETTERS = "ABCDEFGHIKLMNOPQRSTUVWXYZabcdefghiklmnopqrstuvwxyz";
        private readonly string[] DOUBLES = new[] { "Si", "Sc", "Co", "Ni", "Cu", "Nb", "In", "Sn", "Sb", "Cs", "Hf", "Os", "Pb", "Bi", "Po", "Bh", "Hs", "Cn", "Uup", "Uus", "Uuo", "Ho", "Yb", "Np", "Pu", "Bk", "Cf", "No" };

        private static string[][] RefSolution(string w)
        {

            static IEnumerable<string[]> FormWords(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    yield return new string[0];
                }
                else
                {
                    for (int i = 0; i < Math.Min(word.Length, 3); i++)
                    {
                        string element = char.ToUpper(word[0]).ToString() + word[1..(i + 1)].ToLower();
                        if (ElementDictionary.ELEMENTS.ContainsKey(element))
                        {
                            var current = new string[] { $"{ElementDictionary.ELEMENTS[element]} ({element})" };
                            foreach (var rest in FormWords(word[(i + 1)..]))
                            {
                                yield return current.Concat(rest).ToArray();
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(w))
                return new string[0][];
            return FormWords(w).ToArray();
        }

        [Test, Description("Random English elemental words (100 Tests)")]
        public void RandomEnglishElements()
        {
            for (int i = 0; i < 100; i++)
            {
                var word = ELEMENTAL_WORDS[rng.Next(0, ELEMENTAL_WORDS.Length)];
                var actual = Elements.ElementalForms(word);
                var expected = RefSolution(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

        [Test, Description("Random alphabetic strings (100 Tests)")]
        public void RandomAlphabeticStrings()
        {
            for (int i = 0; i < 100; i++)
            {
                var wordSB = new System.Text.StringBuilder();
                var wordLength = rng.Next(2, 11);
                for (int x = 0; x < wordLength; x++)
                {
                    wordSB.Append(LETTERS[rng.Next(0, LETTERS.Length)]);
                }
                var word = wordSB.ToString();
                var actual = Elements.ElementalForms(word);
                var expected = RefSolution(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

        [Test, Description("Random elemental words with many forms")]
        public void RandomElementsWithManyForms()
        {
            for (int i = 0; i < 5; i++)
            {
                var wordSB = new System.Text.StringBuilder();
                for (int x = 0; x < 5; x++)
                {
                    wordSB.Append(DOUBLES[rng.Next(0, DOUBLES.Length)]);
                }
                var word = wordSB.ToString();
                var actual = Elements.ElementalForms(word);
                var expected = RefSolution(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }
    }
}