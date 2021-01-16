using UnityEngine;
using System;
using UnityEngine.Events;

public class PlayerGoal : MonoBehaviour
{
    // public GoalEvent OnGoal;

    public UnityEvent OnGoal;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        this.OnGoal.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
