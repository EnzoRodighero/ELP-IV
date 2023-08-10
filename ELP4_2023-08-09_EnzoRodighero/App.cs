/*Desenvolver uma aplicação que determine a folha de pagamento dos funcionários de uma empresa. 
Considerar que todo funcionário recebe salário base e gratificação de produtividade. 
Para os funcionários que exercem cargo de chetia, a empresa paga uma gratificação adicional. 
Considerar que sobre o salario bruto e feito um desconto para fins de imposto de renda, conforme a tabela a seguir:*/
using system;

class App {

    public App () {

    }

    public App () {

    } 

    ~App () {

    }
    static void Main () {
        string Nome; 
        int Idade;
        char Sexo; 
        float SalBase;
        string Matricula; 
        char Cargo; 
        float GratProd;  
        int NumDep;
        string Setor; 
        float AddChefia;

        Interface Inter = new Interface ();
        Inter.PecaDadosFuncionario (ref Nome, ref Idade, ref Sexo, ref SalBase, ref Matricula, ref Cargo);

        if (Cargo == 'C') {
            Inter.PecaDadosChefe (ref Setor, ref AddChefia);
        }

        Inter.MostraDadosFuncionario (ref Nome, ref Idade, ref Sexo, ref SalBase, ref Matricula, ref Cargo);

        if (Cargo == 'C') {
            Inter.MostraDadosChefe (ref Setor, ref AddChefia);
        }
        //??
    }    
}