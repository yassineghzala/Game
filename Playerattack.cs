using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Playerattack : MonoBehaviour
{
    public Transform attackpoint;
    public float attackrange = 0.5f;
    private Animator anim;
    public LayerMask enemyLayers;
    private bool AB1;
    private float AB1_timer = 0f;
    [SerializeField] private Text tickets;
    //#########################

    // Update is called once per frame
    private void Start()
    {
        AB1 = true;
        anim = GetComponent<Animator>();
        
    }
    void Update()
    {
        if (Input.GetKeyDown("r") && AB1 && AB1_timer==0)
        {
            Attack1();
            
            while (AB1_timer < 7f)
            {
                AB1_timer += Time.deltaTime;
                AB1 = false;
                Debug.Log("you cant use this ability yet");
            }
            AB1 = true;
            AB1_timer = 0;
            Debug.Log("AB1 is available now!!!");
        }
    }
    void Attack1()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackrange,enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            if (transform.position.x < enemy.transform.position.x)
            {
                anim.SetTrigger("at1");
            }
            else
            {
                anim.SetTrigger("al1");
            }
                //Enemyhealth.takeDamage(1);

                Debug.Log("AB1!!!" +enemy.name );
            enemy.GetComponent<Enemyhealth>().takeDamage(1);
            
            if (enemy.GetComponent<Enemyhealth>().currentHealthenemy <= 0)
            {
                enemy.GetComponent<Enemyhealth>().Die();
                this.GetComponent<itemcontroler>().tickets.Amount++;
                tickets.text = "" + this.GetComponent<itemcontroler>().tickets.Amount;
                if (enemy.CompareTag("Boss"))
                {
                    Invoke("loadfinalscene", 1);
                }
            }
            
        }
    }
    public void loadfinalscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
