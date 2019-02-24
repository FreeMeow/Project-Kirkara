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
        Vector2 vec = new Vector2(x, y);

        if (vec != Vector2.zero)
        {
            var angle = Mathf.Atan2(y,x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
            
        rb.MovePosition((Vector2)transform.position + vec * Time.deltaTime * moveSpeed);
        
    }
}
