using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� ���� �Ŵ���
// ������ �� �ϳ��� ���� �Ŵ����� ������ �� ����
public class GameManager : MonoBehaviour {
    public static GameManager instance; // �̱����� �Ҵ��� ���� ����

    public bool isGameover = false; // ���ӿ��� ����
    public TextAlignment scoreText; // ������ ����� UI �ؽ�Ʈ
    public GameObject gameoverUI; //���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ 

    private int score = 0; // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    void Awake() {
        // ��Ū�� ���� Instance�� ��� �ִ°�?
        if (instance == null)
        {
            // instance�� ��� �ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            //nstance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���

            // Update is called once per frame
            void Update()
    {
        
    }
}
