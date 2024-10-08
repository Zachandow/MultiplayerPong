using UnityEngine;
using UnityEngine.Events;

public class GoalTrigger : MonoBehaviour
{
    public GameManager gameManager;  // Reference to the GameManager

    public enum GoalType { Player1Goal, Player2Goal }
    public GoalType goalType;
    public UnityEvent OnGoalTouch;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BallController>() != null || other.GetComponent<NetworkBall>() != null)
        {

            OnGoalTouch.Invoke();
            if (goalType == GoalType.Player1Goal)
            {
                // Player 2 scores
                gameManager.PlayerScorePoint(false);
            }
            else if (goalType == GoalType.Player2Goal)
            {
                // Player 1 scores
                gameManager.PlayerScorePoint(true);
            }
        }
    }
}


