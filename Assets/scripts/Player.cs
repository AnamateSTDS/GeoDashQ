using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbodyone;
    [SerializeField] private Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private SpriteRenderer sprite;

    private bool isDied;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigidbodyone.velocity = new Vector2(-speed, rigidbodyone.velocity.y);
                sprite.flipX = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rigidbodyone.velocity = new Vector2(speed, rigidbodyone.velocity.y);
                sprite.flipX = false;
            }
            animator.SetBool("is_run",true);
        }
        else
        {
            animator.SetBool("is_run",false);
            
        }
            
    }
    
        
       
}
