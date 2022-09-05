using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W) && transform.position.y <7.5)
        {
            transform.Translate(new Vector2(0f, 1f * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >-7.5)
        {
            transform.Translate(new Vector2(0f, -1f * speed * Time.deltaTime));
        }

    }
}
