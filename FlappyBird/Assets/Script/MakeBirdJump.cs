using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBirdJump : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    Rigidbody2D rb;
    Animator an;
    // Start is called before the first frame update
    void Start()
    {
        an = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            an.SetTrigger("Flap");
            rb.velocity = Vector2.up * speed;
        }
    }
}
