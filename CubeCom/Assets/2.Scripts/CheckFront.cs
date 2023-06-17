using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFront : MonoBehaviour
{
    RaycastHit hit;
    public string Num;
    public GameObject A;

    private void Start()
    {
        FrontCheck();
    }
    private void Update()
    {
        FrontCheck();
    }


    void FrontCheck()
    {
        Debug.DrawRay(transform.position, Vector3.forward, Color.yellow);
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 10f))
        {
            Num = hit.collider.tag;
            A = hit.collider.gameObject;
        }
    }
}
