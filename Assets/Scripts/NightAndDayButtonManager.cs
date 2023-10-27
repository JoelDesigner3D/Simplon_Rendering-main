using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightAndDayButtonManager : MonoBehaviour
{
    private bool sunRises = true;

    [Tooltip("The Text component uses to display the day/night state")]
    [SerializeField] private Text field;

    [SerializeField] private Material skyboxDay;
    [SerializeField] private Material skyboxNight;

    [SerializeField] private Color ambientLightColor;


    private void Awake()
    {
        field.text = "Jour";
    }


    public void ToggleSunny()
    {
        if (sunRises)
        {
            sunRises = false;
            field.text = "Nuit";
            RenderSettings.skybox = skyboxNight;

            RenderSettings.ambientLight = ambientLightColor;

        }
        else
        {
            sunRises = true;
            field.text = "Jour";
            RenderSettings.skybox = skyboxDay;
        }

        DynamicGI.UpdateEnvironment();
    }


}
