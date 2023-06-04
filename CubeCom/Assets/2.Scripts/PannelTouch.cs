using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PannelTouch : MonoBehaviour, IPointerClickHandler
{
    string num;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(num);
    }

    // Start is called before the first frame update
    void Start()
    {
        num = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
