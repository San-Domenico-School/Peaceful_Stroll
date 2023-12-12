using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/********************************************
 * This will increase or decrease the speed
 * of the player regarding on if the score 
 * increase or decrease. Attached to the component of the player.
 * 
 * Naty Kozelkova
 * December 08, 2023 Version 1.0
 *******************************************/

public class MovementChanger : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;
    private float score;
    

    // Start is called before the first frame update
    void Start()
    {
        score = GameManager.score;
        playerAnimator.SetFloat("Speed_f", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}