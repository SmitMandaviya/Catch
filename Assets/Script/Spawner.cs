using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public bool gameover=false;

    public void spawner()
    {
        Instantiate(prefab, new Vector3(Random.Range(8, -8), 4.30f, 0f),Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !gameover)
        {
            spawner();
            Destroy(gameObject);
            Logic.instace.Score(1);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            gameover = true;
            Logic.instace.GameOver();
        }
    }
}
