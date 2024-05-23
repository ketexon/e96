using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace W3AntiAliasingDemo
{
    public class RenderTextures : MonoBehaviour
    {
        [SerializeField] new Camera camera;
        [SerializeField] int size = 128;
        [SerializeField] RawImage rawImage;

        RenderTexture rt;

        void Start()
        {
            rt = new(size, size, 32);
            rt.Create();
            rawImage.texture = rt;
            camera.targetTexture = rt;
        }

        public void UpdateSize(float newSize)
        {
            size = (int)newSize;
            rt.Release();
            rt = new(size, size, 32);
            camera.targetTexture = rt;
            rawImage.texture = rt;
        }
    }
}
