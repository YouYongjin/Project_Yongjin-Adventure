using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPoint : Item
{
    public int scoreValue;

    private void Awake()
    {
        scoreValue = 1;
    }

    public override void Collect(PlayerController player)
    {
        player.score = player.score + scoreValue;
        Debug.Log($" Collect Score Value: {scoreValue}");
        Destroy(gameObject);
    }
}
