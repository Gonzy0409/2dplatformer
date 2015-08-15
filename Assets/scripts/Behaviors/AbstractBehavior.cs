﻿using UnityEngine;
using System.Collections;

public abstract class AbstractBehavior : MonoBehaviour {
    public Buttons[] inputButtons;
    public MonoBehaviour[] disableScripts;

    protected InputState inputState;
    protected Rigidbody2D body2d;
    protected CollisionState collisionState;

    protected virtual void Awake() {
        inputState = GetComponent<InputState>();
        body2d = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>();
    }

    protected virtual void ToggleScripts(bool value) {
        foreach (var scripts in disableScripts) {
            scripts.enabled = value;
        }
    }
}
  