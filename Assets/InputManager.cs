using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //get a referance to the player movement script
    public PlayerMovement player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //call movement every frame and send it axis data
        player.MoveHorizontal(Input.GetAxis("Horizontal"));
        player.MoveVertical(Input.GetAxis("Vertical"));
    }
}
