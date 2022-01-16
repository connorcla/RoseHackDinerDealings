using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card 
{
    public int id;
    public Sprite cardImage;
    public int value;

    public Card(int Id, Sprite CardImage, int Value)
    {
        id = Id;
        cardImage = CardImage;
        value = Value;
    }


}
