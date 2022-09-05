using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBall : MonoBehaviour
{
    public float initialSpeed;
    public float speedMultiplier;
    public float angleMultiplier;
    public GameObject spawnPoint;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float currX, currY;
    private bool firstTime = false;
    private int bounces=0;

    // Start is called before the first frame update

    void randomMovement()
    {
        int xcount = Random.Range(0, 2), ycount = Random.Range(-10, 10);
        switch (xcount)
        {
            case 0:
                currX = 1 * initialSpeed;
                break;
            case 1:
                currX = -1 * initialSpeed;
                break;

        }
        currY = (float)(ycount / 10.0) * initialSpeed;
    }

    void Start()
    {
        //GameObject temp = Instantiate(spawnMovingBall, new Vector2(0, 0), Quaternion.identity); 
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        randomMovement();
        TimerManager.timeStarted = true;
    }
    
    void respawn()
    {
        transform.position = spawnPoint.transform.position;
        randomMovement();
        firstTime = false;
        //rb.velocity = new Vector2(currX, currY);
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(currX, currY);
    }

    private void changeColor()
    {
        Color newColor = new Color(Random.Range(0f,1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        sr.color = newColor;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            //Debug.Log("Hitted Wall" + currY);
            currY = -currY;
            //Debug.Log(currY);
            return;
        }
        if (collision.gameObject.CompareTag("Player") && Mathf.Abs( transform.position.x) - Mathf.Abs(collision.gameObject.transform.position.x) <=0)
        {
            changeColor();
            currX = -currX;
            currY = angleMultiplier*(transform.position.y - collision.gameObject.transform.position.y);
            if (!firstTime)
            {
                firstTime = true;
                currX *= speedMultiplier;
            }

            return;
        }
        if (collision.gameObject.name == "WallLeft")
        {
            
            respawn();
            ScoreManager.instance.AddPoint2();
            return;
        }
        if (collision.gameObject.name == "WallRight")
        {
            
            respawn();
            ScoreManager.instance.AddPoint1();
            return;
        }
    }

    
        
        
    
}
