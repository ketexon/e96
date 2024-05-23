using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace W5UIDemo
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] Canvas canvas;
        [SerializeField] GameObject firstSelected;

        public void OnPause(InputValue value)
        {
            canvas.enabled = true;

            EventSystem.current.SetSelectedGameObject(firstSelected);
        }
    }
}
