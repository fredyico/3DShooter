using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarBase : MonoBehaviour
{
    public Life targetLife;
    Image image;   

    private void Awake()
    {
        image = GameObject.Find("BaseLifeBar").GetComponent<Image>();        
    }

    private void Update()
    {
        image.fillAmount = targetLife.amount / targetLife.MaxHealth; //targetLife.MaxHealth = 100 right now      
    }
}
