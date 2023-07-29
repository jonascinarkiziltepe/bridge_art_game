using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoteScript : MonoBehaviour
{

    public Rigidbody player_rb; // player rigidbody
    public FirstPersonController player_script; // player script
    public int chaos_rate; // how many seconds before each change
    public int frame_counter = 0; //frame counter
    
    private array chaos_variables = new array(9); // array of variables to change
    chaos_variables[0] = player_script.walkSpeed;
    chaos_variables[1] = player_script.sprintSpeed;
    chaos_variables[2] = player_script.jumpPower;
    chaos_variables[3] = player_script.bobSpeed;
    chaos_variables[4] = player_script.bobAmount;
    chaos_variables[5] = PickUpObject.pushForce;
    chaos_variables[6] = player_rb.mass;
    chaos_variables[7] = player_rb.drag;
    chaos_variables[8] = player_rb.useGravity;

    // Variables to change
    // player_script.walkSpeed 1
    // player_script.sprintSpeed 2
    // player_script.jumpPower 3
    // head bob 4 5
    // push force 6
    // player_rb.mass 7
    // player_rb.drag 8
    // player use gravity

    // Colors camera? 9

/* 
    player_script.walkSpeed = RandomNumber() * 10f;
    player_script.sprintSpeed = RandomNumber() * 20f;
    player_script.jumpPower = RandomNumber() * 10f;
    player_script.bobSpeed = RandomNumber() * 0.5f + 7f;    
    player_script.bobAmount = (RandomNumber() * 0.5f + 7f) * player_script.bobAmount;
    PickUpObject.pushForce = RandomNumber() * 10f;
    player_rb.Gravity = RandomNumber() * 10f;
    player_rb.Mass = RandomNumber() * 10f;
    player_rb.Drag = RandomNumber() * 10f;
    player_rb.useGravity = RandomBoolean();
    

 */

    // a function to give a random number between 0 and 1
    float RandomNumber()
    {
        return Random.Range(0f, 1f);
    }

    // a function to give a random boolean
    bool RandomBoolean()
    {
        return Random.Range(0f, 1f) > 0.5f;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame_counter += 1; // increment frame counter
        
        // if the frame counter is a multiple of 480, then change the player's speed
        if (frame_counter == 60*chaos_rate)
        {
            player_script.walkSpeed = RandomNumber() * 10f;
            player_script.sprintSpeed = RandomNumber() * 20f;
            frame_counter = 0; // reset frame counter
        }
    

        
    }



}
