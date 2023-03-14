
//Estrutura condicional SE(if)
double valorMesada; // Declaração de variavel.
Console.WriteLine("Qual é o valor da sua mesada?? ");
valorMesada = double.Parse(Console.ReadLine()); // lê e recebe o valor digitado na linha.

if(valorMesada >= 15) {  // Condição SE Valor da Variavel for menor que 15...
  Console.WriteLine("O valor da entrada do cinema é R$15,00 , Você pode ir no cinema!"); // Aparecerá essa mensagem.
} else { // SE NÂO..
  Console.WriteLine("Você não vai poder ir no cinema :/ "); // Aparecerá essa outra mensagem.
}

Console.ReadKey(); // Espera uma tecla ser digitada para encerrar o programa.