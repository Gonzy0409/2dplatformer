using UnityEngine;
using System.Collections;

public enum Buttons {
    Right,
    Left,
    Up,
    Down,
    A,
    B
}

public enum Condition {
    GreaterThan,
    LessThan
}

[System.Serializable]
public class InputAxisState {
    public string axisName;
    public float offValue;
    public Buttons button;
    public Condition Condition;

    public bool value {
        get {
            var val = Input.GetAxis(axisName);

            switch (Condition) {
                case Condition.GreaterThan:
                    return val > offValue;
                case Condition.LessThan:
                    return val < offValue;
            }

            return false;
        }
    }
}

public class InputManager : MonoBehaviour {
    public InputAxisState[] inputs;
    public InputState inputState;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        foreach (var input in inputs) {
            inputState.setButtonValue(input.button, input.value);
        }
    }
}

