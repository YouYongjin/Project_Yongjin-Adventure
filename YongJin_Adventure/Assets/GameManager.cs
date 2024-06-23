using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;

    public Transform playerTransform; // Player 캐릭터의 Transform을 참조.
    public float baseHeight = 0f; //기준 높이 값을 저장.

    float playerYPos;
    float resultYPos;

    void Awake()
    {
        playerTransform = playerController.transform;
    }

    void FixedUpdate()
    {
        // Player 캐릭터의 Y축 위치.
        playerYPos = playerTransform.position.y;

        // 기준 높이 값을 더하여 최종 위치 계산.
        resultYPos = playerYPos + baseHeight;

        Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    }
}
