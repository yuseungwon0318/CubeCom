using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Transform CubeViwer;
    private float Speed = 20f;
    private Vector2 nowPos, prePos;
    private Vector3 movePos;
 
    private void Start()
    {
        CubeViwer = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.touchCount >= 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                nowPos = touch.position - touch.deltaPosition;

                Rotate(CubeViwer.rotation.y);

               // CubeViwer.transform.rotation = Quaternion.Euler(new Vector3(CubeViwer.rotation.x, CubeViwer.transform.rotation.y + 90 * Time.deltaTime, CubeViwer.rotation.z));
                prePos = touch.position - touch.deltaPosition;
            }
        }
    }

    void Rotate(float Y)
    {
        do
        {
            transform.Rotate(Vector3.down * Time.deltaTime * Speed);
        }
        while (transform.rotation == Quaternion.Euler(CubeViwer.rotation.x, Y + 90, CubeViwer.rotation.z));
    }


}
