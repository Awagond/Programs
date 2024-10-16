using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownMenu : MonoBehaviour
{
    GameObject obj;

    public void Start() {

        obj = GameObject.Find("Square");

    }

    public void InputMenu(int value) {

        if (value == 0) { 

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 1f);

        }
        if (value == 1) {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.7f);

        }
        if (value == 2) {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.5f);

        }
        if (value == 3)
        {

            obj.GetComponent<SpriteRenderer>().color = new Color(255f, 0, 0, 0.3f);

        }

    }
}
