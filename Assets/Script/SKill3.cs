using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill3 : MonoBehaviour
{
    private float timer = 0f; // 타이머 변수
    private float destroyDelay = 2f; // 파괴까지의 지연 시간
    private float minY = -3.3f; // 오브젝트가 떨어질 수 있는 최소 y 좌표

    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Ground 태그를 가진 오브젝트와 충돌 중일 때, 통과하도록 처리
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 경과 시간을 누적

        // 오브젝트의 y 좌표가 minY 이하로 떨어지지 않도록 조정
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }

        // 일정 시간(destroyDelay)이 지나면 게임 오브젝트를 파괴
        if (timer >= destroyDelay)
        {
            Destroy(gameObject);
        }


    }
}
