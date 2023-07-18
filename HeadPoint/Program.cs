static IEnumerable<IGrouping<string, string>> ToEnumerableGroupString(IEnumerable<string> enumerableString)
{
    return enumerableString.GroupBy(s =>
    {
        var sortedString = s.ToLower().ToArray();
        Array.Sort(sortedString);
        return new string(sortedString);
    });
}

// Проверка
var wordArray = new string[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };

var wordGroups = ToEnumerableGroupString(wordArray);

foreach (var group in wordGroups)
{
    foreach (var word in group)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine("-----------------");
}