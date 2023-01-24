using Newtonsoft.Json;

namespace Problem2
{
    public class Hierarchy
    {
        private static Dictionary<string, List<string>> _employees;
        public static void Main()
        {
            Add("Jason", new List<string> { "Jody" });
            Add("Jody", new List<string> { "Stanton", "Andries" });
            Add("Andries", new List<string> { "Roscoe" });

            var result = JsonConvert.SerializeObject(_employees);
            Console.WriteLine(string.Format("Hierarchy: {0}", result));

            var search = "Jason";
            var values = _employees.ContainsKey(search) ? JsonConvert.SerializeObject(_employees[search].ToList().ToArray()) : "No match";
            Console.WriteLine(string.Format("{1}'s Team: {0}", values, search));
        }
        public static void Add(string key, List<string> team)
        {
            if (_employees == null)
            {
                _employees = new Dictionary<string, List<string>> { [key] = team };
            } else
            {
                _employees[key] = team;
            }
        }
    }
}