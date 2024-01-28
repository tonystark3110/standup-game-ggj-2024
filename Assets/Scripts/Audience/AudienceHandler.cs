using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceHandler : MonoBehaviour
{
    private static List<AudienceHandler> instances = new List<AudienceHandler>();

    private void Start()
    {
        instances.Add(this);
    }

    protected void ToggleLook()
    {
        this.transform.localScale = new Vector3(-this.transform.localScale.x,this.transform.localScale.y,this.transform.localScale.z);
    }

    public static void AudienceToggleLook()
    {
        foreach(AudienceHandler handler in instances)
        {
            handler.ToggleLook();
        }
    }
    

}
