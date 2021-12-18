using _04Exercicio;

namespace _04Exercicio
{
    public class Pessoa
    {
      public double peso;
      public double altura;
      public double imc(double peso,double altura)
      {
            return peso/(altura*altura);
      } 

      public string resposta()
      {
        double imcs = imc(peso,altura);
            if (imcs<18.5)
            {
                return "Abaixo do Peso";
            }
            else if (imcs<25.0)
            {
                return "Peso Normal";
            }
            else if (imcs<30.0)
            {
                return "Acima do Peso";
            }
            else if (imcs<35.0)
            {
                return"Obesidade";
            }
            
            else if (imcs<40.0)
            {
                return "Obesidade 2";
            }
            else if (imcs>=45.0)
            {
                return  "Obesidade 3";
            }
            else
            {
                return "Erro";
            }
       
      }
    public void mensagem()
    { 
     Console.WriteLine("Seu imc é "+ imc(peso,altura)+ " você está " + resposta());
    }    
    }
}