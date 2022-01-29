using UnityEngine;

public class CreateObject : MonoBehaviour
{
    private void CreateObjectFunc(string objectPrimitive) {
        GameObject primitive = Instantiate(Resources.Load(objectPrimitive)) as GameObject;
        primitive.transform.SetParent(transform, true);
    }
}
