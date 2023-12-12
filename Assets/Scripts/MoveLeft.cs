using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed;
    private float leftBound;
    private float currentScore;
    private PlayerController playerControllerScript;

    private void Start()
    {
        speed = 30;
        leftBound = -15;
        currentScore = GameManager.score;

    }

    // Update is called once per frame
    private void Update()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        if(!GameManager.gameOver && !GameManager.miniGame)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        SetSpeed();
        
    }

    private void SetSpeed()
    {
        float newScore = GameManager.score;
        if(newScore > currentScore)
        {
            currentScore = newScore;
            StartCoroutine(ChangeSpeed());
        }
    }

    IEnumerator ChangeSpeed()
    {
        speed = 5;
        yield return new WaitForSeconds(9);
        speed = 30;
    }
}
