using system;
class Funcionario: Pessoa {
    public float SalBase; 
    public string Matricula; 
    public char Cargo; 
    public float GratProd;
    public int NumDep;

    public Funcionario () {
        SalBase = 0;
        Matricula = "";
        Cargo = '';
        GratProd = 0;
        NumDep = 0;
    }

    public Funcionario (float pSalBase, string pMatricula, string pCargo, float pgratProd, int pNumDep) {
        SalBase = pSalBase;
        Matricula = pMatricula;
        Cargo = pCargo;
    }

    ~Funcionario () {

    }

    public float GetSetSalBase {
        get => SalBase;
        set => SalBase = value;
    }

    public int GetSetMatricula {
        get => SalBase;
        set => SalBase = value;
    }

    public string GetSetCargo {
        get => Cargo;
        set => Cargo = value;
    }

    public float GetSetGratProd {
        get => GratProd;
        set => GratProd = value;
    } 

    public int GetSetNumDep {
        get => NumDep;
        set => NumDep = value;
    }
}