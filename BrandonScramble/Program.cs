var scramble = "asdasd;askdadl;asd;asdlas;asdalsda;asdla;ajsda;kakahsd";
var keyValues = new Dictionary<char, int>();

var search = 'k';
foreach (char item in scramble)
{
    if (item == search)
    {
        if (!keyValues.ContainsKey(item)) { keyValues.Add(item, 1); } else { keyValues[item]++; }
    }
}

Console.WriteLine(keyValues.Values.First());