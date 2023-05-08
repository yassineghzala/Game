using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFollow : MonoBehaviour
{
    private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private float range;
    private float TBH = 0f;
     private Animator anim;
    private float oldPosX;

    public healthbarscript healthbar;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("bluesquare");
        oldPosX = transform.position.x;
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
        range = Vector3.Distance(target.transform.position, transform.position);
        if(range <= 3.5f && range >= 0.5f)
        {
            this.gameObject.GetComponent<waypointfollower>().enabled = false;
            FollowPlayer();
            
        }
        else
        {
            this.gameObject.GetComponent<waypointfollower>().enabled = true;
        }
        if (range <= 1f)
        {
            this.gameObject.GetComponent<waypointfollower>().enabled = false;
            HitPlayer();
        }
    }
    public void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        if (oldPosX < transform.position.x)
        {
            
            anim.SetFloat("Horizontal", -1);
            oldPosX = transform.position.x;
        }
        else if (oldPosX > transform.position.x)
        {
           
            anim.SetFloat("Horizontal", 1);
            oldPosX = transform.position.x;
        }
    }
    public void HitPlayer()
    {
        TBH += Time.deltaTime;
        if (TBH >= 2f)
        {
            if(transform.position.x < target.transform.position.x)
            {
                anim.SetTrigger("attackR1");
            }
            else
            {
                anim.SetTrigger("attackL1");
            }

            PlayerHealth.takeDamage(1);
            
            TBH = 0f;
            Debug.Log("HIT");
            Debug.Log(PlayerHealth.currentHealth);
        }
        healthbarscript.SetHealth(PlayerHealth.currentHealth);

    }
}
