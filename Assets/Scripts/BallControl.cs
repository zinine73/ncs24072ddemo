using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField]
    private GameObject MyObj = null;
    
    Color[] ballColor = new Color[6] {Color.red, Color.magenta, Color.yellow, Color.green, Color.blue, Color.gray};

    SpriteRenderer sr;
    int ballIndex;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ballIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // ball reset
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // ball의 transform.position 값을 변경해서 ball 위치를 reset (new Vector(-5,4,0))
            MyObj.transform.position = new Vector3(-5.0f, 4f, 0f);

            // 매번 누를 때마다 ballColor에 있는 값으로  Color도 바꿔보자
            sr.color = ballColor[ballIndex];
            ballIndex++;
            if (ballIndex >= ballColor.Length)
                ballIndex = 0;

        }
    }
}
