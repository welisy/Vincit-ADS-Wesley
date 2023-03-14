// Laços de Repetição
//Inicio
//Condição de Parada
//Incremento (++/--) Decremento

//FOR -- Só Vai!
/*int contador;

for(contador = 0; contador < 10; contador ++) {
  Console.WriteLine("Wesley Diogo");
  Console.WriteLine(contador);
}
*/

//While -- Pergunta para entrar
/*
 int quantidade;
  Console.WriteLine("Informe quantas vezes:");
  quantidade = int.Parse(Console.ReadLine()); 

  while (quantidade > 0) {
    Console.WriteLine("welis");
    quantidade--;
  }
Console.ReadKey();
*/

  int opcao;
//Laço Repita ....Até --- Pergunta para sair
do {
  Console.WriteLine("Seja bem vindo ao sistema X-Shark");
  Console.WriteLine("---------------------------------");
  Console.WriteLine("01 - Cadastro de Clientes");
  Console.WriteLine("02 - Cadastro de Produtos");
  Console.WriteLine("03 - Cadastro de Fornecedores");
  Console.WriteLine("---------------------------------");
  Console.WriteLine("99 - Sair do Programa");
  opcao = int.Parse(Console.ReadLine());

  if (opcao == 1) //Operador == igual 
  {
    Console.Clear(); //Limpa Tela
    Console.WriteLine("Bem vindo ao Cadastro de clientes");
    Console.WriteLine("Digite seu nome:");
    Console.ReadKey();
  }
} while( opcao != 99 );

Console.ReadKey();