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
        // C#에선 System.Random을 사용했지만 Unity에선 요걸 사용
        int iv = Random.Range(1, 46); // iv에는 45까지만 들어온다
        // 실수일때만 뒤에 값이 포함 된다는 것 주의!!!
        float fv = Random.Range(0.1f, 1.0f); // fv에 1.0f 가 올 수 있다

        // ball reset
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // ball의 transform.position 값을 변경해서 ball 위치를 reset (new Vector(-5,4,0))
            // x좌표는 -8.27f ~ 8.2f 사이에서 랜덤으로
            fv = Random.Range(-8.27f, 8.2f);
            MyObj.transform.position = new Vector3(fv, 4f, 0f);

            // 매번 누를 때마다 ballColor에 있는 값으로  Color도 바꿔보자
            sr.color = ballColor[ballIndex];
            // 인덱스를 순서대로 넘기면서 ballColor 가져올 때
            //ballIndex++;
            //if (ballIndex >= ballColor.Length)
            //    ballIndex = 0;
            // 인덱스를 랜덤으로 가져와보자
            // 0 <= ballIndex <= 5
            ballIndex = Random.Range(0, 6);
        }
    }
}
