using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EasySave : MonoBehaviour
{
    public GameObject cube;
    [ES3Serializable] public GameObject sphere;
    
    private string _filePath;
    private string _fileName;
    private ES3Settings _settings;
    // private ClassToSaved _classToSaved = new ClassToSaved();

    private void Awake()
    {
        Debug.Log($"Application.dataPath:{Application.dataPath}"); 
        Debug.Log($"Application.persistentDataPath:{Application.persistentDataPath}");

        _filePath = Application.dataPath + "/Scenes/EasySave/";
    }

    // Start is called before the first frame update
    void Start()
    {
        _fileName = "int_json.json";
        _settings = new ES3Settings(_filePath + _fileName);
        ES3.Save("int1", 1, _settings);
        ES3.Save("int10", 10, _settings);

        _fileName = "gameobject.json";
        _settings = new ES3Settings(_filePath + _fileName);
        ES3.Save("cube", cube, _settings);

        _fileName = "class.json";
        _settings = new ES3Settings(_filePath + _fileName);
        ES3.Save("ClassToSaved", typeof(ClassToSaved), _settings);
        
        _fileName = "class_object.json";
        _settings = new ES3Settings(_filePath + _fileName);
        var classToSaved = new ClassToSaved();
        ES3.Save("ClassToSaved_Object", classToSaved, _settings);
    }
}
