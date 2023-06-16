using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public static GameManager Instance
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

    public bool first = false;
    public bool seccond = false;
    public bool third = false;

    public int one, two, three;
    public string _one, _two, _three;

    public void Reset()
    {
        one = 0; two = 0; three = 0;
        _one = ""; _two = ""; _three = "";
        first = false; seccond = false; third = false;
    }

    public List<GameObject> RotateList;

    CheckCube A;
    CheckCube B;
    CheckCube C;

    GameObject originObject;
    void Rotate(Vector3 dirRotate, CheckCube Line1, CheckCube Line2, CheckCube Line3)
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

    public void RotateRight(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.down, A, B, C);
    }
    public void RotateLeft(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.up, A, B, C);
    }
    public void RotateDown(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.left, A, B, C);
    }
    public void RotateUp(string a, string b, string c)
    {
        A = GameObject.Find(a).GetComponent<CheckCube>();
        B = GameObject.Find(b).GetComponent<CheckCube>();
        C = GameObject.Find(c).GetComponent<CheckCube>();

        Rotate(Vector3.right, A, B, C);
    }
}
