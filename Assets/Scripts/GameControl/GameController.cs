using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField]
    List<Pokemon> starters, pink, green, blue, red, yellow;

    private void Start()
    {
        starters = new List<Pokemon>();
        pink = new List<Pokemon>();
        green = new List<Pokemon>();
        blue = new List<Pokemon>();
        red = new List<Pokemon>();
        yellow = new List<Pokemon>();
    }

    public void AddStarter(Pokemon newPokemon)
    {
        starters.Add(newPokemon);
    }

    public void AddPink(Pokemon newPokemon)
    {
        pink.Add(newPokemon);
    }

    public void AddGreen(Pokemon newPokemon)
    {
        green.Add(newPokemon);
    }

    public void AddBlue(Pokemon newPokemon)
    {
        blue.Add(newPokemon);
    }

    public void AddRed(Pokemon newPokemon)
    {
        red.Add(newPokemon);
    }

    public void AddYellow(Pokemon newPokemon)
    {
        yellow.Add(newPokemon);
    }


}
