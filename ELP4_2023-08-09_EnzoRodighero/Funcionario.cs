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

    public virtual float FornINSS () {
        return SalBase * 0.1;
    }

    public float FornecaIR () {
        if (SalBase <= 2112) {
            return 0;
        }

        else if (SalBase > 2112 && SalBase <= 2826.65) {
            return SalBase * 0.075 - 158.40;
        }

        else if (SalBase > 2886.65 && SalBase <= 3751.05)  {
            return SalBase * 0.15 - 370.40;
        }

        else if (SalBase > 3751.05 && SalBase <= 4664.68) {
            return SalBase * 0.225 - 651.73;
        }

        else {
            return SalBase * 0.275 - 884.96;
        }
    }

    public float FornDesc () {
        return (FornINSS () + FornecaIR ());
    }

    public virtual float FornBruto () { 
        return SalBase + GratProd;
    }

    public virtual float FornSalLiq () {
        return (FornSalbruto () - FornDesc ())
    } 
}