using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class food : MonoBehaviour
{
    [SerializeField] GameObject Food;
    CircleCollider2D collision1;
    int x;
    int y;
    Vector3 position;
    private void Start()
    {
        Food.AddComponent<CircleCollider2D>();
        collision1 = GetComponent<CircleCollider2D>();
        collision1.enabled = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
        {
            x = Random.Range(-9, 9);
            y = Random.Range(-5, 5);
            position = new Vector3(x, y, 0);
            if ( collision.gameObject.tag == "Finish")
            {
                Destroy(Food);
                Movement.count++;
            Debug.Log("Collision happened");
                Instantiate(Food, position, transform.rotation);

        }


    }
}
