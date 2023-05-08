using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    [SerializeField] public Text Health;
    [SerializeField] public Text Healthp;
    public static healthbarscript healthbar;

    public int maxHealth = 20;
    public static int currentHealth;
    private bool isDead = false;

    public Slider slider;

    /*public gameOver GameOverScreen;

    public healthBar healthBar;*/
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    
        //healthBar.SetMaxHealth(maxHealth);

    }

    private void Update()
    {
        
        if (currentHealth <= 0 && isDead == false)
        {
            Die();
            anim.SetTrigger("pdeath");
            isDead = true;
            Debug.Log("U DIED!!!");
        }
        if(currentHealth < maxHealth && this.GetComponent<itemcontroler>().healp.Amount > 0 && Input.GetKeyDown("h"))
        {
            currentHealth = currentHealth + 1;
            this.GetComponent<itemcontroler>().healp.Amount--;
            Healthp.text = this.GetComponent<itemcontroler>().healp.Amount +"";
        }
        Health.text = currentHealth + " / 20";      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") && currentHealth > 0)
        {
            takeDamage(1);
            //rb.bodyType = RigidbodyType2D.Static;
        }

    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
        //GameOverScreen.Setup();
        Invoke("restartlevel",2);
        
    }
    private void restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void takeDamage(int damage)
    {
        currentHealth -= damage;
        //healthBar.SetHealth(currentHealth);
    }

}