using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        FindObjectOfType<GameSession>().ResetLives();
    }
}
