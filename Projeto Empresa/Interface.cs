using system;
class Interface {
    public Interface () {

    } 

    ~Interface () {

    }

    //Pessoa, Funcionario, Chefe, Apoio
    //ler e mostrar os dados do chefe e demais classes herdadas de funcionário dentro de um método só, ou ter um método para cada? 

    public void PecaDadosFuncionario (ref string pNome, ref int pIdade, ref char pSexo, 
    ref float pSalBase, ref string pMatricula, ref char pCargo, ref float pGratProd, ref int pNumDep
    ref string pSetor, ref float pAddChefia) {
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

        Console.WriteLine ("Insira Gratificacao de Producao: ");
        pGratProd = float.Parse (Console.ReadLine ());

        Console.WriteLine ("Insira Numero de Dependentes: ");
        pNumDep = int.Parse (Console.ReadLine ());
    }

    public void PecaDadosChefe (ref string pSetor, ref float pAddChefia) {
        Console.WriteLine ("insira o setor: ");
        pSetor = Console.ReadLine ();

        Console.WriteLine ("insira o Adicional de chefia: ");
        pAddChefia = float.Parse (Console.ReadLine ());
    } 

    public void PecaDadosEmpresa (ref string pRazaoSocial, ref string pCNPJ, ref int pNumFunc) {
        Console.WriteLine ("Insira RazaoSocial: ");
        pRazaoSocial = Console.ReadLine ();

        Console.WriteLine ("Insira CNPJ: ");
        pCNPJ = Console.ReadLine ();

        Console.WriteLine ("Insira numero de funcionarios: ");
        pNumFunc = Interface.Parse (Console.ReadLine ());
    }

    public void MostraDadosFuncionario (string pNome, int pIdade, char pSexo, 
    float pSalBase, string pMatricula, char pCargo, float pGratProd, int pNumDep) {
        Console.WriteLine ("Nome: {0}", pNome); 
        Console.WriteLine ("Idade: {0}", pIdade); 
        Console.WriteLine ("Sexo: {0}", pSexo); 
        Console.WriteLine ("Salario base: {0}", pSalBase); 
        Console.WriteLine ("Matricula: {0}", pMatricula); 
        Console.WriteLine ("Cargo: {0}", pCargo); 
        Console.WriteLine ("Gratificacao de producao: {0}", pGratProd); 
        Console.WriteLine ("Numero de dependentes: {0}", pNumDep); 
    }

    public void MostraDadosChefe (string pSetor, float pAddChefia) {
        Console.WriteLine ("Setor: {0}", pSetor); 
        Console.WriteLine ("Adicional de chefia: {0}", pAddChefia); 
    }

    public void MostraDadosEmpresa (string pRazaoSocial, string pCNPJ, int pNumFunc) {
        Console.WriteLine ("Razao social: {0}", pRazaoSocial);
        Console.WriteLine ("CNPJ: {0}", pCNPJ);
        Console.WriteLine ("Numero de funcionarios: {0}", pNumFunc);
    }
}