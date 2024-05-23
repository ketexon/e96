using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace W3AntiAliasingDemo
{
    public class UI : MonoBehaviour
    {
        [SerializeField] TMPro.TMP_Text text;
        [SerializeField] Slider slider;

        public void UpdateScreenSizeLabel(float size)
        {
            text.text = ((int)size).ToString();
        }

        void Update()
        {
            slider.maxValue = Math.Max(slider.maxValue, Math.Min(Screen.width, Screen.height));
        }
    }
}
