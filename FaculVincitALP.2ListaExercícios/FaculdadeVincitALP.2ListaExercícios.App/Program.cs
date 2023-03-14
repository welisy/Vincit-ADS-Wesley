/*
double salarioAtual; 
double aumento;

Console.WriteLine("Informe seu salario atual:");
salarioAtual = double.Parse(Console.ReadLine());

//porcentagem = valor divido por 100
//30% = 30 / 100

aumento = salarioAtual * 30 /100;
Console.WriteLine(aumento);
Console.WriteLine(salarioAtual + aumento);
*/

//------------------------------------------------------------------------//

/*
int numero;
int contador; 

Console.WriteLine("Digite a tabuada que você quer saber:");
numero = int.Parse(Console.ReadLine());

for(contador = 0; contador <= 10; contador++) {
    Console.WriteLine("{0} x {1} = {2}", numero, contador, numero * contador);
}

Console.ReadKey();
*/

//------------------------------------------------------------------------//


int opcao;

Console.WriteLine("Seja Bem vindo ao sistema academico");
Console.WriteLine("Versão 1.0");
Console.WriteLine("Desenvolvido por Wesley");
Console.Beep();

do {
Console.WriteLine("Digite a opção desejada: ");
Console.WriteLine("1 - Cadastro de Alunos");
Console.WriteLine("2 - Cadastro de Professora");
Console.WriteLine("3 - Cadastro de Funcionário");
Console.WriteLine("99 - Sair do Programa");
opcao = int.Parse(Console.ReadLine());

if (opcao == 1) {
    CadastroAluno();
}

if (opcao == 2) {
    CadastroProfessor();
}

if (opcao == 3) {
    CadastroFuncionario();
}

} while (opcao != 99);


//PROCEDIMENTO
//Não é função, pois funções retornam valores.
static void CadastroAluno() {
    string nomeAluno;

    Console.WriteLine("Cadastro de Alunos");
    Console.WriteLine("Nome:");
    nomeAluno = Console.ReadLine();
    
    Console.WriteLine("RA:");
    Console.WriteLine("Cidade");
    Console.WriteLine("UF");
    Console.WriteLine("Data Nascimento");
    Console.WriteLine("RG");
    Console.WriteLine("CPF");
    Console.WriteLine("Email");
    Console.WriteLine("Celular");
    Console.WriteLine("CEP");
    Console.WriteLine("Nome da Mãe");
}

static void CadastroProfessor() {
    Console.WriteLine("Nome:");
    Console.WriteLine("Cidade");
    Console.WriteLine("UF");
    Console.WriteLine("Data Nascimento");
    Console.WriteLine("RG");
    Console.WriteLine("CPF");
    Console.WriteLine("Email");
    Console.WriteLine("Celular");
    Console.WriteLine("CEP");
    Console.WriteLine("Nome da Mãe");
}

static void CadastroFuncionario() {
    Console.WriteLine("Nome:");
    Console.WriteLine("RA:");
    Console.WriteLine("Cidade");
    Console.WriteLine("UF");
    Console.WriteLine("Data Nascimento");
    Console.WriteLine("RG");
    Console.WriteLine("CPF");
    Console.WriteLine("Email");
    Console.WriteLine("Celular");
    Console.WriteLine("CEP");
    Console.WriteLine("Nome da Mãe");
}

Console.ReadKey();
