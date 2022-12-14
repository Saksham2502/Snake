using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float speed;
    Rigidbody2D rb;
    public static int count;
    public static int highscore;
    float maxTime = 3f;
    float currTime = 0f;
    void Start()
    {
        Debug.Log($"Position of player is{player.transform.position}");
        count = 0;
        highscore = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player") {
        
            
                Debug.Log(Movement.highscore);
                SceneManager.LoadScene("GameOver");
            
        }
    }

    void Update()
    {
        if (count > highscore)
        {
            highscore = count;
            
        }
        if(currTime > maxTime)
        {
            currTime = 0f;
            
        }
        else
        {
            currTime += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W is present");
            transform.position += new Vector3(0, speed*Time.deltaTime, 0);

        }

        else if (Input.GetKey(KeyCode.S)){
            Debug.Log("S is present");
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D is present");
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is present");
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
