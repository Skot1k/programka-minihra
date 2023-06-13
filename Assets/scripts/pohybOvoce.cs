using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybOvoce : MonoBehaviour
{
    public float moveSpeed = 1;
    public float deleteObject = -6;
    // Start is called before the first frame update
    void Start()
    {
    
    
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;

        if (transform.position.y < deleteObject)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
