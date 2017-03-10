using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest_Animation : MonoBehaviour {
    public SpriteRenderer lockImage;
    public GameObject chestLight;
    private float alpha;
    public float fade;

    void Awake()
    {

        print("hi?");
        alpha = lockImage.color.a;
    }

    void Update()
    {
        if(lockImage.color.a > 0)
        {
            alpha -= Time.deltaTime;
            lockImage.color = new Color(1, 1, 1, alpha);
        }
    }
}