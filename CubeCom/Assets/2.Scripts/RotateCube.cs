using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public List<GameObject> RotateList;

    CheckCube A;
    CheckCube B;
    CheckCube C;

    float originY;

    private Transform CubeViwer;
    private float Speed = 10f;
    private Vector2 nowPos, prePos;
    private Vector3 movePos;
 
    private void Start()
    {
        CubeViwer = GetComponent<Transform>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            RotateList.Clear();

            A = GameObject.Find("SIDE7").GetComponent<CheckCube>();
            B = GameObject.Find("SIDE8").GetComponent<CheckCube>();
            C = GameObject.Find("SIDE9").GetComponent<CheckCube>();
            
            for(int i = 0; i < A.gameObjects.Count; i++)
            {
                RotateList.Add(A.gameObjects[i]);
            }
            for (int i = 0; i < B.gameObjects.Count; i++)
            {
                RotateList.Add(B.gameObjects[i]);
            }
            for (int i = 0; i < C.gameObjects.Count; i++)
            {
                RotateList.Add(C.gameObjects[i]);
            }

            for(int i = 0; i< RotateList.Count; i++)
            {
                originY = RotateList[i].transform.rotation.y;
                Debug.Log(GameObject.Find(RotateList[i].name));

                do
                {
                    GameObject.Find(RotateList[i].name).transform.RotateAround(Vector3.zero, Vector3.up, 90 * Time.deltaTime * Speed);

                }
                while (GameObject.Find(RotateList[i].name).transform.rotation.y == originY + 90);
                
           }
        }

        //if (Input.touchCount >= 1)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        prePos = touch.position - touch.deltaPosition;
        //    }
        //    else if (touch.phase == TouchPhase.Moved)
        //    {
        //        nowPos = touch.position - touch.deltaPosition;

        //        Rotate(CubeViwer.rotation.y);

               
        //        prePos = touch.position - touch.deltaPosition;
        //    }
        //}
    }

    void Rotate(float Y)
    {
        //do
        //{
        //    transform.Rotate(Vector3.down * Time.deltaTime * Speed);
        //}
        //while (transform.rotation == Quaternion.Euler(CubeViwer.rotation.x, Y + 90, CubeViwer.rotation.z));
    }


}
