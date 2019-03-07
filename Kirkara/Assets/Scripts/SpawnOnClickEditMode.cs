using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class SpawnOnClickEditMode : MonoBehaviour
{

public GameObject[] spawnableObjects;
    public GameObject parent;
    void Start() {
        SceneView.onSceneGUIDelegate += this.OnSceneGooey;
    }
    
    void OnSceneGooey(SceneView sceneview)
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown) {
            switch (e.keyCode) {
                case KeyCode.I : 
                int ObjectChoice = (int)Random.Range(0, spawnableObjects.Length);
                Instantiate(spawnableObjects[ObjectChoice], transform.position, Quaternion.identity, parent.transform);
                break;
                case KeyCode.A : transform.position = new Vector2(transform.position.x - 1, transform.position.y);
                break;
                case KeyCode.D : transform.position = new Vector2(transform.position.x + 1, transform.position.y);
                break;
                case KeyCode.W : transform.position = new Vector2(transform.position.x, transform.position.y + 1);
                break;
                case KeyCode.S : transform.position = new Vector2(transform.position.x, transform.position.y - 1);
                break;
            }
        }  
            
    }

    void OnDestroy() {
       SceneView.onSceneGUIDelegate -= this.OnSceneGooey;
    }
}
 