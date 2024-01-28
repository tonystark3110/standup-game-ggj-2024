using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairPlacement : MonoBehaviour
{
    [SerializeField]
    private GameObject chairPrefab;
    [SerializeField]
    private int count = 10;

    private List<Transform> chairs = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        // Initial placement of chairs
        PlaceChairsInSemiCircle();
    }

    // Update is called once per frame
    void Update()
    {
        if (chairs.Count != count)
        {
            // Remove chairs that are not equal to the prefab
            for (int i = chairs.Count - 1; i >= 0; i--)
            {
                if (chairs[i].gameObject != chairPrefab)
                {
                    Destroy(chairs[i].gameObject);
                    chairs.RemoveAt(i);
                }
            }

            // Re-add and position chairs to maintain the count
            PlaceChairsInSemiCircle();
        }
    }

    private void PlaceChairsInSemiCircle()
    {
        // Clear existing chairs list
        chairs.Clear();

        float angleStep = 180.0f / (count - 1); // Divide semi-circle into equal parts
        Vector3 center = chairPrefab.transform.position; // Center of the semi-circle

        for (int i = 0; i < count; i++)
        {
            float angle = angleStep * i;
            Vector3 position = center + Quaternion.Euler(0, angle, 0) * Vector3.forward * 5f; // Change 5f to adjust radius
            GameObject newChair = Instantiate(chairPrefab, position, Quaternion.identity);
            //newChair.transform.parent = chairPrefab.transform.parent;
           // newChair.transform.localPosition = position;
            newChair.transform.LookAt(center); // Make chairs face the center

            chairs.Add(newChair.transform);
        }
    }
}
