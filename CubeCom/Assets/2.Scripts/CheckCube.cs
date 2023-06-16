using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckCube : MonoBehaviour
{

    private static CheckCube instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public static CheckCube Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }

            return instance;
        }
    }

    public List<GameObject> gameObjects;
    float maxDistance = 10f;
    private LayerMask Cube;
    int cubeSize;
    RaycastHit[] hits;
    RaycastHit hit;


    private void Start()
    {
        cubeSize = 3;
        Cube = LayerMask.NameToLayer("Cube");
        hits = new RaycastHit[cubeSize];
        check();
    }

    public void check()
    {
        gameObjects.Clear();
        if(this.gameObject.CompareTag("UP"))
        {
            hits = Physics.RaycastAll(gameObject.transform.position, Vector3.down, maxDistance);

        }
        else if(this.gameObject.CompareTag("SIDE"))
        {
            hits = Physics.RaycastAll(gameObject.transform.position, Vector3.right, maxDistance);
        }
        
        
        if(this.gameObject.CompareTag("UP") || this.gameObject.CompareTag("SIDE"))
        {
            for (int i = 0; i < cubeSize; i++)
            {
                RaycastHit hit = hits[i];

                if (gameObjects.Count < 3)
                {
                    gameObjects.Add(hit.collider.gameObject);
                }
            }
        }
       
    }
}
