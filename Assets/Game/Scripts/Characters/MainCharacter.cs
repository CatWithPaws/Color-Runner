using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : Character
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sideSpeed;

    [SerializeField] private float maxMovementRange = 2f;

    [SerializeField] private Joystick joystick;

    public static System.Action OnWin;
    public static System.Action OnLoose;

    public static System.Action<int> OnScoreUpdated;

    private Vector3 basePos;
    private Vector3 baseScale;

    private bool isPlaying = false;

    private Rigidbody rb;
    
   

    int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
        private set
        {
            score = value;
            OnScoreUpdated?.Invoke(value);
            if (value < 0)
            {
                OnLoose?.Invoke();
            }

            else if (value < 10)
            {
                transform.localScale = baseScale + baseScale * 0.05f * (value + 1);
            }

            print(value);
        }
    }

    private void Start()
    {
        StartGame.OnGameStart += () => { isPlaying = true; };
        OnLoose += () => { isPlaying = false; };
        OnWin += () => { isPlaying = false; };
        basePos = transform.position;
        baseScale = transform.localScale;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isPlaying) return;
        Vector3 toPos = transform.position + new Vector3(joystick.Horizontal, 0) * Time.deltaTime * sideSpeed;
        toPos.x = Mathf.Clamp(toPos.x, basePos.x - maxMovementRange, basePos.x + maxMovementRange);
        rb.MovePosition(toPos + transform.forward * forwardSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Character character))
        {
            if (character != this)
            {
                if (character.CurrentColor != this.CurrentColor)
                {
                    Score--;
                }
                else
                {
                    Score++;
                }
                Destroy(other.gameObject);
            }
        }

    }
}
