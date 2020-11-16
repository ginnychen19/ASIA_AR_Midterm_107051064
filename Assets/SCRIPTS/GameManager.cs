using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Arisa")]
    public Transform Arisa;
    [Header("Kisorachan")]
    public Transform Kisorachan;
    [Header("虛擬搖桿")]
    public FixedJoystick  Joystick;
    [Header("旋轉速度"), Range(0.1f, 10f)]
    public float Turn = 1.5f;
    [Header("縮放"), Range(0.1f, 1f)]
    public float Size = 0f;
    [Header("Arisa動畫元件")]
    public Animator aniArisa;
    [Header("Kisorachan動畫元件")]
    public Animator aniKisorachan;

    private void Start()
    {
        print("遊戲開始事件");
    }
    private void Update()
    {
        Arisa.Rotate(0, Joystick.Horizontal * Turn, 0);
        Kisorachan.Rotate(0, Joystick.Horizontal * Turn, 0);
        Arisa.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        Arisa.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Arisa.localScale.x, 0.5f, 2f);
        Kisorachan.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        Kisorachan.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Kisorachan.localScale.x, 0.5f, 2f);

    }
    public void PlayAnimation(string aniname)
    {
        print(aniname);
        aniArisa.SetTrigger(aniname);
        aniKisorachan.SetTrigger(aniname);
    }
}
