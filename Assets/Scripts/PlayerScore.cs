using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public void GoalScored()
    {
        score++;
        this.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
