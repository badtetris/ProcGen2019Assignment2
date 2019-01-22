using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFilter : MonoBehaviour {

    public CardSuit[] allowedSuits = { CardSuit.Hearts, CardSuit.Diamonds, CardSuit.Clubs, CardSuit.Spades };
    public CardSuit[] forbiddenSuits = {};

    public CardRank minRank = CardRank.Ace;
    public CardRank maxRank = CardRank.King;

    public string filterString;
   
    public bool cardPassesFilter(GameObject cardPrefab) {
        Card card = cardPrefab.GetComponent<Card>();

        // Ensure the card is in the correct suits
        foreach (CardSuit forbiddenSuit in forbiddenSuits) {
            if (card.suit == forbiddenSuit) {
                return false;
            }
        }

        bool isAllowedSuit = false;
        foreach (CardSuit allowedSuit in allowedSuits) {
            if (card.suit == allowedSuit) {
                isAllowedSuit = true;
                break;
            }
        }

        if (!isAllowedSuit) {
            return false;
        }

        int rankInt = (int)card.rank;
        int minRankInt = (int)minRank;
        int maxRankInt = (int)maxRank;

        return rankInt >= minRankInt && rankInt <= maxRankInt;
    }

}
