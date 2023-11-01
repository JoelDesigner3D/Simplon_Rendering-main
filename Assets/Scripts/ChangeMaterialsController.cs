using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialsController : MonoBehaviour
{
    [SerializeField] private Text field;
    [SerializeField] Material[] materials;
    [SerializeField] GameObject ground;
    private int currentMaterialId = 0;

    public void ChangeMaterial()
    {

        if (currentMaterialId < materials.Length)
        {
            currentMaterialId += 1;
        }
        else
        {
            currentMaterialId = 0;
        }

        ground.gameObject.GetComponent<Renderer>().material = materials[currentMaterialId];

        field.text = materials[currentMaterialId].name;

    }
}
