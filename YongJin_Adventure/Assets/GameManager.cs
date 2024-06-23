using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;

    public Transform playerTransform; // Player ĳ������ Transform�� ����.
    public float baseHeight = 0f; //���� ���� ���� ����.

    float playerYPos;
    float resultYPos;

    void Awake()
    {
        playerTransform = playerController.transform;
    }

    void FixedUpdate()
    {
        // Player ĳ������ Y�� ��ġ.
        playerYPos = playerTransform.position.y;

        // ���� ���� ���� ���Ͽ� ���� ��ġ ���.
        resultYPos = playerYPos + baseHeight;

        Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    }
}
