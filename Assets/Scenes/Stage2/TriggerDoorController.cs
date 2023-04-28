using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator MyDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            if (openTrigger)
            {
                MyDoor.Play("door_1_open", 0, 0.0f);
                gameObject.SetActive(true);
                //MyDoor.Play("door_1_opened", 0, 0.0f);
            }
            else if (closeTrigger)
            {
                MyDoor.Play("door_1_close", 0, 0.0f);
                gameObject.SetActive(true);
            }
        }
    }


}
