using UnityEngine;

public class Element : MonoBehaviour
{
    public ElementType myType;

    private void OnTriggerEnter(Collider other)
    {
        if (other == null)
        {
            return;
        }

        var otherElement = other.GetComponent<Element>();
        if (null == otherElement)
        {
            return;
        }
        
        var othersType = otherElement.myType;
        
        if (myType.IsStrongAgainst(othersType))
        {
            Destroy(other.gameObject);
        }
    }
}