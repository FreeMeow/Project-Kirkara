using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    public float maxLife;
    private float currentLife;
    public string type;
    private string weakTo;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
        switch (type)
        {
            case "fire":
                weakTo = "Water";
                break;
        }//add more later.
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLife <= 0)
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damager penis = collision.gameObject.GetComponent<Damager>();
        if(penis != null)
        {
            if (string.Compare(weakTo, penis.type) == 0)
            {
                currentLife -= penis.damage * 1.5f;
            }
            else
            {
                currentLife -= penis.damage;
            }
            Destroy(penis);
        }
    }
}
