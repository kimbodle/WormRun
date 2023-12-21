using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delate : MonoBehaviour
{
    public int delate_timer = 19;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delate_timer); // 생성된 프리팹을 간격 시간 후에 제거
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
