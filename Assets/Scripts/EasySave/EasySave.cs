using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EasySave : MonoBehaviour
{
    public GameObject cube;

    private void Awake()
    {
        Debug.Log($"Application.dataPath:{Application.dataPath}"); 
        Debug.Log($"Application.persistentDataPath:{Application.persistentDataPath}"); 
    }

    // Start is called before the first frame update
    void Start()
    {
        // ES3.Save("cube", cube);
        
        // ES3.Save<GameObject>("cube", cube, Application.dataPath+"/Resources/myFile.bytes");
        // AssetDatabase.Refresh();
        
        // ES3.Save<GameObject>("cube", cube, Application.dataPath + "/cube.json");
        
        // ES3.Save<int>("int1", 1, Application.dataPath+"/Resources/EasySave/int.json");
        // ES3.Save<int>("int2", 2, Application.dataPath+"/Resources/EasySave/int.json");
        // ES3.Save<int>("int3", 3, Application.dataPath+"/Resources/EasySave/int.json");
        // var intVal = ES3.Load<int>("int3", Application.dataPath + "/Resources/EasySave/int.json");
        // Debug.Log(intVal);
        
        ES3.Save("cacheData", 123,  new ES3Settings(ES3.Location.Cache));
        var cacheData = ES3.Load<int>("cacheData", new ES3Settings(ES3.Location.Cache));
        Debug.Log(cacheData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
