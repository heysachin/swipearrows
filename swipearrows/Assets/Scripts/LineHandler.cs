using UnityEngine;
using System.Collections;
public class LineHandler : MonoBehaviour {
    private GameObject lineGO;
    private LineRenderer lineRenderer;
    private int i = 0;
    public static Touch touch;
    public static float pos0;

    

    void Start()
    {
        lineGO = new GameObject("Line");
        lineGO.AddComponent<LineRenderer>();
        lineRenderer = lineGO.GetComponent<LineRenderer>();
        lineRenderer.SetWidth(0.5f, 0.5f);
        lineRenderer.SetVertexCount(0);
    }

    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                pos0 = touch.position.y;
            }
            if (touch.phase == TouchPhase.Moved)
            {
              
                lineRenderer.SetVertexCount(i + 1);
                Vector2 mPosition = new Vector2(touch.position.x, touch.position.y);
                lineRenderer.SetPosition(i, Camera.main.ScreenToWorldPoint(mPosition));
                i++;

                /* Add Collider */

                BoxCollider2D bc = lineGO.AddComponent<BoxCollider2D>();
                bc.transform.position = lineRenderer.transform.position;
                bc.size = new Vector2(0.1f, 0.1f);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                /* Remove Line */
                lineRenderer.SetVertexCount(0);
                i = 0;

                /* Remove Line Colliders */

                BoxCollider2D[] lineColliders = lineGO.GetComponents<BoxCollider2D>();

                foreach (BoxCollider2D b in lineColliders)
              {
                    Destroy(b);
                }
            }
        }
    }
}