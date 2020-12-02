namespace exercicio_0212.Alunos
{
    public class Aluno
    {
        public string nome;
        public string curso; 
        public string RG;
        public int idade;
        public bool bolsista;
        public float mediafinal;
        public float valormensalidade;

        public float vermedia;

        public float vermedialuno(){
            return this.mediafinal;
        }

        public float VerMensalidade(){
            float valor;
            if(this.bolsista == true){
                valor = this.valormensalidade * 0.5f;
            }else{
                valor = this.valormensalidade;
            }
            return valor;
        }
    }
}