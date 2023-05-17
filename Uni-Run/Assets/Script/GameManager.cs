using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
// 씬에는 단 하나의 게임 매니저만 존재할 수 있음
public class GameManager : MonoBehaviour {
    public static GameManager instance; // 싱글턴을 할당할 전역 변수

    public bool isGameover = false; // 게임오버 상태
    public TextAlignment scoreText; // 점수를 출력할 UI 텍스트
    public GameObject gameoverUI; //게임오버 시 활성화할 UI 게임 오브젝트 

    private int score = 0; // 게임 점수

    // 게임 시작과 동시에 싱글턴을 구성
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
