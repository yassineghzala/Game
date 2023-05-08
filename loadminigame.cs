using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadminigame : MonoBehaviour
{
    public GameObject minigame;

    private float range1;
    private GameObject playeruser;
    // Start is called before the first frame update
    void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }

    // Update is called once per frame
    void Update()
    {
        range1 = Vector3.Distance(playeruser.transform.position, transform.position);
        if (Input.GetKeyDown("space"))
        {
            if (minigame.activeInHierarchy == false)
            {
                minigame.SetActive(true);
                playeruser.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }
        }
        /*else
        {
            minigame.SetActive(false);
        }*/
    }
}
