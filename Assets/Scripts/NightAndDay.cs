using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightAndDay : MonoBehaviour
{

    [SerializeField] private Light directionalLight;



    public void DoNight()
    {
        directionalLight.gameObject.active = false;
    }

    public void DoDay()
    {
        directionalLight.gameObject.active = true;
    }

}
