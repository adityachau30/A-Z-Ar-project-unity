using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panneltoggle : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject Informationpannel;

    public void TogglePannel()
    {
        if(isOn)
        {
            Informationpannel.SetActive(false);
            isOn = false;
        }
        else
        {
            Informationpannel.SetActive(true);
            isOn = true;
        }
    }
}
