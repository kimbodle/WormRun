using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill3 : MonoBehaviour
{
    private float timer = 0f; // Ÿ�̸� ����
    private float destroyDelay = 2f; // �ı������� ���� �ð�

    /*private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Ground �±׸� ���� ������Ʈ�� �浹 ���� ��, ����ϵ��� ó��
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }*/
  
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
