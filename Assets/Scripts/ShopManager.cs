using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[5, 5];
    public float uang;
    public Text UangTxt;
    public int kuantitas;

    void Start()
    {
        UangTxt.text = "Uang : " + uang.ToString();

        //id
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //harga
        shopItems[2, 1] = 100;
        shopItems[2, 2] = 35;
        shopItems[2, 3] = 65;

        //Kuantitas
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (uang >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 0)
        {
            uang -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
          
            UangTxt.text = "Uang :" + uang.ToString();

            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
         
        }
    }
}
