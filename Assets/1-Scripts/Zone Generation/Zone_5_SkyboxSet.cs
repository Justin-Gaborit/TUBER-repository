using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_5_SkyboxSet : MonoBehaviour
{
    public Material Zone_5_Skybox_Material;
    public Color Zone_5_FogColor;
    bool NewColor;

    void Start()
    {
        Zone_5_Skybox_Material = Resources.Load("Zone_5_Skybox") as Material;
        NewColor = ColorUtility.TryParseHtmlString("#FFB95D", out Zone_5_FogColor);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerObject")
        {
            RenderSettings.skybox = Zone_5_Skybox_Material;
            RenderSettings.fogColor = Zone_5_FogColor;
        }
    }
}
