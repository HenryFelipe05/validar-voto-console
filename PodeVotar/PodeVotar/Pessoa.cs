namespace PodeVotar
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa(string pessoaNome, int pessoaIdade) 
        {
            Nome = pessoaNome;
            Idade = pessoaIdade;
        }

        public bool PodeVotar()
        {
            if (this.Idade < 16)
                return false;
            else if (this.Idade >= 16 && this.Idade <= 17)
                return true;
            else
                return true;
        }
    }
}
