using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardRank {
    Ace = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

public enum CardSuit {
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

public class Card : MonoBehaviour {

    public Sprite heartsSprite, diamondsSprite, clubsSprite, spadesSprite;

    public CardRank rank;
    public CardSuit suit;

    public SpriteRenderer suitSpriteRenderer;
    public TMPro.TextMeshPro rankTextMesh;

    void Start() {
        // Update the text and sprites depending on the card.
        if (suitSpriteRenderer != null) {
            suitSpriteRenderer.sprite = suitSprite(suit);
        }
        if (rankTextMesh != null) {
            rankTextMesh.text = rankString(rank);
        }
    }


    protected Sprite suitSprite(CardSuit suit) {
        if (suit == CardSuit.Hearts) {
            return heartsSprite;
        }
        else if (suit == CardSuit.Diamonds) {
            return diamondsSprite;
        }
        else if (suit == CardSuit.Clubs) {
            return clubsSprite;
        }
        else if (suit == CardSuit.Spades) {
            return spadesSprite;
        }
        return null;
    }

    protected string rankString(CardRank rank) {
        if (rank == CardRank.Ace) {
            return "A";
        }
        else if (rank == CardRank.Jack) {
            return "J";
        }
        else if (rank == CardRank.Queen) {
            return "Q";
        }
        else if (rank == CardRank.King) {
            return "K";
        }
        else {
            return ((int)rank).ToString();
        }
    }



}
