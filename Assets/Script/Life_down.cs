using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Life_down : MonoBehaviour
{
    public Image[] lifeImages;

    public void Life_update(int life)
    {
        Debug.Log("��� �ٿ� �Լ� ����");
        if (life > 0)
        {
            lifeImages[life].color = new Color(1, 0, 0, 0.4f);
        }
        else
        {
            lifeImages[0].color = new Color(1, 0, 0, 0.4f);
            //���ߴ� �ڵ�
        }
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
