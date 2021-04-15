using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{

    public TMPro.TextMeshProUGUI TextLevelComplete;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Character character = collider.GetComponent<Character>();

        if (character)
        {
          
            Destroy(gameObject);
            TextLevelComplete.SetText("Level Complete!");

        }
    }
}
