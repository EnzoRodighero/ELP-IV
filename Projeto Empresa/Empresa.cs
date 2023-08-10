using system;
class Empresa {
    public string RazaoSocial;
    public string CNPJ;
    ´public int NumFunc;

    public Empresa () {
        RazaoSocial = "";
        CNPJ = "";
        NumFunc = 0;
    }
    
    public Empresa (string pRazaoSocial, string pCNPJ) {
        RazaoSocial = pRazaoSocial;
        CNPJ = pCNPJ;
    }

    ~Empresa () {

    }

    public string GetSetRazaoSocial {
        get => RazaoSocial;
        set => RazaoSocial = value; 
    }

    public string GetSetCNPJ {
        get => CNPJ;
        set => CNPJ = value;
    }

    public int GetSetNumFunc {
        get => NumFunc;
        set => NumFunc = value;
    }

    //Processa Folha?
}