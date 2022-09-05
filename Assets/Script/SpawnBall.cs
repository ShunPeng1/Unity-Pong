using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{

    public GameObject spawnMovingBall;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnMovingBall, new Vector2(0, 0), Quaternion.identity);

    }

    public void respawn()
    {
        
        Instantiate(spawnMovingBall, new Vector2(0, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
