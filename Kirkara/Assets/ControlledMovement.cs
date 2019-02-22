using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        //transform.Translate(new Vector3(x, y, 0) * moveSpeed * Time.deltaTime);
        //rb.AddForce(new Vector2(x, y) * moveSpeed * Time.deltaTime,ForceMode2D.Impulse);
        rb.MovePosition((Vector2)transform.position + new Vector2(x, y) * Time.deltaTime * moveSpeed);
        
    }
}
