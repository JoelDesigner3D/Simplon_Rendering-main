using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
Unity ne permet pas de modifier directement l'asset Lighting Settings pendant l'exécution,
car il s'agit d'une ressource statique chargée lors de la phase d'initialisation.
*/


public class NightAndDayButtonManager : MonoBehaviour
{
    private bool sunRises;

    [Tooltip("The Text component uses to display the day/night state")]
    [SerializeField] private Text field;

    [SerializeField] private Material skyboxDay;
    [SerializeField] private Material skyboxNight;

    [SerializeField] private Color ambientLightColorDay;
    [SerializeField] private Color ambientLightColorNight;

   // [SerializeField] private LightingSettings LightingSettingsDay;
   // [SerializeField] private LightingSettings LightingSettingsNight;

    //[SerializeField] private RenderSettings renderSettingsDay;
   // [SerializeField] private RenderSettings renderSettingsNight;

   // [SerializeField] private LightmapData lightmapDataDay;
   // [SerializeField] private LightmapData lightmapDataNight;

    //[SerializeField] private LightmapData LightmapDataDay;
    // [SerializeField] private LightmapData LightmapDataNight;



    private void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        DebugXR.Instance.Log("Current scene is: " + currentScene.name);

        if (currentScene.name == "DemoRendu")
        {
            sunRises = true;
            field.text = "Jour";
        }
        else if(currentScene.name == "DemoRenduNight")
        {
            sunRises = false;
            field.text = "Nuit";
        }
        
    }


    public void ToggleSunny()
    {
        if (sunRises)
        {
            sunRises = false;
            field.text = "Nuit";

            SceneManager.LoadScene(1);

            //ChangeLightingSettings(LightingSettingsNight);

            //RenderSettings.skybox = skyboxNight;
            //RenderSettings.ambientLight = ambientLightColorNight;


        }
        else
        {
            sunRises = true;
            field.text = "Jour";

            SceneManager.LoadScene(0);

            //ChangeLightingSettings(LightingSettingsDay);

            //RenderSettings.skybox = skyboxDay;
            //RenderSettings.ambientLight = ambientLightColorDay;
        }

       // DynamicGI.UpdateEnvironment();
    }

    public void ChangeLightingSettings(LightingSettings lightingSettings)
    {
        // Vérifiez si les paramètres d'éclairage ne sont pas nuls
        if (lightingSettings != null)
        {

            //RenderSettings.ambientLight = 

            /**

            RenderSettings.sun = lightingSettings.sun;
            RenderSettings.ambientMode = lightingSettings.ambientMode;
            RenderSettings.ambientSkyColor = lightingSettings.ambientSkyColor;
            RenderSettings.ambientEquatorColor = lightingSettings.ambientEquatorColor;
            RenderSettings.ambientGroundColor = lightingSettings.ambientGroundColor;
            */
        }
    }


}
