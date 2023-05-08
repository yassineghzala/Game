using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveltransition1 : MonoBehaviour
{
    public GameObject doorch1;
    public GameObject doorch2;
    private float range1;
    private float range2;
    private GameObject playeruser;
    // Start is called before the first frame update
    void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }

    // Update is called once per frame
    void Update()
    {
        range1 = Vector3.Distance(playeruser.transform.position, doorch1.transform.position);
        range2 = Vector3.Distance(playeruser.transform.position, doorch2.transform.position);
        if (range1 < 1 && Input.GetKeyDown("o") && playeruser.GetComponent<itemcontroler>().k1.playrhasthiskey == true)
        {
            playeruser.transform.position = doorch2.transform.position;
        }
        if(range2 < 1 && Input.GetKeyDown("o"))
        {
            playeruser.transform.position = doorch1.transform.position;
        }
    }
}
