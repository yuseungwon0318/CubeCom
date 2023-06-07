using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCube : MonoBehaviour
{
    public List<GameObject> gameObjects;
    float maxDistance = 10f;
    private LayerMask Cube;
    int cubeSize;
    RaycastHit[] hits;


    private void Start()
    {


        cubeSize = 3;
        Cube = LayerMask.NameToLayer("Cube");
        hits = new RaycastHit[cubeSize];
        check();
    }

    void check()
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
        
        
        for(int i = 0; i < cubeSize; i++) 
        {
            RaycastHit hit = hits[i];
            
            if(gameObjects.Count < 3) 
            {
                gameObjects.Add(hit.collider.gameObject);
            }
        }
    }
}
