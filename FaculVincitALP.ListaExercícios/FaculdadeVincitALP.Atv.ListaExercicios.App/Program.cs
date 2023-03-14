Console.WriteLine("lista de Exercícios");
/*
1) Dado o seguinte algoritmo:
programa escrever_valor_de_A_e_B
var
inteiro: A, B;
início
A <- 1;
B <- 2;
   se (A > B) então
      A <- 5;
   senão B <- 10;
escreva(A,B);
fim.

O valor de A e B, respectivamente:
a) 5,2 
b) 5,10
c) 1,2
d) 2,1
->e) nenhuma das anteriores.
*/

int A,B; 
A = 1;
B = 2;

if (A > B) {
    A = 5;
} else {
    B = 10;
}
Console.WriteLine(A);
Console.WriteLine(B);
Console.ReadKey();


/*
2) Podemos classificar os valores abaixo:
"Teste"
24
24.5
-45

a) Inteiro, Inteiro, Real, Lógico
b) Texto, Inteiro, Real, Texto
->c) Texto, Inteiro, Real, Inteiro
d) Lógico, Inteiro, Real, Real
e) nenhuma das anteriores.

3) Sobre o algoritmo abaixo:
programa exe3
var
numero: inteiro
início
escreva("Digite um número: ")
leia(numero)
se numero > 80 entao
    escreva("O número é maior que 80")
senao
    se numero < 25 
       escreva("O número é menor que 25")
    senao       
       escreva("O número é maior que 25")
fim.
Se o usuário digitar o valor 50, será impresso:
a) "O número é maior que 80"
b) "O número é menor que 25"
->c) "O número é maior que 25"
d) não haverá impressão, pois o valor é inválido
e) nenhuma das anteriores.

4) Sobre o exercício anterior, se o usuário digitar o valor 80, será impresso:
a) "O número é maior que 80"
->b) "O número é menor que 25"
c) "O número é maior que 25" 
d) não haverá impressão, pois o valor é inválido
e) nenhuma das anteriores.

5) O valor correto para nome de variável:
a) int 1_Nome;
->b) int valor;
c) char vár1;
d) char paçoca[10];
e) Nenhuma das anteriores

Lógica:
1) Seja x a quantidade de segundos em 3 horas, y a quantidade de meses em 150 anos e z a quantidade de metros em 1,8 km, então:
a) x>y>z
b) x > y = z
c) x = y < z
d) x<z=y
e) x<y<z

*/
Console.ReadKey();