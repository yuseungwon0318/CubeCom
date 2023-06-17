using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.Image;

public class RotateCube : MonoBehaviour
{
    public List<GameObject> RotateList;

    CheckCube A;
    CheckCube B;
    CheckCube C;

    GameObject originObject;

    public void Rotate(Vector3 dirRotate, CheckCube Line1, CheckCube Line2, CheckCube Line3)
    {
        RotateList.Clear();
        
        Line1.check();
        Line2.check();
        Line3.check();

        for (int i = 0; i < Line1.gameObjects.Count; i++)
        {
            RotateList.Add(Line1.gameObjects[i]);
        }
        for (int i = 0; i < Line2.gameObjects.Count; i++)
        {
            RotateList.Add(Line2.gameObjects[i]);
        }
        for (int i = 0; i < Line3.gameObjects.Count; i++)
        {   
            RotateList.Add(Line3.gameObjects[i]);
        }

        for (int i = 0; i < RotateList.Count; i++)
        {
            originObject = GameObject.Find(RotateList[i].name);
            Debug.Log(GameObject.Find(RotateList[i].name)); 

            originObject.transform.RotateAround(Vector3.zero, dirRotate, Mathf.Rad2Deg * (Mathf.PI / 2));
        }
    }

    public void RotateLeft(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.down, A, B, C);

        A.GetComponent<ChangeNum>().changeNum();
        B.GetComponent<ChangeNum>().changeNum();
        C.GetComponent<ChangeNum>().changeNum();
    }
    public void RotateRight(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.up, A, B, C);

        A.GetComponent<ChangeNum>().changeNum();
        B.GetComponent<ChangeNum>().changeNum();
        C.GetComponent<ChangeNum>().changeNum();
    }
    public void RotateUp(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.left, A, B, C);

        A.GetComponent<ChangeNum>().changeNum();
        B.GetComponent<ChangeNum>().changeNum();
        C.GetComponent<ChangeNum>().changeNum();
    }
    public void RotateDown(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.right, A, B, C);

        A.GetComponent<ChangeNum>().changeNum();
        B.GetComponent<ChangeNum>().changeNum();
        C.GetComponent<ChangeNum>().changeNum();
    }
}
