using System;
using System.Collections.Generic;

namespace CardGameApp
{

    class SpanishPlayingCard
    {

        int number;
        string sign;

        public SpanishPlayingCard(int number, string sign)
        {
            this.number = number;
            this.sign = sign;

        }

        public void WriteCardValue()
        {
            Console.WriteLine(sign + " " + number);
        }

    }

    class DeckOfCards
    {
        List<SpanishPlayingCard> cards;



        public DeckOfCards()
        {
            cards = new List<SpanishPlayingCard>();
            List<string> signs = new List<string>() { "Oros", "Copas", "Espadas", "Bastos" };
            for (int i = 1; i <= 12; i++)
            {
                foreach (string element in signs)
                {
                    cards.Add(new SpanishPlayingCard(i, element));
                }
            }
        }

        public int count()
        {
            return cards.Count;
        }
        public SpanishPlayingCard Take()
        {
            if (cards.Count > 0)
            {
                SpanishPlayingCard item = cards[0];
                cards.RemoveAt(0);
                return item;
            }
            return null;
        }
        public SpanishPlayingCard Take(int i)
        {
            if (i < cards.Count)
            {
                SpanishPlayingCard item = cards[i];
                cards.RemoveAt(i);
                return item;
            }
            return null;
        }

        public SpanishPlayingCard TakeRandom()
        {

            int i = new Random().Next(0, cards.Count);
            if (i < cards.Count)
            {
                SpanishPlayingCard item = cards[i];
                cards.RemoveAt(i);
                return item;
            }
            return null;
        }
        public void Print()
        {
            foreach (SpanishPlayingCard card in cards)
            {
                card.WriteCardValue();
            }
        }

        public void Mix()
        {
            Random r = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int m = r.Next(0, cards.Count);
                int n = r.Next(0, cards.Count);
                if (m != n)
                {
                    SpanishPlayingCard t = cards[m];
                    cards[m] = cards[n];
                    cards[n] = t;
                }
            }
        }
    }


    public class CardGameAppMain
    {

        static void Main(string[] args)
        {

            DeckOfCards deck = new DeckOfCards();
            deck.Print();
            deck.Mix();
            deck.Print();
            deck.Take().WriteCardValue();
            deck.Take(5).WriteCardValue();
            deck.TakeRandom().WriteCardValue();
            Console.WriteLine("Card count : " + deck.count());
            deck.Print();

        }
    }

}