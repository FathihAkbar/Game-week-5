using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movechar : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
     public float jumpForce = 5f;
    public Animator animasi;
    public bool isLeft;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pindah")
        {
            SceneManager.LoadScene("Scene 3");
        }
        if(col.tag == "balik")
        {
            SceneManager.LoadScene("Scene 2");
        }
        if(col.tag == "pulang")
        {
            SceneManager.LoadScene("Rumah");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Walk();

    }

    void Walk()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        if(moveInput != 0){
            animasi.SetBool("iswalking", true);
        }else{
            animasi.SetBool("iswalking", false);
        }

        if (moveInput > 0)
        {
            transform.localScale = new Vector3(18, 18, 18);
            isLeft = false;
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-18, 18, 18);
            isLeft = true;
        }
    }

    
}
