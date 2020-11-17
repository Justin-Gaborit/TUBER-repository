using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_3_SkyboxSet : MonoBehaviour
{
    public Material Zone_3_Skybox_Material;
    public Color Zone_3_FogColor;
    bool NewColor;

    void Start()
    {
        Zone_3_Skybox_Material = Resources.Load("Zone_3_Skybox") as Material;
        NewColor = ColorUtility.TryParseHtmlString("#00D7B7", out Zone_3_FogColor);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerObject")
        {
            RenderSettings.skybox = Zone_3_Skybox_Material;
            RenderSettings.fogColor = Zone_3_FogColor;
        }
    }
}
