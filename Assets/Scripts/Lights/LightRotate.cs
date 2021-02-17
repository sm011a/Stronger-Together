using UnityEngine;

public class LightRotate : MonoBehaviour
{
    public float speedRotate = 5f;

    private void FixedUpdate()
    {
        transform.Rotate(0, speedRotate * Time.deltaTime * 1 ,0 );
    }
}
