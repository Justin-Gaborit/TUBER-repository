using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_1_SkyboxSet : MonoBehaviour
{
    public Material Zone_1_Skybox_Material;
    public Color Zone_1_FogColor;
    bool NewColor;

    void Start()
    {
        Zone_1_Skybox_Material = Resources.Load("Zone_1_Skybox") as Material;
        NewColor = ColorUtility.TryParseHtmlString("#8CE5FF", out Zone_1_FogColor);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerObject")
        {
            RenderSettings.skybox = Zone_1_Skybox_Material;
            RenderSettings.fogColor = Zone_1_FogColor;
        }
    }
}
