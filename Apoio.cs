using system;
class Apoio: Funcionario {
    // public float AuxilioEducacao;

    public Apoio () {
        AuxilioEducacao = 0;
    }

    public Apoio (float pAuxilioEducacao) {
        AuxilioEducacao = pAuxilioEducacao;
    }

    ~Apoio () {

    }

    // public float GetSetAuxilioEducacao {
        // get => AuxilioEducacao;
        // set => AuxilioEducacao = value;
    // } 
}