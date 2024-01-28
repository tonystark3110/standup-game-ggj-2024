using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairPlacement : MonoBehaviour
{
    private CharacterAnimation player;
    private void Start()
    {
        player = CharacterAnimation.Instance;
        transform.LookAt(new Vector3(player.transform.position.x,transform.position.y,player.transform.position.z));
        transform.Rotate(0, 90, 0);
    }
}
