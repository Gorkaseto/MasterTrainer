using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class PokeCreator : MonoBehaviour
{

    [SerializeField]
    string pokemonInfo = "1,Bulbasaur,0,4,4";

    string[] pokemonAttributes;

    string fileName = "pokeInfo";

    Transform pokeContainer;

    [SerializeField]
    GameController gameController;

    void Start()
    {
        if (pokeContainer == null)
            pokeContainer = new GameObject("PokeContainer").transform;

        if (gameController == null)
            gameController = FindObjectOfType<GameController>();
    }

    [ContextMenu("LoadAllPokemon")]
    public void ReadData()
    {

        TextAsset asset = Resources.Load<TextAsset>(fileName);

        String[] lines = asset.text.Split("\n");

        for (int i = 1; i < lines.Length; i++)
        {
            pokemonInfo = lines[i];
            CreatePokemon(pokemonInfo);
        }
    }


    public void CreatePokemon(string pokeInfo)
    {
        pokemonAttributes = pokeInfo.Split(",");

        GameObject newPokemon = new GameObject(pokemonAttributes[1]);
        newPokemon.transform.parent = pokeContainer;
        Pokemon pokeComponent;

        switch (Int32.Parse(pokemonAttributes[2]))
        {
            case 0:
                pokeComponent = newPokemon.AddComponent<Starter>();
                gameController.AddStarter(pokeComponent);
                break;
            case 1:
                pokeComponent = newPokemon.AddComponent<Pink>();
                gameController.AddPink(pokeComponent);
                break;
            case 2:
                pokeComponent = newPokemon.AddComponent<Green>();
                gameController.AddGreen(pokeComponent);
                break;
            case 3:
                pokeComponent = newPokemon.AddComponent<Blue>();
                gameController.AddBlue(pokeComponent);
                break;
            case 4:
                pokeComponent = newPokemon.AddComponent<Red>();
                gameController.AddRed(pokeComponent);
                break;
            case 5:
                pokeComponent = newPokemon.AddComponent<Yellow>();
                gameController.AddYellow(pokeComponent);
                break;
            default:
                pokeComponent = null;
                Debug.LogError("No existe esa categoria");
                return;
        }

        pokeComponent.number = Int32.Parse(pokemonAttributes[0]);
        pokeComponent.pokeName = pokemonAttributes[1];
        pokeComponent.powerPoint = Int32.Parse(pokemonAttributes[4]);
        pokeComponent.attackInfo = new AttackInfo { attackName = "null", attackStrength = Int32.Parse(pokemonAttributes[3]) };
    }

}
