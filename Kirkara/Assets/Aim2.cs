using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim2 : MonoBehaviour
{

    
    public Rigidbody2D target;
    private Rigidbody2D rb;

    public float an;
    public float bn;
    //public Vector3 postRotn;

    // Start is called before the first frame update
    void Start()
    {
        
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal2");
        float y = Input.GetAxisRaw("Vertical2");
        Vector2 vec = new Vector2(x, y);

        if (vec != Vector2.zero)
        {
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            Quaternion rot= Quaternion.AngleAxis(angle, Vector3.forward);
            /* if (rot.eulerAngles.z > joint.rotation.eulerAngles.z + 90)
             {
                 z = 69.69f;
                 Quaternion rotationAmount = Quaternion.Euler(0, 0, 90);
                 Quaternion postRotation = joint.rotation * rotationAmount;
                 postRotn = postRotation.eulerAngles;
                 transform.rotation = postRotation;
             }
             else
             {
                 z = rot.eulerAngles.z;
                 transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                 postRotn = transform.rotation.eulerAngles;
             }

             //else
             //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

             if (rot.eulerAngles.z > joint.rotation.eulerAngles.z + 90)
                 z = 69.69f;
             else
                 z = transform.rotation.eulerAngles.z;
                 */
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


            //an = angle;
           // bn=(target.rotation + 180) % 360 - 180;
            
            //if (angle<target.rotation)
           //     rb.rotation = (target.rotation+180);
           // else
                rb.rotation = angle;






        }
    }
}
