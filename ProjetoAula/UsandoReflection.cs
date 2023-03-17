// See https://aka.ms/new-console-template for more information


using ConsoleAulas;
using System.Reflection;

var aulas = new Aulas() { 
    DataInicio = null,
    Nome = "Aula de Portugues",
    Disciplina = "Portugues",
    QuantidadeAulasSemanais = 5
};
Console.WriteLine(aulas.GetType().Name);
Console.WriteLine(aulas.GetType());
Console.WriteLine(aulas.GetType().GetProperties());

var propriedades = aulas.GetType().GetProperties();
foreach(var prop in propriedades)
{
    if(prop.GetValue(aulas) == null)
    {
        Console.WriteLine($"A propriedade {prop.Name} está nulo");
    }
    Console.WriteLine(prop.Name);
    Console.WriteLine(prop.GetValue(aulas));
}



//var aulas = new Aulas() {
//    DataInicio = null,
//    Disciplina = "Portugues",
//    Nome = "Aula Interna",
//    QuantidadeAulasSemanais = 5
//};

//Console.WriteLine(aulas.GetType());
//Console.WriteLine(aulas.GetType().Name);
//Console.WriteLine(aulas.GetType().Attributes);

//var propriedades = aulas.GetType().GetProperties();
//foreach (var propriedade in propriedades)
//{
//    var valor = propriedade.GetValue(aulas);

//    if(propriedade.Name == "DataInicio")
//    {
//        Console.WriteLine("Passamos pela data agora");
//    }

//    if (valor == null)
//    {
//        Console.WriteLine("O valor está nulo");
//    }
//    else
//    {
//        Console.Write($"A propriedade atual é: {propriedade.Name} | | ");
//        Console.Write($"O valor atual é: {propriedade.GetValue(aulas)}");
//        Console.WriteLine();
//        Console.WriteLine("______________________________");
//    }

//}
