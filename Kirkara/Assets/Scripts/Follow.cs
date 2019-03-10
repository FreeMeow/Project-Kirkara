using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform target;
    public float distance;
    public float speed;
    private Rigidbody2D rb;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float angle  = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, angle, 60 * Time.deltaTime));
        //transform.right = target.position - transform.position;
        StartCoroutine(MyCoroutine(target));
        
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector2.Distance(transform.position, target.position) > distance)
        {

            rb.MovePosition(Vector2.MoveTowards((Vector2)transform.position, (Vector2)target.position, speed * Time.deltaTime));
            //rb.MovePosition(Vector2.Lerp(transform.position, target.position, speed * Time.deltaTime));

            
            yield return null;
        }
        yield return new WaitForFixedUpdate();
    }
}