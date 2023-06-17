using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.VersionControl;
using UnityEngine;

public class ChangeNum : MonoBehaviour
{
    int randomNum;

    public List<Material> Num = new List<Material>();
    public Material Base;

    private void Start()
    {
        changeNum();
        this.GetComponent<MeshRenderer>().material = Base;
    }

    public void changeNum()
    {
        Debug.Log("¹Ù²ï´ç");
        randomNum = Random.Range(1, Num.Count);

        //gameObject.GetComponent<MeshRenderer>().material = Num[randomNum -1];

        for(int i = 0; i < 7; i++) 
        {
            gameObject.GetComponentsInChildren<MeshRenderer>()[i].material = Num[randomNum - 1];
        }

        this.gameObject.tag = Num[randomNum - 1].name;

       
    }
}
