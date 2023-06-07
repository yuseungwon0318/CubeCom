using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.VersionControl;
using UnityEngine;

public class ChangeNum : MonoBehaviour
{
    int randomNum;

    public List<Material> Num = new List<Material>();

    private void Start()
    {
        changeNum();
    }

    void changeNum()
    {
        randomNum = Random.Range(1, Num.Count);

        gameObject.GetComponent<MeshRenderer>().material = Num[randomNum -1];
    }
}
