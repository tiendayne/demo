using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die(); // Chạy lệnh nổ ở lớp cha
        Debug.Log("Player died");
    }
}