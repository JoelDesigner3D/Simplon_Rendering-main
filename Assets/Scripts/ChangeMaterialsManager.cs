using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialsManager : MonoBehaviour
{
    [SerializeField] Material[] materials;
    [SerializeField] GameObject ground;
    private int currentMaterialId = 0;

    public void ChangeMaterial()
    {

        if (currentMaterialId < materials.Length)
        {
            currentMaterialId += 1;
            ground.gameObject.GetComponent<Renderer>().material = materials[currentMaterialId];
        }

    }
}
