using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_4_SkyboxSet : MonoBehaviour
{
    public Material Zone_4_Skybox_Material;
    public Color Zone_4_FogColor;
    bool NewColor;

    void Start()
    {
        Zone_4_Skybox_Material = Resources.Load("Zone_4_Skybox") as Material;
        NewColor = ColorUtility.TryParseHtmlString("#35a400", out Zone_4_FogColor);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerObject")
        {
            RenderSettings.skybox = Zone_4_Skybox_Material;
            RenderSettings.fogColor = Zone_4_FogColor;
        }
    }
}
