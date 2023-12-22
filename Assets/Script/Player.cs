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
    public GameObject skill3Prefab;

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
    private IEnumerator IncreaseSizeOverTime(GameObject skill)
    {
        float duration = 1.5f; // ũ�Ⱑ �����ϴ� �� �ð�
        float elapsedTime = 0f;

        Vector3 initialScale = skill.transform.localScale; // �ʱ� ũ��

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;

            // �ð��� ���� ũ�⸦ ����
            float t = elapsedTime / duration;
            skill.transform.localScale = Vector3.Lerp(initialScale, new Vector3(-2f, 2f, 0), t);

            yield return null;
        }
    }

    public void Create_skill3()
    {
        GameObject skill3 = Instantiate(skill3Prefab, transform.position, Quaternion.identity);

        skill3.GetComponent<Rigidbody2D>().velocity = new Vector2(skill_speed, 0f);
        // �������� ũ�⸦ ���� Ű���ִ� �ڵ�
        StartCoroutine(IncreaseSizeOverTime(skill3));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (life < 1)
        //{
        //    SceneManager.LoadScene("GameOver");
        //}
    }
}
