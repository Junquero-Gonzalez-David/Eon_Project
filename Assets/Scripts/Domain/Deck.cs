﻿using System;
using System.Collections.Generic;
class Deck {

    private List<CardObject> deck = new List<CardObject>();
    private Player player;

    public Deck(List<CardObject> deck, Player p)
    {
        this.deck = deck;
        this.player = p;
    }
    public void insertCard(CardObject c)
    {
        deck.Insert(deck.Count,c);
    }
    public void shuffle(CardObject c)
    {
        Random rnd = new Random();
        int position = rnd.Next(0, deck.Count);
        deck.Insert(position, c);
    }
    public CardObject getCard(CardObject c)
    {
        c=deck.Find(c.Equals);
        return c;
    }
    public void removeCard(CardObject c) { deck.Remove(c);}
    public void removeFirst() { deck.RemoveAt(0);}
}
