using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPlosin : MonoBehaviour
{
    public GameObject prekazka;
    public float spawnRate = 1;
    private float timer = 0;
    public float vyska = .5f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
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
            spawnPipe();
            timer = 0;
        }


    }
    void spawnPipe()
    {
        float nejniz = transform.position.x - vyska;
        float nejvys = transform.position.x + vyska;
        Instantiate(prekazka, new Vector3(Random.Range(nejniz, nejvys),transform.position.y,  0), transform.rotation);
    }
}
