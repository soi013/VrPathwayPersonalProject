using UnityEngine;

public class FireLantern : MonoBehaviour
{
    [SerializeField]
    private GameObject trailPrefab = null;


    private GameObject currentTrail = null;

    public void StartTrail()
    {
        if (!currentTrail)
        {
            currentTrail = Instantiate(trailPrefab, transform.position, transform.rotation, transform);
        }
    }


    public void EndTrail()
    {
        if (currentTrail)
        {
            currentTrail.transform.parent = null;
            currentTrail = null;
        }
    }
}
