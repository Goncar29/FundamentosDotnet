using Humanizer;

Console.WriteLine("Por favor ingrese un nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años");


/* ToWords(new System.Globalization.CultureInfo("es")) El ToWords nos sirve para que el numero que ingrese en este caso el usuario aparezca en letra, despues el new System... sirve en caso de que si tu sistema operativo lo tienes en ingles lo que hace es traducir de numero a texto pero al idioma que elijas, para este caso no era necesario pero
se lo coloco para ejemplo */