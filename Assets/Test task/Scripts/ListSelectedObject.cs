using UnityEngine;

public class ListSelectedObject : MonoBehaviour
{
    public GameObject selectedCube;
    public GameObject selectedCircle;

    public void AddObj(GameObject obj) 
    {
        if (obj.CompareTag("Cube")) 
        {
            selectedCube = obj;
        } 
        else if (obj.CompareTag("Circle")) 
        {
            selectedCircle = obj;
        }
        if (selectedCube != null && selectedCircle != null)
        {
            CheckSize();           
        }
    }

    private void CheckSize() 
    {
        int sizeCube = selectedCube.gameObject.GetComponent<ObjectSizeSetting>()._objSize;
        int sizeCircle = selectedCircle.gameObject.GetComponent<ObjectSizeSetting>()._objSize;
        Debug.Log(sizeCube);
        Debug.Log(sizeCircle);
        if (sizeCircle > sizeCube) 
        {
            selectedCube.transform.position = selectedCircle.transform.position;
            selectedCube.layer = LayerMask.NameToLayer ("Ignore Raycast");
            selectedCircle.layer = LayerMask.NameToLayer ("Ignore Raycast");
            ClearObjects();
        }
        else if (sizeCircle < sizeCube)
        {
            ClearObjects();
        }
    }

    private void ClearObjects() 
    {
        selectedCube = null;
        selectedCircle = null;
    }
}
