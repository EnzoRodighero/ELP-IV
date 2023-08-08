using system;
class Chefe: Funcionario {
    public string Setor;
    public float AddChefia;

    public Chefe () {
        Setor = "";
        AddChefia = 0;
    }

    public Chefe (string pSetor, float pAddChefia) {
        Setor = pSetor;
        AddChefia = pAddChefia;
    }

    ~Chefe () {

    }

    public string GetSetSetor {
        get => Setor;
        set => Setor = value;
    } 

    public float GetSetGratificacao {
        get => Gratificacao;
        set => Gratificacao = value;
    }

    public float GetSetAddChefia {
        get => AddChefia;
        set => AddChefia = value;
    }

    public override float Bruto () {

    } 
}