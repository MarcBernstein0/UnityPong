using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    void OnCollisionEnter2D(Collision2D collision)
    {

        // Make sure it was the ball that collided
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null){
            BaseEventData eventData = new(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
