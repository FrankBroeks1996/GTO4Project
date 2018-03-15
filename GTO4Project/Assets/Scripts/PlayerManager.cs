using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    public List<Player> Players;
    public Image panel;

    private Player playerInTurn;


	// Use this for initialization
	void Start () {
        playerInTurn = Players[0];
        Players[0].gameObject.SetActive(true);
        //panel.color = playerInTurn.color;
    }

    public void ChangePlayer()
    {
        for (int i = 0; i < Players.Count; i++)
        {
            Players[i].gameObject.SetActive(false);
            if (playerInTurn == Players[i])
            {
                if(i == Players.Count - 1)
                {
                    playerInTurn = Players[0];
                }
                else
                {
                    playerInTurn = Players[i + 1];
                }
                break;
            }
        }
        playerInTurn.gameObject.SetActive(true);
    }

    public void BuyUnit()
    {
        playerInTurn.BuyUnit();
    }
}
