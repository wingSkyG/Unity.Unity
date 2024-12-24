using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public new GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        var name = gameObject.transform.GetChild(0).name;
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
