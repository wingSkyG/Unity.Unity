using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private Button _smallButton;
    [SerializeField] private Button _middleButton;
    [SerializeField] private Button _largeButton;
        
    
    // Start is called before the first frame update
    void Start()
    {
        _smallButton.onClick.AddListener(OnSmallButtonClicked);
        _middleButton.onClick.AddListener(OnMiddleButtonClicked);
        _largeButton.onClick.AddListener(OnLargeButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnLargeButtonClicked()
    {
        Debug.Log("OnLargeButtonClicked");
    }

    private void OnMiddleButtonClicked()
    {
        Debug.Log("OnMiddleButtonClicked");
    }
    
    private void OnSmallButtonClicked()
    {
        Debug.Log("OnSmallButtonClicked");
    }
}
