using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{

    public char[] board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
    public bool turn = true;
	public bool win = false;
	public bool first = true;

	public int playCnt;
	public int compMove;

    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9;
	public GameObject PWin;
	public GameObject DWin;
	public GameObject Tie;
	public GameObject PlayAgainBtn;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void StartGame()
    {
		if(!first)
        {
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
    }

	void CompPlayer(char xo, char ox)
	{
		if (!win)
		{
			if (board[5] != 'X' && board[5] != 'O')
			{
				board[5] = xo; //Prioritizes going in the middle first, if it is already taken, then moves down the list
				compMove = 5;
			}
			else if (board[2] == xo && board[3] == xo && board[1] != 'X' && board[1] != 'O' || board[5] == xo && board[9] == xo && board[1] != 'X' && board[1] != 'O' || board[4] == xo && board[7] == xo && board[1] != 'X' && board[1] != 'O')
			{
				board[1] = xo; // first 1-9 prioritizes winning moves over all others
				compMove = 1;
			}
			else if (board[1] == xo && board[3] == xo && board[2] != 'X' && board[2] != 'O' || board[5] == xo && board[8] == xo && board[2] != 'X' && board[2] != 'O')
			{
				board[2] = xo;
				compMove = 2;
			}
			else if (board[1] == xo && board[2] == xo && board[3] != 'X' && board[3] != 'O' || board[5] == xo && board[7] == xo && board[3] != 'X' && board[3] != 'O' || board[6] == xo && board[9] == xo && board[3] != 'X' && board[3] != 'O')
			{
				board[3] = xo;
				compMove = 3;
			}
			else if (board[1] == xo && board[7] == xo && board[4] != 'X' && board[4] != 'O' || board[5] == xo && board[6] == xo && board[4] != 'X' && board[4] != 'O')
			{
				board[4] = xo;
				compMove = 4;
			}
			else if (board[3] == xo && board[9] == xo && board[6] != 'X' && board[6] != 'O' || board[4] == xo && board[5] == xo && board[6] != 'X' && board[6] != 'O')
			{
				board[6] = xo;
				compMove = 6;
			}
			else if (board[1] == xo && board[4] == xo && board[7] != 'X' && board[7] != 'O' || board[3] == xo && board[5] == xo && board[7] != 'X' && board[7] != 'O' || board[8] == xo && board[9] == xo && board[7] != 'X' && board[7] != 'O')
			{
				board[7] = xo;
				compMove = 7;
			}
			else if (board[7] == xo && board[9] == xo && board[8] != 'X' && board[8] != 'O' || board[2] == xo && board[5] == xo && board[8] != 'X' && board[8] != 'O')
			{
				board[8] = xo;
				compMove = 8;
			}
			else if (board[1] == xo && board[5] == xo && board[9] != 'X' && board[9] != 'O' || board[3] == xo && board[6] == xo && board[9] != 'X' && board[9] != 'O' || board[7] == xo && board[8] == xo && board[9] != 'X' && board[9] != 'O')
			{
				board[9] = xo;
				compMove = 9;
			}
			else if (board[2] == ox && board[3] == ox && board[1] != 'X' && board[1] != 'O' || board[5] == ox && board[9] == ox && board[1] != 'X' && board[1] != 'O' || board[4] == ox && board[7] == ox && board[1] != 'X' && board[1] != 'O')
			{
				board[1] = xo; //After winning moves, prioritizes blocking oppenent from winning
				compMove = 1;
			}
			else if (board[1] == ox && board[3] == ox && board[2] != 'X' && board[2] != 'O' || board[5] == ox && board[8] == ox && board[2] != 'X' && board[2] != 'O')
			{
				board[2] = xo;
				compMove = 2;
			}
			else if (board[1] == ox && board[2] == ox && board[3] != 'X' && board[3] != 'O' || board[5] == ox && board[7] == ox && board[3] != 'X' && board[3] != 'O' || board[6] == ox && board[9] == ox && board[3] != 'X' && board[3] != 'O')
			{
				board[3] = xo;
				compMove = 3;
			}
			else if (board[1] == ox && board[7] == ox && board[4] != 'X' && board[4] != 'O' || board[5] == ox && board[6] == ox && board[4] != 'X' && board[4] != 'O')
			{
				board[4] = xo;
				compMove = 4;
			}
			else if (board[3] == ox && board[9] == ox && board[6] != 'X' && board[6] != 'O' || board[4] == ox && board[5] == ox && board[6] != 'X' && board[6] != 'O')
			{
				board[6] = xo;
				compMove = 6;
			}
			else if (board[1] == ox && board[4] == ox && board[7] != 'X' && board[7] != 'O' || board[3] == ox && board[5] == ox && board[7] != 'X' && board[7] != 'O' || board[8] == ox && board[9] == ox && board[7] != 'X' && board[7] != 'O')
			{
				board[7] = xo;
				compMove = 7;
			}
			else if (board[7] == ox && board[9] == ox && board[8] != 'X' && board[8] != 'O' || board[2] == ox && board[5] == ox && board[8] != 'X' && board[8] != 'O')
			{
				board[8] = xo;
				compMove = 8;
			}
			else if (board[1] == ox && board[5] == ox && board[9] != 'X' && board[9] != 'O' || board[3] == ox && board[6] == ox && board[9] != 'X' && board[9] != 'O' || board[7] == ox && board[8] == ox && board[9] != 'X' && board[9] != 'O')
			{
				board[9] = xo;
				compMove = 9;
			}
			else if (board[5] == xo && board[1] == ox && board[9] == ox && board[2] == '2' && board[3] == '3' && board[4] == '4' && board[6] == '6' && board[7] == '7' && board[8] == '8' || board[5] == xo && board[3] == ox && board[7] == ox && board[2] == '2' && board[1] == '1' && board[4] == '4' && board[6] == '6' && board[9] == '9' && board[8] == '8')
			{ //Making sure doesn't lose to special board states, peculiar ones
				bool good = false;
				while (!good)
				{

					int temp = Random.Range(1, 9);
					if (temp % 2 == 0 && temp != 5 && board[temp] != 'X' && board[temp] != 'O')
					{
						board[temp] = xo;
						compMove = temp;
						good = true;
					}
				}
			}
			else if (playCnt < 3)
			{ //Going in corners early game is better
				bool good = false;
				while (!good)
				{
					int temp = Random.Range(1, 9);
					if (temp % 2 != 0 && temp != 5 && board[temp] != 'X' && board[temp] != 'O')
					{
						board[temp] = xo;
						compMove = temp;
						good = true;
					}
				}
			}
			else
			{ //Random move when nothing else is better
				bool good = false;
				while (!good)
				{
					int temp = Random.Range(1, 9);
					if (board[temp] != 'X' && board[temp] != 'O')
					{
						board[temp] = xo;
						compMove = temp;
						good = true;
					}
				}
			}
		}
	}

	public void CompUpdate (int compMove)
    {
		switch (compMove)
        {
			case 1:
				s1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 2:
				s2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 3:
				s3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 4:
				s4.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s4.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 5:
				s5.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s5.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 6:
				s6.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s6.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 7:
				s7.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s7.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 8:
				s8.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s8.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
			case 9:
				s9.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
				s9.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_O");
				break;
		}
	
    }

	void CheckWin()
	{
		if (board[1] == 'X' && board[2] == 'X' && board[3] == 'X' || board[4] == 'X' && board[5] == 'X' && board[6] == 'X' || board[7] == 'X' && board[8] == 'X' && board[9] == 'X' || board[1] == 'X' && board[4] == 'X' && board[7] == 'X' || board[2] == 'X' && board[5] == 'X' && board[8] == 'X' || board[3] == 'X' && board[6] == 'X' && board[9] == 'X' || board[1] == 'X' && board[5] == 'X' && board[9] == 'X' || board[3] == 'X' && board[5] == 'X' && board[7] == 'X')
		{ //Checks all the winning board states for Player 1
			win = true;
			PWin.SetActive(true);
	        PlayAgainBtn.SetActive(true);
		}
		else if (board[1] == 'O' && board[2] == 'O' && board[3] == 'O' || board[4] == 'O' && board[5] == 'O' && board[6] == 'O' || board[7] == 'O' && board[8] == 'O' && board[9] == 'O' || board[1] == 'O' && board[4] == 'O' && board[7] == 'O' || board[2] == 'O' && board[5] == 'O' && board[8] == 'O' || board[3] == 'O' && board[6] == 'O' && board[9] == 'O' || board[1] == 'O' && board[5] == 'O' && board[9] == 'O' || board[3] == 'O' && board[5] == 'O' && board[7] == 'O')
		{ //Checks all the winning board states for Player 2
			win = true;
			DWin.SetActive(true);
			PlayAgainBtn.SetActive(true);
		}
		else if (playCnt >= 9)
		{
			win = true;
			Tie.SetActive(true);
			PlayAgainBtn.SetActive(true);
		}

	}

	public void PlayAgain()
	{ //For when you want to play again, resets all variables for a fresh gamestate 
		board[0] = '0';
		board[1] = '1';
		board[2] = '2';
		board[3] = '3';
		board[4] = '4';
		board[5] = '5';
		board[6] = '6';
		board[7] = '7';
		board[8] = '8';
		board[9] = '9';
		playCnt = 0;
		win = false;
		PWin.SetActive(false);
		DWin.SetActive(false);
		Tie.SetActive(false);
		PlayAgainBtn.SetActive(false);
		s1.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s5.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s6.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s7.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s8.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		s9.GetComponent<Image>().color = new Color(0, 0, 0, 0);
		if(first)
        {
			first = false;
        }
        else
        {
			first = true;
        }
		StartGame();
	}

	public void OnClick1()
    {
        if(!win && turn && board[1] != 'X' && board[1] != 'O')
        {
            board[1] = 'X';
			s1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
            CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
    }

	public void OnClick2()
    {
		if (!win && turn && board[2] != 'X' && board[2] != 'O')
		{
			board[2] = 'X';
			s2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick3()
	{
		if (!win && turn && board[3] != 'X' && board[3] != 'O')
		{
			board[3] = 'X';
			s3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick4()
	{
		if (!win && turn && board[4] != 'X' && board[4] != 'O')
		{
			board[4] = 'X';
			s4.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s4.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick5()
	{
		if (!win && turn && board[5] != 'X' && board[5] != 'O')
		{
			board[5] = 'X';
			s5.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s5.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick6()
	{
		if (!win && turn && board[6] != 'X' && board[6] != 'O')
		{
			board[6] = 'X';
			s6.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s6.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick7()
	{
		if (!win && turn && board[7] != 'X' && board[7] != 'O')
		{
			board[7] = 'X';
			s7.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s7.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick8()
	{
		if (!win && turn && board[8] != 'X' && board[8] != 'O')
		{
			board[8] = 'X';
			s8.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s8.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}

	public void OnClick9()
	{
		if (!win && turn && board[9] != 'X' && board[9] != 'O')
		{
			board[9] = 'X';
			s9.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
			s9.GetComponent<Image>().sprite = Resources.Load<Sprite>("Letter_X");
			turn = false;
			playCnt++;
			CheckWin();
			CompPlayer('O', 'X');
			CompUpdate(compMove);
			playCnt++;
			turn = true;
			CheckWin();
		}
	}
}
