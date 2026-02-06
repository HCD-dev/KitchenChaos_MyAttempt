using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Anim : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    [SerializeField] private Player player; // Player script'ine referans
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator bileþeni bulunamadý!");
        }
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogError("Player referansý atanmadý!");
            return;
        }

        if (animator == null)
        {
            return; // Animator yoksa devam etmeyin
        }

        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}

