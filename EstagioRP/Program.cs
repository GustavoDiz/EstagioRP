namespace EstagioRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QUESTÃO 1
            int soma = 0;
            int k = 0;
            int indice = 13;
            while(k < indice)
            {
                k++;
                soma += k;
            }
            imprimir(soma);

            //QUESTÃO 2
            Console.WriteLine("Informe o numero >:_");
            int num = int.Parse(Console.ReadLine());
            if (fibonnacci(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência");
            }
            else
            {
                Console.WriteLine($"O número {num} não pertence à sequência");
            }

            //QUESTÃO 5
            Console.WriteLine(inverter("Gustavo"));
        }

        static string inverter(string txt)
        {
            char[] invertido = txt.ToCharArray();
            for (int i = invertido.Length - 1, j = 0; i >= 0; i--, j++)
            {
                invertido[j] = txt[i];
            }

            return new string(invertido);
        }

        static void imprimir(int soma)
        {
            Console.WriteLine(soma);
        }
        
        static bool fibonnacci(int n)
        {
            if(n <= 1)
                return true;

            int a = 0;
            int b = 1;
            int proximo;

            for (int i = 2; i < n; i++)
            {
                proximo = a + b;
                a = b;
                b = proximo;

                if(proximo == n)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
