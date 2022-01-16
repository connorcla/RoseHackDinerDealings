using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();

    public int deckSize;

    public Card currentCard;
    public int playerScore = 0;
    public int houseScore = 0;

    public GameObject PlayerHand;
    public GameObject HouseHand;
    public GameObject WaitingZone;
    public GameObject Card0, Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10;
    public GameObject CardBack;
    public Text PlayerScore;
    public Text HouseScore;
    public GameObject PStand;
    public GameObject DStand;
    public Text PStandText;
    public Text DStandText;
    public GameObject PWin;
    public GameObject DWin;
    public GameObject Tie;
    public GameObject PlayAgainBtn;

    public bool standP = false, standH = false;
    public bool win = false;
    public bool wait = false;


    void PopulateDeck()
    {
        for (int i = 0; i < 52; i++)
        {
            deck.Add(DataBase.cards[i]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        deckSize = 52;
        PopulateDeck();
        container.Add(deck[0]);
        Shuffle();
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScore > 21)
        {
            PStand.SetActive(true);
            PStandText.text = "Bust!";
            DWin.SetActive(true);
            PlayAgainBtn.SetActive(true);
            win = true;
        }
        if(houseScore > 21 && !wait)
        {
            DStand.SetActive(true);
            DStandText.text = "Bust!";
            PWin.SetActive(true);
            PlayAgainBtn.SetActive(true);
            win = true;
        }
        
    }

    IEnumerator House()
    {
        standP = true;
        CardBack.transform.SetParent(WaitingZone.transform, false);
        CardBack.SetActive(false);
        if (houseScore < 21 && !standH && !win)
        {
            standH = true;
            currentCard = deck[0];
            deck.RemoveAt(0);
            deckSize -= 1;
            houseScore += currentCard.value;
            HouseScore.text = "House Total: " + houseScore;
            int count = PlayerHand.transform.childCount + HouseHand.transform.childCount;
            GetCardD(count);
            yield return new WaitForSeconds(2);
            wait = true;
            while (houseScore < 17 && !win)
            {
                currentCard = deck[0];
                deck.RemoveAt(0);
                deckSize -= 1;
                houseScore += currentCard.value;
                HouseScore.text = "House Total: " + houseScore;
                count = PlayerHand.transform.childCount + HouseHand.transform.childCount;
                GetCardD(count);
                yield return new WaitForSeconds(2);
            }
            wait = false;
            DStand.SetActive(true);
            if(!win)
            {
                if(playerScore > houseScore && playerScore < 22)
                {
                    PWin.SetActive(true);
                    PlayAgainBtn.SetActive(true);
                    win = true;
                }
                else if (playerScore < houseScore && houseScore < 22)
                {
                    DWin.SetActive(true);
                    PlayAgainBtn.SetActive(true);
                    win = true;
                }
                else
                {
                    Tie.SetActive(true);
                    PlayAgainBtn.SetActive(true);
                    win = true;
                }
            }
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

    public void StartGame()
    {
        currentCard = deck[0];
        deck.RemoveAt(0);
        deckSize -= 1;
        CardBack.SetActive(true);
        CardBack.transform.SetParent(HouseHand.transform, false);
        Card0.SetActive(true);
        Card0.transform.SetParent(HouseHand.transform, false);
        Card0.GetComponent<Image>().sprite = currentCard.cardImage;
        houseScore += currentCard.value;
        HouseScore.text = "House Total: " + houseScore;
        Draw();
        Draw();
    }

    public void Draw()
    {
        if (playerScore < 21 && !standP)
        {
            currentCard = deck[0];
            deck.RemoveAt(0);
            deckSize -= 1;
            playerScore += currentCard.value;
            PlayerScore.text = "Your Total: " + playerScore;
            int count = PlayerHand.transform.childCount + 1;
            GetCardP(count);
        }
    }

    public void DealerTurn()
    {
        if (!win)
        {
            PStand.SetActive(true);
            StartCoroutine(House());
        }
    }

    public void PlayAgain()
    {
        playerScore = 0;
        houseScore = 0;
        PlayerScore.text = "Your Total: " + playerScore;
        HouseScore.text = "House Total: " + houseScore;
        standH = false;
        standP = false;
        win = false;
        Card0.SetActive(false);
        Card0.transform.SetParent(WaitingZone.transform, false);
        Card1.SetActive(false);
        Card1.transform.SetParent(WaitingZone.transform, false);
        Card2.SetActive(false);
        Card2.transform.SetParent(WaitingZone.transform, false);
        Card3.SetActive(false);
        Card3.transform.SetParent(WaitingZone.transform, false);
        Card4.SetActive(false);
        Card4.transform.SetParent(WaitingZone.transform, false);
        Card5.SetActive(false);
        Card5.transform.SetParent(WaitingZone.transform, false);
        Card6.SetActive(false);
        Card6.transform.SetParent(WaitingZone.transform, false);
        Card7.SetActive(false);
        Card7.transform.SetParent(WaitingZone.transform, false);
        Card8.SetActive(false);
        Card8.transform.SetParent(WaitingZone.transform, false);
        Card9.SetActive(false);
        Card9.transform.SetParent(WaitingZone.transform, false);
        Card10.SetActive(false);
        Card10.transform.SetParent(WaitingZone.transform, false);
        PStand.SetActive(false);
        PStandText.text = "Stand!";
        DStand.SetActive(false);
        DStandText.text = "Stand!";
        DWin.SetActive(false);
        PWin.SetActive(false);
        Tie.SetActive(false);
        PlayAgainBtn.SetActive(false);
        if (deckSize < 10)
        {
            deck.Clear();
            PopulateDeck();
            deckSize = 51;
            Shuffle();
        }
        StartGame();
    }

    public void GetCardP(int count)
    {
        switch (count)
        {
            case 1:
                Card1.SetActive(true);
                Card1.GetComponent<Image>().sprite = currentCard.cardImage;
                Card1.transform.SetParent(PlayerHand.transform, false);
                break;
            case 2:
                Card2.SetActive(true);
                Card2.GetComponent<Image>().sprite = currentCard.cardImage;
                Card2.transform.SetParent(PlayerHand.transform, false);
                break;
            case 3:
                Card3.SetActive(true);
                Card3.GetComponent<Image>().sprite = currentCard.cardImage;
                Card3.transform.SetParent(PlayerHand.transform, false);
                break;
            case 4:
                Card4.SetActive(true);
                Card4.GetComponent<Image>().sprite = currentCard.cardImage;
                Card4.transform.SetParent(PlayerHand.transform, false);
                break;
            case 5:
                Card5.SetActive(true);
                Card5.GetComponent<Image>().sprite = currentCard.cardImage;
                Card5.transform.SetParent(PlayerHand.transform, false);
                break;
            case 6:
                Card6.SetActive(true);
                Card6.GetComponent<Image>().sprite = currentCard.cardImage;
                Card6.transform.SetParent(PlayerHand.transform, false);
                break;
            case 7:
                Card7.SetActive(true);
                Card7.GetComponent<Image>().sprite = currentCard.cardImage;
                Card7.transform.SetParent(PlayerHand.transform, false);
                break;
            case 8:
                Card8.SetActive(true);
                Card8.GetComponent<Image>().sprite = currentCard.cardImage;
                Card8.transform.SetParent(PlayerHand.transform, false);
                break;
            case 9:
                Card9.SetActive(true);
                Card9.GetComponent<Image>().sprite = currentCard.cardImage;
                Card9.transform.SetParent(PlayerHand.transform, false);
                break;
            case 10:
                Card10.SetActive(true);
                Card10.GetComponent<Image>().sprite = currentCard.cardImage;
                Card10.transform.SetParent(PlayerHand.transform, false);
                break;
        }
    }

    public void GetCardD(int count)
    {
        switch (count)
        {
            case 1:
                Card1.SetActive(true);
                Card1.GetComponent<Image>().sprite = currentCard.cardImage;
                Card1.transform.SetParent(HouseHand.transform, false);
                break;
            case 2:
                Card2.SetActive(true);
                Card2.GetComponent<Image>().sprite = currentCard.cardImage;
                Card2.transform.SetParent(HouseHand.transform, false);
                break;
            case 3:
                Card3.SetActive(true);
                Card3.GetComponent<Image>().sprite = currentCard.cardImage;
                Card3.transform.SetParent(HouseHand.transform, false);
                break;
            case 4:
                Card4.SetActive(true);
                Card4.GetComponent<Image>().sprite = currentCard.cardImage;
                Card4.transform.SetParent(HouseHand.transform, false);
                break;
            case 5:
                Card5.SetActive(true);
                Card5.GetComponent<Image>().sprite = currentCard.cardImage;
                Card5.transform.SetParent(HouseHand.transform, false);
                break;
            case 6:
                Card6.SetActive(true);
                Card6.GetComponent<Image>().sprite = currentCard.cardImage;
                Card6.transform.SetParent(HouseHand.transform, false);
                break;
            case 7:
                Card7.SetActive(true);
                Card7.GetComponent<Image>().sprite = currentCard.cardImage;
                Card7.transform.SetParent(HouseHand.transform, false);
                break;
            case 8:
                Card8.SetActive(true);
                Card8.GetComponent<Image>().sprite = currentCard.cardImage;
                Card8.transform.SetParent(HouseHand.transform, false);
                break;
            case 9:
                Card9.SetActive(true);
                Card9.GetComponent<Image>().sprite = currentCard.cardImage;
                Card9.transform.SetParent(HouseHand.transform, false);
                break;
            case 10:
                Card10.SetActive(true);
                Card10.GetComponent<Image>().sprite = currentCard.cardImage;
                Card10.transform.SetParent(HouseHand.transform, false);
                break;
        }
    }
}
