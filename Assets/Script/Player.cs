using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int life = 3;
    public Life_down Life;
    public int skill_speed = 10;

    public GameObject skill1Prefab;
    public GameObject skill2Prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Enemy2")
        {
            life--;
            Life.Life_update(life);
            Debug.Log(life);

        }
    }

    public void Create_skill1()
    {
        // Player ��ġ���� �� ����
        GameObject skill1 = Instantiate(skill1Prefab, transform.position, Quaternion.identity);
        // ������ �ӵ� �ο�
        skill1.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0f);
    }

    public void Create_skill2()
    {
        // Player ��ġ���� ����
        GameObject skill2 = Instantiate(skill2Prefab, transform.position, Quaternion.identity);
        // ������ �ӵ� �ο�
        skill2.GetComponent<Rigidbody2D>().velocity = new Vector2(skill_speed, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
