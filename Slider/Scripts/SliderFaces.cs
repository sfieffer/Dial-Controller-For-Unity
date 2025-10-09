using UnityEngine;
using UnityEngine.UI;

public class HandleImageSwitcher : MonoBehaviour
{
    public Slider slider;                  // assign in Inspector
    public Image handleImage;              // the Image component on the handle
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public float threshold1 = 0.2f;        // value to switch at (adjust as needed)
    public float threshold2 = 0.4f;
    public float threshold3 = 0.6f;
    public float threshold4 = 0.8f;
    public float threshold5 = 0.95f;

    void Start()
    {
        if (slider != null)
            slider.onValueChanged.AddListener(OnSliderValueChanged);

        // Initialize image based on starting value
        UpdateHandleImage(slider.value);
    }

    void OnSliderValueChanged(float val)
    {
        UpdateHandleImage(val);
    }

    void UpdateHandleImage(float val)
    {
        if (val < threshold1)
            handleImage.sprite = sprite1;
        else if (val > threshold1 && val < threshold2)
            handleImage.sprite = sprite2;
        else if (val > threshold2 && val < threshold3)
            handleImage.sprite = sprite3;
        else if (val > threshold3 && val < threshold4)
            handleImage.sprite = sprite4;
        else if (val > threshold4 && val < threshold5)
            handleImage.sprite = sprite5;
        else if (val >= threshold5)
            handleImage.sprite = sprite6;
    }
}

