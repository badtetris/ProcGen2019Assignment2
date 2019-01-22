using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task2Generator : MonoBehaviour {


    // Another list of cards. 
    public GameObject[] cardPrefabs;

    public int numCardsToSpawn = 6;
    public float spaceBetweenCards = 3f; // Space (in Unity Units) between each card
    public Vector3 handLeftPosition; // Note that the hand isn't centered this time

    void Start() {
        // Spawn the fully random hand
        List<GameObject> fullyRandomHand = getRandomCardHand(numCardsToSpawn);
        if (fullyRandomHand != null) {
            spawnCards(fullyRandomHand, handLeftPosition);
        }
    }

    void Update() {
        // Code to re-load the scene when we press R
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public List<GameObject> getRandomCardHand(int numCardsToDraw) {
        // YOUR CODE HERE 
        // (it can be as simple as your answer to 1-a). 

        // This existing code just returns a hand of cards chosen in order from the card prefabs
        List<GameObject> hand = new List<GameObject>();
        for (int i = 0; i < numCardsToDraw; i++) {
            hand.Add(cardPrefabs[i]);
        }
        return hand;
    }


    public void spawnCards(List<GameObject> cardsToSpawn, Vector3 startPos) {
        Vector3 currentCardPos = startPos;
        // This time the cards just spawn from the left edge.
        currentCardPos += Vector3.right * (spaceBetweenCards / 2f);
        foreach (GameObject cardToSpawn in cardsToSpawn) {
            Instantiate(cardToSpawn, currentCardPos, Quaternion.identity);
            currentCardPos += Vector3.right * spaceBetweenCards;
        }
    }
}
