using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feedBtn : MonoBehaviour
{
    public GameObject foodPrefab;
    public Button feedButton;
    public Transform spawnPoint;
    private GameObject currentFoodInstance;
    public Animator petAnimator;

    // Start is called before the first frame update
    void Start()
    {
            feedButton.onClick.AddListener(TrySpawnFood);
    }

    void TrySpawnFood()
    {
        if (currentFoodInstance == null)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
            currentFoodInstance = Instantiate(foodPrefab, randomPosition, Quaternion.identity);
            petAnimator.SetTrigger("run_forward");
            Debug.Log("Walk trigger set");
        }
    }
}
