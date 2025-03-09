﻿using myStringTypeAlias = System.String; // Alias para o tipo String

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
            


        }
    }
}
