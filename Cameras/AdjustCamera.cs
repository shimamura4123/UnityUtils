using UnityEngine;

[ExecuteInEditMode]
public class AdjustCameraViewport : MonoBehaviour
{
    [SerializeField] private Vector2 aspectVec2 = new Vector2(16, 9);

    void Update()
    {
        Camera _Camera = GetComponent<Camera>();
        float baseAspect = aspectVec2.x / aspectVec2.y;
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float scale = baseAspect / screenAspect;

        if (scale < 1)
            _Camera.rect = new Rect((1 - scale) / 2, Screen.safeArea.y, scale, 1.0f);
        else
        {
            scale = 1 / scale;
            _Camera.rect = new Rect(0.0f, (1 - scale) / 2, 1.0f, scale);
        }
    }
}

