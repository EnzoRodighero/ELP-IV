using system;
class Apoio: Funcionario {

    public Apoio () {
        
    }

    ~Apoio () {

    }

    public float FornAuxilioEdu () {

        if (NumDep <= 5) {
            return (base.NumDep * 60);
        }

        else {
            return 300;
        }
    }

    public override float FornSalLiq () {
        return (base.FornSalbruto () + FornAuxilioEdu ());
    }
}