using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugXR : MonoBehaviour
{
    private static DebugXR instance = null;
    public static DebugXR Instance => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    //=============================================

    [SerializeField] private TextMeshProUGUI field;

    public void Log(string _text)
    {
        field.text = _text;
    }
}
