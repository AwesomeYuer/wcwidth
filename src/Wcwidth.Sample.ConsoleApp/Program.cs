// See https://aka.ms/new-console-template for more information
using Wcwidth;
var s = "💩$囍♂ ";
Console.WriteLine(s);
Console.WriteLine();
Console.WriteLine($@"""{s}"".{nameof(s.Length)} = {s.Length}");

var length = s
            .Select(
                    (x) =>
                    {
                        var r = UnicodeCalculator.GetWidth(x);
                        Console.WriteLine($"{x}: {r}");
                        return r;
                    })
            .Sum();
Console.WriteLine();
// ♂ 错误 width 应为 2
Console.WriteLine($@"""{s}"".SumUnicodeCalculator.GetWidth = {length}");
