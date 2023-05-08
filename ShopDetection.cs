using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ShopDetection : MonoBehaviour
{
    private GameObject playeruser;

    public GameObject shop;
    private float range;
    // Start is called before the first frame update
    void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }

    // Update is called once per frame
    void Update()
    {
        range = Vector3.Distance(playeruser.transform.position, transform.position);
        if(range < 4 && Input.GetKeyDown("space"))
        {
            if (shop.activeInHierarchy == false)
            {
                shop.SetActive(true);
                playeruser.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }
            else
            {
                shop.SetActive(false);
                playeruser.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }
}
