using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEconomy : MonoBehaviour
{
    public GameObject inventory2;

    public int addedamount = 1;

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

    // Start is called before the first frame update
    void Start()
    {
        inventory2 = GameObject.FindGameObjectWithTag("inv");
        this.GetComponent<itemcontroler>().tickets.Amount = 0;
        this.GetComponent<itemcontroler>().ep1.Amount = 0;
        this.GetComponent<itemcontroler>().ep2.Amount = 0;
        this.GetComponent<itemcontroler >().pen.Amount = 0;
        this.GetComponent<itemcontroler>().mouse.Amount = 0;
        this.GetComponent<itemcontroler>().screen.Amount = 0;
        this.GetComponent<itemcontroler>().keyboard.Amount = 0;
        this.GetComponent<itemcontroler>().healp.Amount = 0;
        this.GetComponent<itemcontroler>().k1.playrhasthiskey = false;
        this.GetComponent<itemcontroler>().k2.playrhasthiskey = false;
        this.GetComponent<itemcontroler>().k3.playrhasthiskey = false;
    }
    public void AddAmount(int AddedAmount, int AmountToaddto)
    {
        AmountToaddto = AmountToaddto + AddedAmount;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ticket"))
        {
            this.GetComponent<itemcontroler>().tickets.Amount++;
            Destroy(collision.gameObject);
            tickets.text = "" + this.GetComponent<itemcontroler>().tickets.Amount;
            Debug.Log("amount after buying and collision: " + this.GetComponent<itemcontroler>().tickets.Amount);
        }
        if (collision.gameObject.CompareTag("ep1"))
        {
            this.GetComponent<itemcontroler>().ep1.Amount++;
            Destroy(collision.gameObject);
            ep1.text = "" + this.GetComponent<itemcontroler>().ep1.Amount;
        }
        if (collision.gameObject.CompareTag("ep2"))
        {
            this.GetComponent<itemcontroler>().ep2.Amount++;
            Destroy(collision.gameObject);
            ep2.text = "" + this.GetComponent<itemcontroler>().ep2.Amount;
        }
        if (collision.gameObject.CompareTag("pen"))
        {
            this.GetComponent<itemcontroler>().pen.Amount++;
            Destroy(collision.gameObject);
            pen.text = "" + this.GetComponent<itemcontroler>().pen.Amount;
        }
        if (collision.gameObject.CompareTag("mouse"))
        {
            this.GetComponent<itemcontroler>().mouse.Amount++;
            Destroy(collision.gameObject);
            mouse.text = "" + this.GetComponent<itemcontroler>().mouse.Amount;
        }
        if (collision.gameObject.CompareTag("keyboard"))
        {
            this.GetComponent<itemcontroler>().keyboard.Amount++;
            Destroy(collision.gameObject);
            keyboard.text = "" + this.GetComponent<itemcontroler>().keyboard.Amount;
        }
        if (collision.gameObject.CompareTag("screen"))
        {
            this.GetComponent<itemcontroler>().screen.Amount++;
            Destroy(collision.gameObject);
            screen.text = "" + this.GetComponent<itemcontroler>().screen.Amount;
        }
        if (collision.gameObject.CompareTag("skey1"))
        {
            this.GetComponent<itemcontroler>().k1.playrhasthiskey = true;
            Destroy(collision.gameObject);
            key1.text = "Collected";
        }
        if (collision.gameObject.CompareTag("skey2"))
        {
            this.GetComponent<itemcontroler>().k2.playrhasthiskey = true;
            Destroy(collision.gameObject);
            key2.text = "Collected";
        }
        if (collision.gameObject.CompareTag("skey3"))
        {
            this.GetComponent<itemcontroler>().k3.playrhasthiskey = true;
            Destroy(collision.gameObject);
            key3.text = "Collected";
        }
    }
    
}