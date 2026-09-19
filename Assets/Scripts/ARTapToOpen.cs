using UnityEngine;

public class ARTapToOpen : MonoBehaviour
{
    public Camera arCamera;
    public float maxDistance = 5f;

    void Update()
    {
        Vector2? tapPos = null;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            tapPos = Input.GetTouch(0).position;
        else if (Input.GetMouseButtonDown(0))
            tapPos = Input.mousePosition;

        if (tapPos.HasValue && arCamera != null)
        {
            Ray ray = arCamera.ScreenPointToRay(tapPos.Value);
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
            {
                ARLinkButton btn = hit.collider.GetComponent<ARLinkButton>();
                if (btn != null && !string.IsNullOrEmpty(btn.url))
                {
                    Application.OpenURL(btn.url);
                }
            }
        }
    }
}