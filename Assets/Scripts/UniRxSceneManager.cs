using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UniRxSceneManager : MonoBehaviour
{
    ReactiveProperty<int> _count = new ReactiveProperty<int>(5);

    // Start is called before the first frame update
    void Start()
    {
        _count.Subscribe((count) =>
        {
            Debug.Log(count);
        });
    }

    // Update is called once per frame
    void Update()
    {
        _count.Value++;
        
    }
}
