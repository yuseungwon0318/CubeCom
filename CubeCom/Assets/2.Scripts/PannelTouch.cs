using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PannelTouch : MonoBehaviour, IPointerClickHandler
{
    public string num;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (GameManager.Instance.first == false && this.gameObject.name != "5") 
        {
            GameManager.Instance.one = int.Parse(num);
            GameManager.Instance._one = this.gameObject.name;
            GameManager.Instance.first = true;
        }
        else if(GameManager.Instance.first = true && GameManager.Instance.seccond == false && this.gameObject.name != "1" && this.gameObject.name != "3" && this.gameObject.name != "7" && this.gameObject.name != "9")
        {
            switch(GameManager.Instance._one) 
            {
               
                case "1":
                    if (gameObject.name == "2" || gameObject.name == "4")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }

                case "2":
                case "8":
                    if (gameObject.name == "5")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }
                case "3":
                    if (gameObject.name == "2" || gameObject.name == "6")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }
                case "4": 
                case "6":  
                    if (gameObject.name == "5")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }

                case "7":
                    if (gameObject.name == "8" || gameObject.name == "4")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }

                case "9":
                    if (gameObject.name == "8" || gameObject.name == "6")
                    {
                        SeccondCheck();
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }
            }
        }
        else if(GameManager.Instance.first = true && GameManager.Instance.seccond == true && this.gameObject.name != "5")
        {
            switch (GameManager.Instance._two)
            {

                case "2":
                    if (gameObject.name == "1" || gameObject.name == "3" && gameObject.name != GameManager.Instance._one)
                    {
                        ThirdCheck();
                        if(GameManager.Instance.third == true) 
                        {
                            switch(GameManager.Instance._three) 
                            {
                                case "1":
                                    GameManager.Instance.RotateRight("SIDE1", "SIDE2", "SIDE3");
                                   
                                    GameManager.Instance.Reset();
                                    break;
                                case "3":
                                    GameManager.Instance.RotateLeft("SIDE1", "SIDE2", "SIDE3");
                      
                                    GameManager.Instance.Reset();
                                    break;
                            }
                        }

                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }

                case "4":
                    if (gameObject.name == "1" || gameObject.name == "7" && gameObject.name != GameManager.Instance._one)
                    {
                        ThirdCheck();
                        if (GameManager.Instance.third == true)
                        {
                            switch (GameManager.Instance._three)
                            {
                                case "1":
                                    GameManager.Instance.RotateDown("UP1", "UP4", "UP7");
              
                                    GameManager.Instance.Reset();
                                    break;
                                case "7":
                                    GameManager.Instance.RotateUp("UP1", "UP4", "UP7");
                               
                                    GameManager.Instance.Reset();
                                    break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }
                case "5":
                    if ((gameObject.name == "2" && GameManager.Instance._one == "8") || (gameObject.name == "4" && GameManager.Instance._one == "6") || (gameObject.name == "6" && GameManager.Instance._one == "4") || (gameObject.name == "8" && GameManager.Instance._one == "2"))
                    {
                        ThirdCheck();
                        if (GameManager.Instance.third == true)
                        {
                            switch (GameManager.Instance._three)
                            {
                                case "2":
                                    GameManager.Instance.RotateDown("UP2", "UP5", "UP8");

                                    GameManager.Instance.Reset();
                                    break;
                                case "4":
                                    GameManager.Instance.RotateLeft("SIDE4", "SIDE5", "SIDE6");
                                    GameManager.Instance.Reset();
                                    break;
                                case "6":
                                    GameManager.Instance.RotateRight("SIDE4", "SIDE5", "SIDE6");
                                    GameManager.Instance.Reset();
                                    break;
                                case "8":
                                    GameManager.Instance.RotateUp("UP2", "UP5", "UP8");
                                    GameManager.Instance.Reset();
                                    break;
                            }
                        }
                        break;
                    }
                    else
                    { 
                        Failed();
                        break;
                    }
                case "6":
                    if (gameObject.name == "3" || gameObject.name == "9" && gameObject.name != GameManager.Instance._one) 
                    {
                        ThirdCheck();
                        if (GameManager.Instance.third == true)
                        {
                            switch (GameManager.Instance._three)
                            {
                                case "3":
                                    GameManager.Instance.RotateDown("UP3", "UP6", "UP9");
                                    GameManager.Instance.Reset();
                                    break;
                                case "9":
                                    GameManager.Instance.RotateUp("UP3", "UP6", "UP9");
                                    GameManager.Instance.Reset();
                                    break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }

                case "8":
                    if (gameObject.name == "7" || gameObject.name == "9" && gameObject.name != GameManager.Instance._one)
                    {
                        ThirdCheck();
                        if (GameManager.Instance.third == true)
                        {
                            switch (GameManager.Instance._three)
                            {
                                case "7":
                                    GameManager.Instance.RotateLeft("SIDE7", "SIDE8", "SIDE9");
                                    GameManager.Instance.Reset();
                                    break;
                                case "9":
                                    GameManager.Instance.RotateRight("SIDE7", "SIDE8", "SIDE9");
                                    GameManager.Instance.Reset();
                                    break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Failed();
                        break;
                    }
            }
        }

        else
        {
            Failed();
        }


    }

    void Start()
    {
        num = GetComponentInChildren<CheckFront>().Num;
    }

    // Update is called once per frame
    void Update()
    {
        num = GetComponentInChildren<CheckFront>().Num;
    }

    public void Failed()
    {
        //if (gameObject.name == "5")
        //{
        //    GameManager.Instance.Reset();
        //}
        //else
        //{
        //    GameManager.Instance.Reset();
        //    GameManager.Instance.one = int.Parse(num);
        //    GameManager.Instance._one = gameObject.name;
        //}
        GameManager.Instance.Reset();
    }

    public void SeccondCheck()
    {
        if(GameManager.Instance.one <= int.Parse(num))
        {
            GameManager.Instance.two = int.Parse(num);
            GameManager.Instance._two = gameObject.name;
            GameManager.Instance.seccond = true;
        }
        else
        {
            Failed();
        }
    }

    public void ThirdCheck()
    {
        if (GameManager.Instance.two <= int.Parse(num))
        {
            GameManager.Instance.three = int.Parse(num);
            GameManager.Instance._three = gameObject.name;
            GameManager.Instance.third = true;

        }
        else
        {
            Failed();
        }
    }
    
}
