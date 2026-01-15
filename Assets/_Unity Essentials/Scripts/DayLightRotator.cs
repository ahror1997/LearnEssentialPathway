using UnityEngine;

public class DayLightRotator : MonoBehaviour
{
    [Tooltip("How many real-world seconds should one full in-game day take?")]
    public float secondsPerDay = 120f;

    [Tooltip("Axis around which the light rotates (default: X axis).")]
    public Vector3 rotationAxis = Vector3.right;

    void Update()
    {
        if (secondsPerDay <= 0f)
            return;

        // 360 degrees per full day
        float degreesPerSecond = 360f / secondsPerDay;

        transform.Rotate(rotationAxis, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}
