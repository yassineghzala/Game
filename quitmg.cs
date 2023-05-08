using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class quitmg : MonoBehaviour
{
    public GameObject quitcanvas;
    public GameObject playeruser;
    public GameObject startcanvas;
    // Start is called before the first frame update
    void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }
    public void quitminigame()
    {
        if(quitcanvas.activeInHierarchy == true)
        {
            quitcanvas.SetActive(false);
            startcanvas.SetActive(true);
            playeruser.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("TESTTESTTEST§§§");
            playeruser.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
