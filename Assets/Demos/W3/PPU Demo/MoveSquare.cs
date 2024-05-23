using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace W3PPUDemo
{
    public class MoveSquare : MonoBehaviour
    {
        [SerializeField] float pixelsPerUnit = 32;
        [SerializeField] TMPro.TMP_Text text;

        int nextMoveDir = 1;

        float lastXAxis = 0;
        float lastYAxis = 0 ;

        void Start()
        {
            UpdatePPU();
        }

        void UpdatePPU()
        {
            var importer = (TextureImporter)AssetImporter.GetAtPath("Assets/Demos/W3/PPU Demo/White Square.png");

            importer.isReadable = true;

            TextureImporterSettings importerSettings = new();
            importer.ReadTextureSettings(importerSettings);
            importerSettings.spritePixelsPerUnit = pixelsPerUnit;
            importer.SetTextureSettings(importerSettings);

            EditorUtility.SetDirty(importer);
            importer.SaveAndReimport();

            text.text = $"PPU: {(int)pixelsPerUnit}";
        }

        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                transform.position += new Vector3(0, nextMoveDir, 0);
                nextMoveDir *= -1;
            }

            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            if(x != lastXAxis)
            {
                lastXAxis = x;
                if(x > 0)
                {
                    pixelsPerUnit *= 2;
                    pixelsPerUnit = Mathf.Min(256, pixelsPerUnit);
                    UpdatePPU();
                }
                else if(x < 0)
                {
                    pixelsPerUnit /= 2;
                    pixelsPerUnit = Mathf.Max(1, pixelsPerUnit);
                    UpdatePPU();
                }
            }
        }
    }
}
