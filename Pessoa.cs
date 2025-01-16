class Pessoa{
    public Pessoa(string nome, string genero,int idade, double peso, double altura)
    {
        Console.WriteLine("Vamos calcular seu IMC... ");

        pesoIdeal(genero, idade, peso, altura);
    }

    private void pesoIdeal(string genero, int idade, double peso, double altura)
    {
        //IMC = Peso/(altura*altura)
        
        
        double imc = peso/(altura*altura);
        
        
        if(imc<18.5)
        {   
            Console.WriteLine(imc);
            Console.WriteLine("Abaixo do Peso ");
        }
            
            
        
        else if (imc > 18.5 && imc < 24.9)
            {   
                Console.WriteLine(imc);
                Console.WriteLine("Peso Ideal");
            }

        
        else if(imc > 24.9)
            {   
                Console.WriteLine(imc);
                Console.WriteLine("Acima do Peso");
            }
                


            
        

    }
}