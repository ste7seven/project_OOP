using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPool : MonoBehaviour
{
    public GameObject carPrefab;
    public int poolSize = 10;
    private List<GameObject> carPool;

    void Start()
    {
        carPool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject car = Instantiate(carPrefab);
            car.SetActive(false);
            carPool.Add(car);
        }
    }

    public GameObject GetCar()
    {
        foreach (GameObject car in carPool)
        {
            if (!car.activeInHierarchy)
            {
                car.SetActive(true);
                return car;
            }
        }
        return null;
    }

    public void ReturnCar(GameObject car)
    {
        car.SetActive(false);
    }
}
