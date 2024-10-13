using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenu : MonoBehaviour
{
    public GameObject MenuButton;

    private float _optionHeight = 0.7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenContextMenu(Vector3 position, int buttonAmount)
    {
        this.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, buttonAmount * _optionHeight);
        for (int i = 0; i > buttonAmount; i++)
        {
            Instantiate(MenuButton, position, this.transform.rotation, this.transform);
        }
    }
}
