using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderSwap : MonoBehaviour
{
    void ShaderSwap()
    {
        Material[] materials = GameObject.FindObjectsOfType<Material>();
        foreach (Material material in materials)
        {
            if (material.shader.name == "Yax/PropertiesShader")
            {
                material.shader = Shader.Find("JS Games/Dragon Bumped Spec");
            }
        }
    }
}
