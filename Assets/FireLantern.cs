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

            TrailRenderer trailRenderer = currentTrail.GetComponent<TrailRenderer>();
            //trailRenderer.startColor = Color.red;
            //trailRenderer.endColor = Color.red;
            //trailRenderer.time = 5000;
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
