using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDelate : MonoBehaviour
{
    public float targetXCoordinate = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // 현재 오브젝트의 위치를 가져옴
        Vector3 currentPosition = transform.position;

        // x 좌표가 목표값과 같거나 큰 경우
        if (currentPosition.x >= targetXCoordinate)
        {
            // 오브젝트를 삭제
            Destroy(gameObject);
        }
    }
}
