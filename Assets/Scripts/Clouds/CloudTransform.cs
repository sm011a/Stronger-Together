using UnityEngine;

public class CloudTransform : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float step;
    private float progress;

    private void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, progress);
        progress += step;
    }
}
