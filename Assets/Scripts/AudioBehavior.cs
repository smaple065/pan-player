using UnityEngine;
using UnityEngine.UI;

public class AudioBehavior : MonoBehaviour
{
    AudioSource audio;
    public Button[] buttons;

    private void Start()
    {
        foreach (var btn in buttons)
        {
            btn.onClick.AddListener(delegate{PlaySound(btn);});
        }
    }

    private void OnDestroy()
    {
        foreach (var btn in buttons)
        {
            btn.onClick.RemoveListener(delegate{PlaySound(btn);});
        }
    }

    public void PlaySound(Button note)
    {
        audio = note.GetComponent<AudioSource>();
        audio.Play(0);
    }
}
