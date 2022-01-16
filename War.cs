using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class War : MonoBehaviour
{

    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();

    public List<Card> pDeck = new List<Card>();
    public List<Card> hDeck = new List<Card>();

    public int deckSize;

    public int pDeckSize;
    public int hDeckSize;
    public Card currentCard, currentCard2, currentCard3, currentCard4, currentCard5, currentCard6;

    public GameObject pCard;
    public GameObject hCard;
    public GameObject pBack;
    public GameObject hBack;
    public GameObject pCard2;
    public GameObject hCard2;
    public GameObject playBtn;
    public GameObject collectBtn;
    public GameObject warBtn;
    public Text pSize;
    public Text hSize;
    public GameObject pWin;
    public GameObject hWin;
    public GameObject againBtn;

    public bool win = false;

    public void PopulateDeck()
    {
        deck.Clear();
        for (int i = 0; i < 52; i++)
        {
            deck.Add(DataBase2.cards[i]);
        }
    }

    public void CutDeck ()
    {
        pDeck.Clear();
        hDeck.Clear();
        while (deck.Count > 0)
        {
            pDeck.Add(deck[0]);
            deck.RemoveAt(0);
            hDeck.Add(deck[0]);
            deck.RemoveAt(0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        deckSize = 52;
        pDeckSize = 26;
        hDeckSize = 26;
        PopulateDeck();
        container.Add(deck[0]);
        Shuffle();
        CutDeck();
        pSize.text = "Your Number of Cards: " + pDeckSize;
        hSize.text = "House's Number of Cards: " + hDeckSize;
    }

    // Update is called once per frame
    void Update()
    {
        if(pDeckSize < 1)
        {
            win = true;
            hWin.SetActive(true);
            againBtn.SetActive(true);
        }
        if(hDeckSize < 1)
        {
            win = true;
            pWin.SetActive(true);
            againBtn.SetActive(true);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(1, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

 

    public void Play()
    {
        if (!win)
        {
            currentCard = pDeck[0];
            pDeck.RemoveAt(0);
            pDeckSize--;
            pCard.SetActive(true);
            pCard.GetComponent<Image>().sprite = currentCard.cardImage;
            currentCard2 = hDeck[0];
            hDeck.RemoveAt(0);
            hDeckSize--;
            hCard.SetActive(true);
            hCard.GetComponent<Image>().sprite = currentCard2.cardImage;
            playBtn.SetActive(false);
            if (currentCard.value == currentCard2.value)
            {
                warBtn.SetActive(true);
            }
            else
            {
                collectBtn.SetActive(true);
            }
        }
    }

    public void Collect()
    {
        if (!win)
        {
            if (currentCard.value > currentCard2.value)
            {
                pDeck.Add(currentCard);
                pDeck.Add(currentCard2);
                pDeckSize += 2;
            }
            else if (currentCard.value < currentCard2.value)
            {
                hDeck.Add(currentCard);
                hDeck.Add(currentCard2);
                hDeckSize += 2;
            }
            else
            {
                if (currentCard5.value > currentCard6.value)
                {
                    pDeck.Add(currentCard);
                    pDeck.Add(currentCard2);
                    pDeck.Add(currentCard3);
                    pDeck.Add(currentCard4);
                    pDeck.Add(currentCard5);
                    pDeck.Add(currentCard6);
                    pDeckSize += 6;
                }
                else
                {
                    hDeck.Add(currentCard);
                    hDeck.Add(currentCard2);
                    hDeck.Add(currentCard3);
                    hDeck.Add(currentCard4);
                    hDeck.Add(currentCard5);
                    hDeck.Add(currentCard6);
                    hDeckSize += 6;
                }
            }
            collectBtn.SetActive(false);
            pCard.SetActive(false);
            pCard2.SetActive(false);
            pBack.SetActive(false);
            hCard.SetActive(false);
            hCard2.SetActive(false);
            hBack.SetActive(false);
            playBtn.SetActive(true);
            pSize.text = "Your Number of Cards: " + pDeckSize;
            hSize.text = "House's Number of Cards: " + hDeckSize;
        }
    }

    public void StartWar()
    {
        if (!win)
        {
            currentCard3 = pDeck[0];
            pDeck.RemoveAt(0);
            pDeckSize--;
            currentCard5 = pDeck[0];
            pDeck.RemoveAt(0);
            pDeckSize--;
            currentCard4 = hDeck[0];
            hDeck.RemoveAt(0);
            hDeckSize--;
            currentCard6 = hDeck[0];
            hDeck.RemoveAt(0);
            hDeckSize--;
            pBack.SetActive(true);
            hBack.SetActive(true);
            pCard2.SetActive(true);
            hCard2.SetActive(true);
            pCard2.GetComponent<Image>().sprite = currentCard5.cardImage;
            hCard2.GetComponent<Image>().sprite = currentCard6.cardImage;
            warBtn.SetActive(false);
            collectBtn.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        deckSize = 52;
        pDeckSize = 26;
        hDeckSize = 26;
        PopulateDeck();
        Shuffle();
        CutDeck();
        pSize.text = "Your Number of Cards: " + pDeckSize;
        hSize.text = "House's Number of Cards: " + hDeckSize;
        win = false;
        pWin.SetActive(false);
        hWin.SetActive(false);
        againBtn.SetActive(false);
    }
}
