using system;
class Interface {
    public Interface () {

    } 

    ~Interface () {

    }

    //Pessoa, Funcionario, Chefe, Apoio
    public void PecaDadosFuncionario (ref string pNome, ref int pIdade, ref char pSexo, 
    ref float PsalBase, ref string pMatricula, ref char pCargo, ref float pGratProd, ref int pNumDep
    ref string pSetor, ref float pAddChefia,
    ref float AuxilioEducacao) {
        Console.WriteLine ("Insira Nome: ");
        pNome = Console.ReadLine ();

        Console.WriteLine ("Insira Idade: ");
        pIdade = int.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Sexo (M/F): ");
        pSexo = Console.ReadLine ().ToUpper ();

        Console.WriteLine ("Insira Salario Base: ");
        pSalBase = float.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Matricula: ");
        pMatricula = int.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Cargo (C/F/A): ");
        pCargo = Console.ReadLine ().ToUpper ();
        
        if (pCargo == 'C') {
            Console.WriteLine ("Insira Adicional de Chefia: ");
            pAddChefia = float.Parse (Console.ReadLine ());
        }

        Console.WriteLine ("Insira Gratificacao de Producao: ");
        pGratProd = float.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Numero de Dependentes: ");
        pNumDep = int.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Setor: ");
        pSetor = Console.ReadLine ();


        // Console.WriteLine ("Insira Auxilio Educacao: ");
        // pAuxilioEducacao = float.Parse (Console.ReadLine ());
    } 


}