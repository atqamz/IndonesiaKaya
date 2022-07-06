using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text HargaTxt;
    public GameObject ShopManager;


    void Update()
    {
        HargaTxt.text = "harga : Rp." + ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
    }
}
