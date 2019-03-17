using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float deadZone = .1f; 
    public float cameraSpeed = .1f;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance((Vector2)transform.position, (Vector2)playerTransform.position) > deadZone) {
            Vector2 newPos = Vector2.Lerp((Vector2)transform.position, (Vector2)playerTransform.position, cameraSpeed*Time.deltaTime);
            transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
            Debug.Log("moving " + Vector2.Distance((Vector2)transform.position, newPos) + " units");
            
        }
    }
}
