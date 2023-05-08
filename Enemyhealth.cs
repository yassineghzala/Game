using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemyhealth : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public int maxHealthenemy = 3;
    public  int currentHealthenemy;
    private bool isDead = false;

    private GameObject target;

    private float dtimer;

    /*public gameOver GameOverScreen;

    public healthBar healthBar;*/
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealthenemy = maxHealthenemy;
        //healthBar.SetmaxHealthenemy(maxHealthenemy);
        target = GameObject.FindGameObjectWithTag("bluesquare");
    }

    private void Update()
    {
        if (currentHealthenemy <= 0 && isDead == false)
        {
            
            //Die();
            isDead = true;
            Debug.Log("Enemy DIED!!!");
        }
    }
    public void Die()
    {
        Debug.Log("test!!!");
        if (transform.position.x < target.transform.position.x)
            {
                anim.SetTrigger("deathR1");
            }
            else
            {
                anim.SetTrigger("deathL1");
            }
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<PlayerFollow>().enabled = false;
        this.GetComponent<waypointfollower>().enabled = false;
        this.enabled = false;
        //anim.SetTrigger("death");
        //GameOverScreen.Setup();
    }

    public  void takeDamage(int damage)
    {
        currentHealthenemy -= damage;
        //healthBar.SetHealth(currentHealthenemy);
    }

}