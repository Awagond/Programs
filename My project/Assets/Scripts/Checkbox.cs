using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Checkbox : MonoBehaviour
{
    public List<Toggle> toggles = new();
    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    public GameObject Square1;

    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("Square");

    }

    public void All()
    {
        if (toggles[0].isOn)
        {
            foreach (var toggle in toggles)
            {
                toggle.isOn = true;
            }
        }
        else
        {
            foreach (var toggle in toggles)
            {
                toggle.isOn = false;
            }
        }
    }
    public void Square()
    {        
        if (toggles[1] & obj.activeSelf == false)
        {

            obj.SetActive(true);

        }else if (toggles[1] & obj.activeSelf == true)
        {
            obj.SetActive(false);
        }

    }
    public void Transparency(int value)
    {
        if (toggles[1].isOn & value == 0)
        {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 1f);

        }
        if (toggles[1].isOn & value == 1)
        {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.7f);

        }
        if (toggles[1].isOn & value == 2)
        {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.5f);

        }
        if (toggles[1].isOn & value == 3)
        {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.3f);

        }
    }
}
