namespace MBGestaoEscolarAN.Entities
{
    public class Aluno:Pessoa
    {
        private int AlunoId;
       private string matricula;
        private DateTime dataNascimento;
        private string endereco;
        private string statusAluno;
        private DateTime dataCadastro;

        public int AlunoId1 { get => AlunoId; set => AlunoId = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string StatusAluno { get => statusAluno; set => statusAluno = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }
}
