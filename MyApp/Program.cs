using myStringTypeAlias = System.String; // Alias para o tipo String

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // na maioria dos casos se usa double para numeros reias e int para numeros inteiros
            // null ou void são valores que representam a ausência de valor void para retornos de métodos e null para variáveis
            int? idade = null; // ? para permitir valores nulos
            string? myNull = null;
            object myObject = "qualquer coisa"; // object is a base type for all data types
            sbyte mySbyte = -128; // -128 to 127
            short myShort = 32767; // -32,768 to 32,767
            long myLong = 9223372036854775807; // 9,223,372,036,854,775,807
            float myFloat = 3.40282347E+38F; // 7 digits
            double myDouble = 1.7976931348623157E+308; // 15-16 digits
            decimal myDecimal = 79228162514264337593543950335M; // 28-29 digits
            char myChar = 'A'; // Unicode character
            bool myBool = true; // or false
            string myString = "Hello World!"; // string is an alias for String in .NET
            ulong myUlong = 18446744073709551615; // 0 to 18,446,744,073,709,551,615 u for unsigned
            byte myByte = 255; // 0 to 255
            const int number = 2147483647; // -2,147,483,648 to 2,147,483,647
            uint myUint = 4294967295; // 0 to 4,294,967,295 u for unsigned
            var texto1 = "Testando123"; // O compilador infere o tipo da variável
            // conversão implicita e explicita
            int inteiro = 10;
            // Parse
            int valorConvertido = int.Parse("10");
            // TryParse
            int.TryParse("10", out int valorConvertido2);
            // Convert
            int valorConvertido3 = Convert.ToInt32("10");
            uint semSinal = (uint)inteiro; // conversão explicita
            float valor = 2.5f;
            int outro = 25;
            valor = outro; // conversão implicita
            // Valores padrao
            int numero = default; // 0
            // Alias é um apelido para um tipo
            myStringTypeAlias texto = "Testando"; // O compilador infere o tipo da variável
            Console.WriteLine(texto);
            Console.WriteLine(numero);
            // operadores de atribuição
            float i = 10;
            i += 10; // x = x - 10
            i -= 10; // x = x - 10
            i *= 10; // x = x * 10
            i /= 10; // x = x / 10
            i %= 10; // x = x % 10
            // operadores de comparação
            bool igual = 10 == 10; // true
            bool diferente = 10 != 10; // false
            bool maior = 10 > 10; // false
            bool menor = 10 < 10; // false
            bool maiorOuIgual = 10 >= 10; // true
            bool menorOuIgual = 10 <= 10; // true
            // operadores lógicos
            bool e = true && true; // true
            bool ou = true || false; // true
            bool negacao = !true; // false
            // estruturas condicionais
            // if
            if (diferente)
            {
                Console.WriteLine("10 é igual a 10");
            }
            else if (diferente == false)
            {
                Console.WriteLine("10 é diferente de 10");
            }
            else
            {
                Console.WriteLine("Nenhuma das condições acima");
            }
            // switch
            switch (inteiro)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Nenhum dos casos");
                    break;
            }
            // estruturas de repetição - Loops
            // for
            for (int ind = 0; ind < 10; ind++)
            {
                Console.WriteLine(i);
            }
            // while
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            // do while
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);

            // foreach
            string[] nomes = { "João", "Maria", "José" };
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            // funções - métodos
            static void Subtrair(int valor1, int valor2 = 10)
            {
                Console.WriteLine(valor1 - valor2);
            }
            Subtrair(10);
            // funções - métodos com retorno
            static int Somar(int valor1, int valor2)
            {
                return valor1 + valor2;
            }
            int resultado = Somar(10, 10);
            Console.WriteLine(resultado);
            // funções - métodos com retorno e parâmetros opcionais
            static int Multiplicar(int valor1, int valor2 = 10)
            {
                return valor1 * valor2;
            }
            int resultado2 = Multiplicar(10);
            MeuMetodo();
            string nomeCompleto = RetornaNome("Gustavo", "Tonolli");
            Console.WriteLine("Nome completo: " + nomeCompleto);
            ExemploStruct();
        }
        // métodos estáticos são métodos que podem ser chamados sem instanciar a classe
        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!!!");
        }
        static string RetornaNome(string nome, string sobrenome, int? idade = null) // idade é um parâmetro opcional, todos os opcionais devem ser os últimos
        {
            return nome + " " + sobrenome;
        }
        // tipos de referencia e tipos de valor
        // tipos de valor são tipos que armazenam seus próprios dados
        // tipos de referência são tipos que armazenam referências a seus dados
        // tipos de valor: struct, enum, int, float, double, decimal, char, bool
        // tipos de referência: class, interface, delegate, string, object
        static void TipoDeReferencia(string[] args)
        {
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]); // Item 1

            arr[0] = "Item 2"; // quando alteramos o valor de arr, alteramos o valor de arr2 também, pois ambos apontam para o mesmo endereço de memória
        }
        static void ExemploStruct()
        {
            var product = new Product(1, "Computador", 6500);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.PriceInDolar(6.2));
        }

    }
    struct Product
    {
        public Product(int id, string name, double price) // Este é o método construtor
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id; // Propriedades sempre começam com letra maiúscula
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar) // Parâmetros sempre são minúsculas
        {
            return Price / dolar; // Diferenciação do que é propriedade e parâmetro pela letra inicial Maiúscula ou minúscula
        }
    }
}
