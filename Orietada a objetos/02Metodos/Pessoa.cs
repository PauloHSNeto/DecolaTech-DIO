namespace _02Metodos
{
    public class Pessoa
    {
        //Metodo 01
        public void apresentar()
        {
            Console.WriteLine("Olá");
        }


        //Metodo 02

        public void apresentar(string nome)
        {
            Console.WriteLine("Ola"+ nome);
        }



        //Metodo 03
                       
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Ola"+ nome+ "Você tem "+ idade+ " anos.");
        }

    }
}