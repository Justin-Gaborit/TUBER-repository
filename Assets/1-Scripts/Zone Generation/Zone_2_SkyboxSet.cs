using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_2_SkyboxSet : MonoBehaviour
{
    public Material Zone_2_Skybox_Material;
    public Color Zone_2_FogColor;
    bool NewColor;

    void Start()
    {
        Zone_2_Skybox_Material = Resources.Load("Zone_2_Skybox") as Material;
        NewColor = ColorUtility.TryParseHtmlString("#FFBA2D", out Zone_2_FogColor);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerObject")
        {
            RenderSettings.skybox = Zone_2_Skybox_Material;
            RenderSettings.fogColor = Zone_2_FogColor;
        }
    }
}
