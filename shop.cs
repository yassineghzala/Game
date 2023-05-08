using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public GameObject playeruser;
    public Item itemtobuy;

    [SerializeField] private Text tickets;
    [SerializeField] private Text key1;
    [SerializeField] private Text key2;
    [SerializeField] private Text key3;
    [SerializeField] private Text pen;
    [SerializeField] private Text ep1;
    [SerializeField] private Text ep2;
    [SerializeField] private Text keyboard;
    [SerializeField] private Text screen;
    [SerializeField] private Text mouse;

    [SerializeField] private Text hpotion;
    private void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }
    public void buyitem()
    {
        Debug.Log("amount before: " + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount);
        if (playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount >= itemtobuy.price)
        {
            playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount -= itemtobuy.price;
            tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
            switch (itemtobuy.ItemName)
            {
                case "healp": playeruser.gameObject.GetComponent<itemcontroler>().healp.Amount++;
                              hpotion.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().healp.Amount;
                              break;
                case "damagep": playeruser.gameObject.GetComponent<itemcontroler>().damagep.Amount++; 
                                Debug.Log("damagep bought from the shop"); 
                                break;
            }
        }
        else
        {
            Debug.Log("you cant buy that!!!");
        }
    }
    public void sellitem()
    {
        switch (itemtobuy.ItemName)
        {
            case "ep1":
                if (playeruser.gameObject.GetComponent<itemcontroler>().ep1.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().ep1.Amount--;
                    ep1.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().ep1.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().ep1.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
            case "ep2":
                if (playeruser.gameObject.GetComponent<itemcontroler>().ep2.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().ep2.Amount--;
                    ep2.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().ep2.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().ep2.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
            case "pen":
                if (playeruser.gameObject.GetComponent<itemcontroler>().pen.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().pen.Amount--;
                    pen.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().pen.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().pen.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
            case "keyboard":
                if (playeruser.gameObject.GetComponent<itemcontroler>().keyboard.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().keyboard.Amount--;
                    keyboard.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().keyboard.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().keyboard.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
            case "screen":
                if (playeruser.gameObject.GetComponent<itemcontroler>().screen.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().screen.Amount--;
                    screen.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().screen.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().screen.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
            case "mouse":
                if (playeruser.gameObject.GetComponent<itemcontroler>().mouse.Amount > 0)
                {
                    playeruser.gameObject.GetComponent<itemcontroler>().mouse.Amount--;
                    mouse.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().mouse.Amount;
                    playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount += playeruser.gameObject.GetComponent<itemcontroler>().mouse.price;
                    tickets.text = "" + playeruser.gameObject.GetComponent<itemcontroler>().tickets.Amount;
                }
                break;
        }
    }
}
