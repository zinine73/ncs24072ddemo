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
        // C#���� System.Random�� ��������� Unity���� ��� ���
        int iv = Random.Range(1, 46); // iv���� 45������ ���´�
        // �Ǽ��϶��� �ڿ� ���� ���� �ȴٴ� �� ����!!!
        float fv = Random.Range(0.1f, 1.0f); // fv�� 1.0f �� �� �� �ִ�

        // ball reset
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // ball�� transform.position ���� �����ؼ� ball ��ġ�� reset (new Vector(-5,4,0))
            // x��ǥ�� -8.27f ~ 8.2f ���̿��� ��������
            fv = Random.Range(-8.27f, 8.2f);
            MyObj.transform.position = new Vector3(fv, 4f, 0f);

            // �Ź� ���� ������ ballColor�� �ִ� ������  Color�� �ٲ㺸��
            sr.color = ballColor[ballIndex];
            // �ε����� ������� �ѱ�鼭 ballColor ������ ��
            //ballIndex++;
            //if (ballIndex >= ballColor.Length)
            //    ballIndex = 0;
            // �ε����� �������� �����ͺ���
            // 0 <= ballIndex <= 5
            ballIndex = Random.Range(0, 6);
        }
    }
}
