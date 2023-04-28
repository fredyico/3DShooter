using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarPlayer : MonoBehaviour
{
    public Life targetLife;
    Image image;

    private void Awake()
    {
        image = GameObject.Find("LifeBar").GetComponent<Image>();
    }

    private void Update()
    {
        image.fillAmount = targetLife.amount / targetLife.MaxHealth; //targetLife.MaxHealth = 100 right now       
    }
}
