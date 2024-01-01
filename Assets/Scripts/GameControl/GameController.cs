using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{

    [SerializeField]
    List<Pokemon> starters, pink, green, blue, red, yellow;

    [SerializeField]
    Queue<EventCard> eventCardList;
    [SerializeField]
    List<EventCard> eventCardDiscards;

    [SerializeField]
    Queue<ItemCard> itemCardList;
    [SerializeField]
    List<ItemCard> itemCardDiscards;

    // Prefabs
    [SerializeField]
    GameObject takeItem1, takeItem2, takeItem3, strangeDungeon, chance, pokeCenter, fight, trade;

    private void Start()
    {
        InitializePiles();
    }

    public void InitializePiles()
    {
        InitializeChips();
        InitializeItemCards();
        InitializeEventCards();
    }

    private void InitializeChips()
    {
        starters = new List<Pokemon>();
        pink = new List<Pokemon>();
        green = new List<Pokemon>();
        blue = new List<Pokemon>();
        red = new List<Pokemon>();
        yellow = new List<Pokemon>();
    }

    private void InitializeItemCards()
    {
        itemCardList = new Queue<ItemCard>();
        itemCardDiscards = new List<ItemCard>();
    }

    private void InitializeEventCards()
    {
        eventCardList = new Queue<EventCard>();
        eventCardDiscards = new List<EventCard>();

        AddTakeItems();
        AddDungeon();
        AddChance();
        AddPokeCenter();
        AddFight();
        AddTrade();

        ShuffleEvents();
    }

    private void AddTakeItems()
    {
        AddCards(9, takeItem1);
        AddCards(5, takeItem2);
        AddCards(3, takeItem3);
    }


    private void AddDungeon()
    {
        AddCards(10, strangeDungeon);
    }
    private void AddChance()
    {
        AddCards(5, chance);
    }
    private void AddPokeCenter()
    {
        AddCards(2, pokeCenter);
    }

    private void AddFight()
    {
        AddCards(10, fight);
    }

    private void AddTrade()
    {
        AddCards(10, trade);
    }

    private void AddCards(int amount, GameObject instancingObject)
    {
        EventCard card;
        GameObject instances;

        for (int i = 0; i < amount; i++)
        {
            instances = Instantiate(instancingObject);
            card = instances.GetComponent<EventCard>();
            eventCardDiscards.Add(card);
        }
    }

    private void ShuffleEvents()
    {
        int elementCount = eventCardDiscards.Count;
        for (int i = 0; i < elementCount; i++)
        {
            int index = Random.Range(0, eventCardDiscards.Count - 1);
            eventCardList.Enqueue(eventCardDiscards[index]);
            eventCardDiscards.RemoveAt(index);
        }

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
