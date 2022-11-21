using ExemploFundamentos.Common.Models;





// Pessoa p = new Pessoa();

// /*
// Instancia da classe pessoa
// Atribui o nome e idade para pessoa
// Faz a pessoa se apresentar
// */

// p.Nome = "Douglas";
// p.Idade = 34;
// p.Apresentar();

















// List<string> listasString = new List<string>();

// listasString.Add("SP");
// listasString.Add("BA");
// listasString.Add("MG");
// listasString.Add("RJ");


// Console.WriteLine($"Itens na minha lista: {listasString.Count} - Capacidade: {listasString.Capacity}");

// listasString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listasString.Count} - Capacidade: {listasString.Capacity}");

// listasString.Remove("MG");

//Console.WriteLine($"Itens na minha lista: {listasString.Count} - Capacidade: {listasString.Capacity}");






// for(int contador = 0; contador < listasString.Count; contador++)
// {
//     Console.WriteLine($"Posição n. {contador} - {listasString[contador]}");
// }

// int contadorForeach = 0;
// foreach(string item in listasString)
// {
//     Console.WriteLine($"Posição n. {contadorForeach} - {item}");
//     contadorForeach++;
//}







































// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// //percorrendo o Array com o FOR = necessita contador

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição n. {contador} - {arrayInteiros[contador]}");
//}
































//percorrendo o Array com o FOREACH = nao necessita
//foreach(int valor in arrayInteiros)
// {
// Console.WriteLine(valor);   
// }



































// Pessoa pessoal = new Pessoa();
// pessoal.Nome = "Douglas";
// pessoal.Idade = 34;
// pessoal.Apresentar();














// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;    

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;  

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break; 

//         default:
//             Console.WriteLine("Opção inválida");
//             break;      
//     }

// }

// Console.WriteLine("O programa se encerrou.");


















// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");




















// int numero = 5;
// int contador = 0;
// int auxiliar = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($" {contador + 1} Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }

// }























// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



//using ExemploFundamentos.Models;    


// int numero = 5;

// //Console.WriteLine($"{numero} x 1 = {numero * 1}");

// for (int contador = 0; contador <=10; contador++)
// {
//     Console.WriteLine("${numero} x {contador} = {numero * contador}");
//}