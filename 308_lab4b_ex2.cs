using System;
using System.Collections.Generic;

public static class PokemonLookup
{
    static Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

    static public void Initialize()
    {
        dict.Add("Water", new string[] { "Squirtle", "Tentacool", "Psyduck" });
        dict.Add("Grass", new string[] { "Bulbasaur", "Oddish", "Gloom"});
        dict.Add("Fire", new string[] { "Charmander", "Vulpix"});
        dict.Add("Fairy", new string[] { "Jigglypuff"});
    }

    static public string[] LookupByType(string pokemonType)
    {
        string searchpokemon = pokemonType;
        string record[] = new string[];
        // TODO: implement this 
        foreach (KeyValuePair<string, string[]> x in dict){
            if (x.Key == searchpokemon){
                
            }
        }
        return 
    }
}

public class Program
{
    public static void Main()
    {
        PokemonLookup.Initialize();
        Console.WriteLine(PokemonLookup.LookupByType("Water"));
        // TODO: write code here to look up water type Pokemons and print them out
    }
}