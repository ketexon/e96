using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace W5UIDemo
{
    public class ButtonManager : MonoBehaviour
    {
        void Start()
        {
            var buttons = FindObjectsOfType<Button>();
            foreach(var button in buttons)
            {
                button.onClick.AddListener(() => OnButtonClick(button));
            }
        }

        public void OnButtonClick(Button button)
        {
            button.GetComponentInChildren<TMPro.TMP_Text>().text = "CLICKED";
        }
    }
}
