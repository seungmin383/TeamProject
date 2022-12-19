using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Sprite[] shopSprite;
    public GameObject[] shopSlots;
        
    void Start()
    {
        
    }

    void ReRoll()
    {
        for (int i = 0; i < shopSlots.Length; i++)
        {
            int set = 0;
            if (Random.Range(0, 101) > 50)
            {
                if (Random.Range(0, 6) > 2)
                {
                    set = 1;
                }
                else
                {
                    set = 2;
                }
            }
            shopSlots[i].GetComponent<Image>().sprite = shopSprite[set];
        }
    }
    
    void Update()
    {
        
    }
}
