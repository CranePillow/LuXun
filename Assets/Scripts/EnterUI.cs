using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterUI : MonoBehaviour
{
    public GameObject jieShaoUI;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            jieShaoUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            jieShaoUI.SetActive(false);
        }
    }
}
