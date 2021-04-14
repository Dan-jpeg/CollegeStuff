using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardGame : Singleton<CardGame>
{
    public Dictionary<CardInstance, CardView> cardsDictionary;
    public List<CardAsset> startingCards;
    public GameObject cardPrefab;
    public Transform cardPrefabParent;
    public Canvas canvas;

    public float offset;
    public int cardsInPlay;

    private void Start()
    {
        CreatePrefab();
        Instantiate(cardPrefab, cardPrefabParent);
        Instantiate(cardPrefab, cardPrefabParent);
        Instantiate(cardPrefab, cardPrefabParent);
        Instantiate(cardPrefab, cardPrefabParent);
        Instantiate(cardPrefab, cardPrefabParent);
        UpdateCardSpacing();
    }
    private void StartGame()
    {
        for (int i = 0; i < startingCards.Count; i++)
        {
            var currentCardInstance = new CardInstance(startingCards[i]);
        }
    }

    private void CreatePrefab()
    {
        for (int i = 0; i < startingCards.Count; i++)
        {
            Instantiate(cardPrefab, cardPrefabParent);
            var currentPrefab = new CardInstance(startingCards[i]);     // ???
        }
    }
    public void CreateCardView(CardInstance cardInstance)
    {

    }

    private void UpdateCardSpacing()
    {
        offset = -cardsInPlay * 170;
        canvas.GetComponent<HorizontalLayoutGroup>().spacing = offset;
    }
}
