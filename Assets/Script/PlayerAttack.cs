using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        // Cek input serangan (misalnya tombol Attack)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Aktifkan trigger AttackTrigger untuk memulai animasi serangan
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("AttDepan");
    }
}