using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopPrograms : MonoBehaviour
{
    private GameObject _lastWindow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartProgram(GameObject program)
    {
        Vector3 position;
        Vector2 size;
        Vector2 desktopSize = this.GetComponent<RectTransform>().rect.size * this.transform.lossyScale;
        if (_lastWindow != null)
        {
            RectTransform windowRectTrans = _lastWindow.GetComponent<RectTransform>();
            size = windowRectTrans.rect.size * windowRectTrans.lossyScale;
            position = windowRectTrans.position - new Vector3(-0.35f, 0.35f, 0)*windowRectTrans.lossyScale.magnitude;
            if (position.y > (size.y / 2 + 0.35*windowRectTrans.lossyScale.magnitude) & (position.x + size.x / 2) < desktopSize.x)
            {
                _lastWindow = Instantiate(program, position, windowRectTrans.rotation, this.transform);
            }
            else 
            { 
                _lastWindow = Instantiate(program,new Vector2(0 + size.x/2, desktopSize.y - size.y /2), windowRectTrans.rotation, this.transform); 
            }    
        }
        else
        {
            _lastWindow = Instantiate(program, this.transform);
        }
    }
}
