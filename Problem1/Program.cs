using System.Text;

var value = "Users, User Groups, User Activity Log, Report Designer, Report Activity Log, Security, Security Log, Security Access, Security Management, Databases, Database Management, Database Control, Printers, Printer Control";
var values = value.Split(',');
var search = "ers";
var sb = new StringBuilder { Length = 0 };

foreach (var item in values)
{
    var current = item.Trim().ToLower();
    if (current.Contains(search.ToLower()) || current.StartsWith(search.ToLower())) { sb.AppendLine(string.Format("{0}", item.Trim())); }
}

var result = sb.ToString();
if (result.Length == 0) { result = "No match found"; }
Console.WriteLine(result);
