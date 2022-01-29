using UnityEngine;

public class SelectObject : MonoBehaviour
{
    private RaycastHit2D hit;
    [SerializeField]
    private Camera mainCamera;

    private LayerMask Layer;
    int layerMaskOnlyPlayer;
 
    void Awake()
    {
        layerMaskOnlyPlayer = 1 << 6;
    }

    void Update()
    {
        hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, layerMaskOnlyPlayer);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit) 
            {
                gameObject.GetComponent<ListSelectedObject>().AddObj(hit.collider.gameObject);
            }
        }
    }
}
