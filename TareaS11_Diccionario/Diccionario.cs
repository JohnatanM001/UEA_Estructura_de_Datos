using System;
using System.Collections.Generic;

public class Diccionario
{
    private Dictionary<string, string> palabras;

    public Diccionario()
    {
        palabras = new Dictionary<string, string>
        {
            {"Time", "tiempo"},
            {"Person", "persona"},
            {"Year", "año"},
            {"Way", "camino/forma"},
            {"Day", "día"},
            {"Thing", "cosa"},
            {"Man", "hombre"},
            {"World", "mundo"},
            {"Life", "vida"},
            {"Hand", "mano"},
            {"Part", "parte"},
            {"Child", "niño/a"},
            {"Eye", "ojo"},
            {"Woman", "mujer"},
            {"Place", "lugar"},
            {"Work", "trabajo"},
            {"Week", "semana"},
            {"Case", "caso"},
            {"Point", "punto/tema"},
            {"Government", "gobierno"},
            {"Company", "empresa/compañía"}
        };
    }

    public string Traducir(string frase)
    {
        string[] palabrasFrase = frase.Split(' ');
        for (int i = 0; i < palabrasFrase.Length; i++)
        {
            string palabraLimpia = palabrasFrase[i].Trim(new char[] { '.', ',', '!', '?' });
            if (palabras.ContainsKey(palabraLimpia))
            {
                palabrasFrase[i] = palabrasFrase[i].Replace(palabraLimpia, palabras[palabraLimpia]);
            }
        }
        return string.Join(" ", palabrasFrase);
    }

    public void AgregarPalabras()
    {
        while (true)
        {
            Console.Write("Ingrese la palabra en inglés (o 'salir' para terminar): ");
            string ingles = Console.ReadLine();
            if (ingles.ToLower() == "salir")
            {
                break;
            }

            Console.Write("Ingrese la traducción en español: ");
            string espanol = Console.ReadLine();

            if (!palabras.ContainsKey(ingles))
            {
                palabras.Add(ingles, espanol);
                Console.WriteLine("Palabra agregada al diccionario.");
            }
            else
            {
                Console.WriteLine("La palabra ya existe en el diccionario.");
            }
        }
    }
}
