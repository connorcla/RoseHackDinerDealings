using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase2 : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();

    private void Awake()
    {
        cards.Add(new Card(0, Resources.Load<Sprite>("ace_of_diamonds"), 14));
        cards.Add(new Card(1, Resources.Load<Sprite>("ace_of_hearts"), 14));
        cards.Add(new Card(2, Resources.Load<Sprite>("ace_of_clubs"), 14));
        cards.Add(new Card(3, Resources.Load<Sprite>("ace_of_spades"), 14));
        cards.Add(new Card(4, Resources.Load<Sprite>("2_of_diamonds"), 2));
        cards.Add(new Card(5, Resources.Load<Sprite>("2_of_hearts"), 2));
        cards.Add(new Card(6, Resources.Load<Sprite>("2_of_clubs"), 2));
        cards.Add(new Card(7, Resources.Load<Sprite>("2_of_spades"), 2));
        cards.Add(new Card(8, Resources.Load<Sprite>("3_of_diamonds"), 3));
        cards.Add(new Card(9, Resources.Load<Sprite>("3_of_hearts"), 3));
        cards.Add(new Card(10, Resources.Load<Sprite>("3_of_clubs"), 3));
        cards.Add(new Card(11, Resources.Load<Sprite>("3_of_spades"), 3));
        cards.Add(new Card(12, Resources.Load<Sprite>("4_of_diamonds"), 4));
        cards.Add(new Card(13, Resources.Load<Sprite>("4_of_hearts"), 4));
        cards.Add(new Card(14, Resources.Load<Sprite>("4_of_clubs"), 4));
        cards.Add(new Card(15, Resources.Load<Sprite>("4_of_spades"), 4));
        cards.Add(new Card(16, Resources.Load<Sprite>("5_of_diamonds"), 4));
        cards.Add(new Card(17, Resources.Load<Sprite>("5_of_hearts"), 5));
        cards.Add(new Card(18, Resources.Load<Sprite>("5_of_clubs"), 5));
        cards.Add(new Card(19, Resources.Load<Sprite>("5_of_spades"), 5));
        cards.Add(new Card(20, Resources.Load<Sprite>("6_of_diamonds"), 6));
        cards.Add(new Card(21, Resources.Load<Sprite>("6_of_hearts"), 6));
        cards.Add(new Card(22, Resources.Load<Sprite>("6_of_clubs"), 6));
        cards.Add(new Card(23, Resources.Load<Sprite>("6_of_spades"), 6));
        cards.Add(new Card(24, Resources.Load<Sprite>("7_of_spades"), 7));
        cards.Add(new Card(25, Resources.Load<Sprite>("7_of_hearts"), 7));
        cards.Add(new Card(26, Resources.Load<Sprite>("7_of_clubs"), 7));
        cards.Add(new Card(27, Resources.Load<Sprite>("7_of_spades"), 7));
        cards.Add(new Card(28, Resources.Load<Sprite>("8_of_diamonds"), 8));
        cards.Add(new Card(29, Resources.Load<Sprite>("8_of_hearts"), 8));
        cards.Add(new Card(30, Resources.Load<Sprite>("8_of_clubs"), 8));
        cards.Add(new Card(31, Resources.Load<Sprite>("8_of_spades"), 8));
        cards.Add(new Card(32, Resources.Load<Sprite>("9_of_diamonds"), 9));
        cards.Add(new Card(33, Resources.Load<Sprite>("9_of_hearts"), 9));
        cards.Add(new Card(34, Resources.Load<Sprite>("9_of_clubs"), 9));
        cards.Add(new Card(35, Resources.Load<Sprite>("9_of_spades"), 9));
        cards.Add(new Card(36, Resources.Load<Sprite>("10_of_diamonds"), 10));
        cards.Add(new Card(37, Resources.Load<Sprite>("10_of_hearts"), 10));
        cards.Add(new Card(38, Resources.Load<Sprite>("10_of_clubs"), 10));
        cards.Add(new Card(39, Resources.Load<Sprite>("10_of_spades"), 10));
        cards.Add(new Card(40, Resources.Load<Sprite>("king_of_diamonds"), 13));
        cards.Add(new Card(41, Resources.Load<Sprite>("king_of_hearts"), 13));
        cards.Add(new Card(42, Resources.Load<Sprite>("king_of_clubs"), 13));
        cards.Add(new Card(43, Resources.Load<Sprite>("king_of_spades"), 13));
        cards.Add(new Card(44, Resources.Load<Sprite>("queen_of_diamonds"), 12));
        cards.Add(new Card(45, Resources.Load<Sprite>("queen_of_hearts"), 12));
        cards.Add(new Card(46, Resources.Load<Sprite>("queen_of_clubs"), 12));
        cards.Add(new Card(47, Resources.Load<Sprite>("queen_of_spades"), 12));
        cards.Add(new Card(48, Resources.Load<Sprite>("jack_of_diamonds"), 11));
        cards.Add(new Card(49, Resources.Load<Sprite>("jack_of_hearts"), 11));
        cards.Add(new Card(50, Resources.Load<Sprite>("jack_of_clubs"), 11));
        cards.Add(new Card(51, Resources.Load<Sprite>("jack_of_spades"), 11));

    }
}
