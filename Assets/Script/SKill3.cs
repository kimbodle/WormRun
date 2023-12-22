using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKill3 : MonoBehaviour
{
    private float timer = 0f; // Ÿ�̸� ����
    private float destroyDelay = 2f; // �ı������� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy3")
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Ground �±׸� ���� ������Ʈ�� �浹 ���� ��, ����ϵ��� ó��
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // ��� �ð��� ����

        // ���� �ð�(destroyDelay)�� ������ ���� ������Ʈ�� �ı�
        if (timer >= destroyDelay)
        {
            Destroy(gameObject);
        }


    }
}
