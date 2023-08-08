using system;
class Empresa {
    public string RazaoSocial;
    public string CNPJ;

    public Empresa () {
        RazaoSocial = "";
        CNPJ = "";
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

    public virtual float Bruto () {

    } 

    public float Liquido () {

    }

    public float Desconto () {

    }

    public float IR () {

    }

    public float PF () {

    }
}