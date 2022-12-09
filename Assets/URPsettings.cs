using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URPsettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GraphicsSettings.renderPipelineAsset != null)
        {
            ((UniversalRenderPipelineAsset)GraphicsSettings.renderPipelineAsset).renderScale = 1.625f;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}