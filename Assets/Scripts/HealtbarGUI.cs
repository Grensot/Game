using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtbarGUI : MonoBehaviour
{
    [SerializeField] private GUISkin _Skin;

    public Image picture;
    public KeyCode key; 
    public int Helthbarwidth;
    private float BardisapW = Screen.width * 0.1f;
    private float BardisapH = Screen.height * 0.1f;
    private float _slidervalue = 100;
    private float HelthbarWidth;
    void Update()
    {
        HelthbarWidth = _slidervalue * Helthbarwidth;
        if (HelthbarWidth < 0)
        {
            _slidervalue = 0;
        }
        if (_slidervalue == 0)
        {
            BardisapW = Screen.width * -0.1f;
            BardisapH = Screen.height * -0.1f;
        }

        if (Input.GetKeyDown(key))
        {
            _slidervalue -= 20;
        }
    }
    public void OnGUI()
    {
         GUI.skin = _Skin;

         _slidervalue = GUI.HorizontalSlider(new Rect(Screen.width * -0.1f, Screen.height * -0.1f, 0, 0), _slidervalue, 0, 100);
         


        GUI.Box(new Rect(BardisapW, BardisapH, HelthbarWidth, 50), "");

        picture.color = new Color(0, 0, 0, _slidervalue / 255f);
    }
}
