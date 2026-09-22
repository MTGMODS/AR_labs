using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    public Color collisionColor = Color.magenta;

    private Material objectMaterial;

    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
    }

    void OnCollisionEnter(Collision collision)
    {
        objectMaterial.color = collisionColor;
    }

    void OnDestroy()
    {
        if (objectMaterial != null)
        {
            Destroy(objectMaterial);
        }
    }
}