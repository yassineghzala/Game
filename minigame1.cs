using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame1 : MonoBehaviour
{
   public GameObject canvas;
   public void activate()
    {
        if (canvas.activeInHierarchy == false)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
