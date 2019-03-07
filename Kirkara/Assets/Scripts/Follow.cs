using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform target;
    public float distance;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;
        while ((transform.position - target.position).magnitude - distance > 0)
            transform.position = Vector2.Lerp(transform.position, target.position, Time.deltaTime);
    }
}
