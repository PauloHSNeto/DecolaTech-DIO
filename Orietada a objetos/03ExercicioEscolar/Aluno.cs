using _03ExercicioEscolar;


namespace _03ExercicioEscolar
{
    public class Aluno
    {
        //Atributos
        public string nome;
        public double nota1, nota2;
        //Metodos 
        public double media()
        {
            return (nota1+nota2)/2;
        }
        //Situação

        public string situacao(double media)
        {
            return media >= 7 ? "aprovado": "reprovado"; 
        }

        public void mensagem()
        {   //Obter média
            double obterMedia = media();
            // Obter situação
           
           string situacaoo = situacao(obterMedia);

            //Mensagem
        
            Console.WriteLine(nome+" está " + situacaoo + " com media "+ obterMedia);


        }


    }
}