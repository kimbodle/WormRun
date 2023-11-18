using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int life = 3;
    public Life_down Life;

    public GameObject skill1Prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Obstacle")
        {
            life--;
            Life.Life_update(life);
            Debug.Log(life);

        }
    }

    public void Create_skill1()
    {
        // Player 위치에서 공 생성
        GameObject skill1 = Instantiate(skill1Prefab, transform.position, Quaternion.identity);
        // 공에게 속도 부여
        skill1.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
