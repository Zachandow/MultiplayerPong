using UnityEngine;
using UnityEngine.Events;

public class NetworkGoalCheck : MonoBehaviour
{
    public NetworkGameManager networkGameManager;  // Reference to the NetworkGameManager

    public enum GoalType { Player1Goal, Player2Goal }
    public GoalType goalType;
    public UnityEvent OnGoalTouch;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BallController>() != null || other.GetComponent<NetworkBall>() != null)
        {
            // Invoke any listeners for goal scoring
            OnGoalTouch.Invoke();

            // Call the NetworkGameManager to update scores
            if (goalType == GoalType.Player1Goal)
            {
                // Player 2 scores
                networkGameManager.PlayerScored(2); // Assuming Player 2 scores
            }
            else if (goalType == GoalType.Player2Goal)
            {
                // Player 1 scores
                networkGameManager.PlayerScored(1); // Assuming Player 1 scores
            }
        }
    }
}
