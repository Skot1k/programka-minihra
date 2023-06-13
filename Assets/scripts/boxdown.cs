using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxdown : MonoBehaviour
{

    public float spawnRate = 5;
    private float timer = 0;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
    }
}
