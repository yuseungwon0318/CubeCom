using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCube : MonoBehaviour
{
    public List<GameObject> gameObjects;
    float maxDistance = 10f;
    private LayerMask Cube;
    float cubeSize;

    private void Start()
    {
        cubeSize = 3;
        Cube = LayerMask.NameToLayer("Cube");
    }

    private void Update()
    {
        check();
    }

    void check()
    {
        RaycastHit hit;
        Debug.DrawRay(this.transform.position, transform.right * maxDistance, Color.blue, 0.3f);
        if(Physics.Raycast(this.transform.position, transform.right, out hit, maxDistance, Cube))
        {
            Debug.Log(hit.transform.name);
            gameObjects.Add(hit.transform.GetComponent<GameObject>());
            /*for (int i = 0; i < cubeSize; i++)
            {
                

            }*/
        }

    }
}
