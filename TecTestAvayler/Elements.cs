namespace TecTestAvayler
{
    public class Elements
    {
        public static string[][] ElementalForms(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return new string[0][];
            }

            // Dictionary for memoisation
            var dict = new Dictionary<string, List<List<string>>>();

            // Use a recursive function to find all valid combinations
            var result = FindCombinations(word.ToLower(), 0, dict);

            // Convert the result to the required format (array of arrays)
            return result.Select(combination => combination.ToArray()).ToArray();
        }

        private static List<List<string>> FindCombinations(string word, int start, Dictionary<string, List<List<string>>> dict)
        {
            // Base case: if we have reached the end of the string, return a list with an empty list
            if (start == word.Length)
            {
                return new List<List<string>> { new List<string>() };
            }

            // If we have already computed combinations for this starting index, return the cached result
            string remaining = word.Substring(start);
            if (dict.ContainsKey(remaining))
            {
                return dict[remaining];
            }

            // List to store all possible combinations
            var combinations = new List<List<string>>();

            // Try to match element symbols of length 1, 2, and 3
            for (int i = 1; i <= 3 && (start + i) <= word.Length; i++)
            {
                string symbol = word.Substring(start, i).ToLower();
                // Check if the symbol matches any element in the dictionary (case-insensitive)
                var matchingElement = ElementDictionary.ELEMENTS.FirstOrDefault(e => e.Key.Equals(symbol, StringComparison.OrdinalIgnoreCase));

                if (matchingElement.Key != null)
                {
                    string elementName = matchingElement.Value;
                    string originalSymbol = matchingElement.Key;
                    int nextStart = start + i;

                    // Recursively find combinations for the rest of the string
                    var subCombinations = FindCombinations(word, nextStart, dict);

                    // For each sub-combination, add the current element to the beginning
                    foreach (var subCombination in subCombinations)
                    {
                        var newCombination = new List<string> { $"{elementName} ({originalSymbol})" };
                        newCombination.AddRange(subCombination);
                        combinations.Add(newCombination);
                    }
                }
            }

            // Cache the result for the remaining string
            dict[remaining] = combinations;
            return combinations;
        }
    }
    public static class ElementDictionary
    {
        public static readonly Dictionary<string, string> ELEMENTS = new Dictionary<string, string>
            {
                {"H", "Hydrogen"}, {"He", "Helium"}, {"Li", "Lithium"}, {"Be", "Beryllium"}, {"B", "Boron"},
                {"C", "Carbon"}, {"N", "Nitrogen"}, {"O", "Oxygen"}, {"F", "Fluorine"}, {"Ne", "Neon"},
                {"Na", "Sodium"}, {"Mg", "Magnesium"}, {"Al", "Aluminium"}, {"Si", "Silicon"}, {"P", "Phosphorus"},
                {"S", "Sulfur"}, {"Cl", "Chlorine"}, {"Ar", "Argon"}, {"K", "Potassium"}, {"Ca", "Calcium"},
                {"Sc", "Scandium"}, {"Ti", "Titanium"}, {"V", "Vanadium"}, {"Cr", "Chromium"}, {"Mn", "Manganese"},
                {"Fe", "Iron"}, {"Co", "Cobalt"}, {"Ni", "Nickel"}, {"Cu", "Copper"}, {"Zn", "Zinc"},
                {"Ga", "Gallium"}, {"Ge", "Germanium"}, {"As", "Arsenic"}, {"Se", "Selenium"}, {"Br", "Bromine"},
                {"Kr", "Krypton"}, {"Rb", "Rubidium"}, {"Sr", "Strontium"}, {"Y", "Yttrium"}, {"Zr", "Zirconium"},
                {"Nb", "Niobium"}, {"Mo", "Molybdenum"}, {"Tc", "Technetium"}, {"Ru", "Ruthenium"}, {"Rh", "Rhodium"},
                {"Pd", "Palladium"}, {"Ag", "Silver"}, {"Cd", "Cadmium"}, {"In", "Indium"}, {"Sn", "Tin"},
                {"Sb", "Antimony"}, {"Te", "Tellurium"}, {"I", "Iodine"}, {"Xe", "Xenon"}, {"Cs", "Caesium"},
                {"Ba", "Barium"}, {"La", "Lanthanum"}, {"Ce", "Cerium"}, {"Pr", "Praseodymium"}, {"Nd", "Neodymium"},
                {"Pm", "Promethium"}, {"Sm", "Samarium"}, {"Eu", "Europium"}, {"Gd", "Gadolinium"}, {"Tb", "Terbium"},
                {"Dy", "Dysprosium"}, {"Ho", "Holmium"}, {"Er", "Erbium"}, {"Tm", "Thulium"}, {"Yb", "Ytterbium"},
                {"Lu", "Lutetium"}, {"Hf", "Hafnium"}, {"Ta", "Tantalum"}, {"W", "Tungsten"}, {"Re", "Rhenium"},
                {"Os", "Osmium"}, {"Ir", "Iridium"}, {"Pt", "Platinum"}, {"Au", "Gold"}, {"Hg", "Mercury"},
                {"Tl", "Thallium"}, {"Pb", "Lead"}, {"Bi", "Bismuth"}, {"Po", "Polonium"}, {"At", "Astatine"},
                {"Rn", "Radon"}, {"Fr", "Francium"}, {"Ra", "Radium"}, {"Ac", "Actinium"}, {"Th", "Thorium"},
                {"Pa", "Protactinium"}, {"U", "Uranium"}, {"Np", "Neptunium"}, {"Pu", "Plutonium"}, {"Am", "Americium"},
                {"Cm", "Curium"}, {"Bk", "Berkelium"}, {"Cf", "Californium"}, {"Es", "Einsteinium"}, {"Fm", "Fermium"},
                {"Md", "Mendelevium"}, {"No", "Nobelium"}, {"Lr", "Lawrencium"}, {"Rf", "Rutherfordium"}, {"Db", "Dubnium"},
                {"Sg", "Seaborgium"}, {"Bh", "Bohrium"}, {"Hs", "Hassium"}, {"Mt", "Meitnerium"}, {"Ds", "Darmstadtium"},
                {"Rg", "Roentgenium"}, {"Cn", "Copernicium"}, {"Nh", "Nihonium"}, {"Fl", "Flerovium"}, {"Mc", "Moscovium"},
                {"Lv", "Livermorium"}, {"Ts", "Tennessine"}, {"Og", "Oganesson"},
                {"Uut", "Ununtrium"}, {"Uup", "Ununpentium"}, {"Uus", "Ununseptium"}, {"Uuo", "Ununoctium"}
            };
    }
}
