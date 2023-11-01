using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
Unity ne permet pas de modifier directement l'asset Lighting Settings pendant l'exécution,
car il s'agit d'une ressource statique chargée lors de la phase d'initialisation.
*/


public class NightAndDayButtonController : MonoBehaviour
{
    private bool sunRises;

    [Tooltip("The Text component uses to display the day/night state")]
    [SerializeField] private Text field;

    [SerializeField] private Material skyboxDay;
    [SerializeField] private Material skyboxNight;

    [SerializeField] private Color ambientLightColorDay;
    [SerializeField] private Color ambientLightColorNight;


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
        }
        else
        {
            sunRises = true;
            field.text = "Jour";

            SceneManager.LoadScene(0);
        }
    }


}
