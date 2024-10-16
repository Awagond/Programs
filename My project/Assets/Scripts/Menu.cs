using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool pressPause;
    public RectTransform slider;
    Vector2 v;

    void Start()
    {
        v = slider.anchorMax;
    }

    void Update()
    {
        if (pressPause)
        {
            v.x += 0.01f;
            slider.anchorMax = v;
            if (slider.anchorMax.x >= 0.3f)
            {
                pressPause = false;
            }
        }
    }

    public void Pause()
    {
        pressPause=true;
    }
    
    
}
