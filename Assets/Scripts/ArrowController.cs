using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.1f,0);

        if (transform.position.y < -5.0f){
            Destroy(transform);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        float r1 = 1.0f; //プレイヤーの半径 
        float r2 = 0.5f; //矢の半径

        if (d < r1 + r2){
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecleaseHp();
            Destroy(gameObject);
        }
    }
}
