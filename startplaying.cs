using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startplaying : MonoBehaviour
{
    public GameObject previouscanvas;
    public GameObject canvas;
    public GameObject startcanvas;
    public GameObject playeruser;

    // Start is called before the first frame update
    private void Start()
    {
        playeruser = GameObject.FindGameObjectWithTag("bluesquare");
    }
    public void go_to_next_scene()
    {
        if(canvas.activeInHierarchy == false && previouscanvas.activeInHierarchy== true)
        {
            playeruser.GetComponent<SpriteRenderer>().enabled = false;
            previouscanvas.SetActive(false);
            canvas.SetActive(true);
            startcanvas.SetActive(false);

            
        }
        else
        {
           
            canvas.SetActive(false);
        }
    }
    public void go_back()
    {
        SceneManager.UnloadSceneAsync("test2");
    }
}
