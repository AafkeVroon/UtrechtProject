using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "PlayerSettings", order = 0)]
public class PlayerSettings : ScriptableObject
{
   [Header("Player Movement Settings")]

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float groundDistance = 0.4f;

    [Space]
    [Header("Player Looking Settings")]

    public float mouseSensitivity = 100f;
}
