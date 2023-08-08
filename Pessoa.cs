using system;
abstract class Pessoa {
    protected string Nome; 
    protected int Idade; 
    protected char Sexo; 

    public Pessoa () {
        Nome = "";
        Idade = 0;
        Sexo = '';
    }

    
    public Pessoa (string pNome, int pIdade, char pSexo) {
        Nome = pNome;
        Idade = pIdade;
        Sexo = pSexo;
    }

    ~Pessoa () {

    }
    
    public string GetSetNome {
        get => Nome;
        set => Nome = value;
    }

    public int GetSetIdade {
        get => Idade;
        set => Idade = value;
    }

    public int GetSetIdade {
        get => Sexo;
        set => Sexo = value;
    }

}