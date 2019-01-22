using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task1Generator : MonoBehaviour {

    // Every possible card prefab.
    public GameObject[] cardPrefabs;

    // Every possible filter we apply to the second hand.
    public CardFilter[] possibleFilters;

    public Vector3 fullRandomHandPosition;
    public Vector3 filteredRandomHandPosition;

    public TMPro.TextMeshPro filterTextMesh;

    void Start() {

        // Spawn the fully random hand (for Task 1-a)
        List<GameObject> fullyRandomHand = getRandomCardHand(5);
        if (fullyRandomHand != null) {
            spawnCards(fullyRandomHand, fullRandomHandPosition);
        }

        // Spawn the filtered random hand (for Task 1-b)
        CardFilter randomFilter = RandFuncs.randPick(possibleFilters);
        filterTextMesh.text = "Filtered Random Hand " + randomFilter.filterString + ":";
        List<GameObject> filteredRandomHand = getFilteredRandomCardHand(5, randomFilter);
        if (filteredRandomHand != null) {
            spawnCards(filteredRandomHand, filteredRandomHandPosition);
        }
    }

    void Update() {
        // Code to re-load the scene when we press R
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public List<GameObject> getRandomCardHand(int numCardsToDraw) {
        // YOUR CODE (for Task 1-a) HERE. 


        return null;
    }

    public List<GameObject> getFilteredRandomCardHand(int numCardsToDraw, CardFilter filter) {
        // YOUR CODE (for Task 1-b) HERE.


        return null;
    }


    public void spawnCards(List<GameObject> cardsToSpawn, Vector3 startPos, float spaceBetweenCards=3f) {
        Vector3 currentCardPos = startPos;
        // Center the cards
        currentCardPos -= Vector3.right * (cardsToSpawn.Count * spaceBetweenCards / 2f);
        currentCardPos += Vector3.right * (spaceBetweenCards / 2f);
        foreach (GameObject cardToSpawn in cardsToSpawn) {
            Instantiate(cardToSpawn, currentCardPos, Quaternion.identity);
            currentCardPos += Vector3.right * spaceBetweenCards;
        }
    }

}
