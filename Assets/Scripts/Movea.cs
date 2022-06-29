using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movea : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("welcome to the game");
        Debug.Log("Move your play with W A S D");
        Debug.Log("Don't hit the walls!");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}

/* Start Function
 Now, what unity is doing is saying anything that is within start, anything that we write in here,
any statements I will make, those statements happen.
I'll do those statements when this script first comes to life and I'll do them just once.
*/

//Update is something that it says I will do every single frame that this script is alive and within the game.
/*Frame = I'm sure you've played a game and you've seen that it's 30 or 60 fps.
In other words, frames per second a frame is something that is calculating all of the things that need to
go on in your game and make those happen.*/

//transform means we are accessing the transform of this game object. Unity has a built in method which is translate, which basically means move. Translate(x,y,z)
//In the transform.Translate(1,0,0);, we're not saying take it to one zero zero. We're saying add one, add zero, add zero.
