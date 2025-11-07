using UnityEngine;

[ExecuteAlways] // So it works in Edit mode too (optional)
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in real seconds.")]
    [Range(1f, 86400f)] // Limit range to between 1 second and 1 day
    public float dayDurationInSeconds = 60f;

    [Tooltip("The axis around which the light will rotate (e.g., X for sunrise/sunset).")]
    public Vector3 rotationAxis = Vector3.right;

    private void Update()
    {
        if (dayDurationInSeconds <= 0) return;

        float degreesPerSecond = 360f / dayDurationInSeconds;
        transform.Rotate(rotationAxis, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}
