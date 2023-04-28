using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Life targetLife;
    Image image;
    Image image2;

    private void Awake()
    {
        image = GameObject.Find("LifeBar").GetComponent<Image>();
        image2 = GameObject.Find("BaseLifeBar").GetComponent<Image>();
    }

    private void Update()
    {
        image.fillAmount = targetLife.amount / targetLife.MaxHealth; //targetLife.MaxHealth = 100 right now
        image2.fillAmount = targetLife.amount / targetLife.MaxHealth; //targetLife.MaxHealth = 100 right now
    }

}
