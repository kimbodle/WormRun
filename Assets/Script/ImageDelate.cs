using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 컴포넌트를 사용하기 위한 네임스페이스 추가

public class ImageDelate : MonoBehaviour
{
    private float timer = 0;
    public float DelateTime = 10f;
    public Image image; // 투명도를 조절할 이미지

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>(); // 이미지 컴포넌트 가져오기
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer <= DelateTime)
        {
            Color c = image.color;
            c.a = 1 - (timer / DelateTime - 0.3f); // 투명도를 서서히 줄임
            image.color = c;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
