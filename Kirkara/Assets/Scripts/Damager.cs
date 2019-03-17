using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatusEffect
{
    void Effecter();
}

public class Damager : MonoBehaviour
{


    public float damage;
    public IStatusEffect status;
    public string type;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
