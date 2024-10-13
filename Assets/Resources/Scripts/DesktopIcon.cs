using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesktopIcon : MonoBehaviour
{
    public GameObject Program;
    public float DoubleClickSpeed = 0.25f;

    //private bool _doubleClick = false;  
    private float _doubleClickDeltaT = 0.25f;  
    private GameObject _desktop;

    // Start is called before the first frame update
    void Start()
    {
        _desktop = GameObject.Find("DesktopArea");
        Debug.Log(_desktop);
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(TaskOnClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_doubleClickDeltaT < DoubleClickSpeed)
        {
            _doubleClickDeltaT += Time.deltaTime;
        }
    }

    void TaskOnClick()
    {
        if (_doubleClickDeltaT < DoubleClickSpeed)
        {
            if (_desktop != null)
            {
                _desktop.GetComponent<DesktopPrograms>().StartProgram(Program);
                Debug.Log(Program);
            }
        }
        _doubleClickDeltaT = 0.0f;
    }

}
