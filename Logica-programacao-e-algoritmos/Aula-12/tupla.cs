using static System.Console;
var clodoaldo = (34,5000.34, "heitor", "senai", 'b');
Write($"a idade do clodoaldo {clodoaldo.Item1}");
Write($"o nome do filho do clodoaldo{clodoaldo.Item3}");
clodoaldo.Item1 = 54;
Write($"idade do clodoaldo {clodoaldo.Item1}");
(int, int, int) numeros = (1, 2, 5);
Write($"numeros {numeros.Item1}, {numeros.Item2}, {numeros.Item3}");