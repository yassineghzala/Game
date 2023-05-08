using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private BoxCollider2D coll;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    public Sprite[] sprites;
    [SerializeField]
    private float speed = 2f;
    public static float x;
    public static float y;
    public Sprite sprite1;


    private enum mvstate {idle, right, left, top, down}
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

    }
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");

        y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x * speed, y * speed);

        updatestate();

    }
    private void updatestate()
    {
        mvstate state;


        if (y > 0)
        {
            state = mvstate.top;
        }
        else if (y < 0)
        {
            state = mvstate.down;
        }
        else if (x > 0)
        {
            state = mvstate.right;
        }
        else if (x < 0)
        {
            state = mvstate.left;
        }
        else
        {
            state = mvstate.idle;
        }

        anim.SetInteger("walkanim", (int)state);
    }
}