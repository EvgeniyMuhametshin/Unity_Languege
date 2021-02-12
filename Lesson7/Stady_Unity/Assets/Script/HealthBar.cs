using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float _maxValue = 100;
    public Color _color = Color.red;
    public int _width = 4;
    public Slider _slider;
    public bool _isRight;

    private static float _current;

    // Start is called before the first frame update
    void Start()
    {
        _slider.fillRect.GetComponent<Image>().color = _color;

        _slider.maxValue = _maxValue;
        _slider.minValue = 0;
        _current = _maxValue;

        UpdateUI();
    }

    public static float currentValue
    {
        get { return _current; }
    }

    // Update is called once per frame
    void Update()
    {
        if (_current < 0) _current = 0;
        if (_current > _maxValue) _current = _maxValue;
        _slider.value = _current;
    }

    void UpdateUI()
    {
        RectTransform _rect = _slider.GetComponent<RectTransform>();

        int _rectDeltaX = Screen.width / _width;
        float _rectPosX = 0;

        if (_isRight)
        {
            _rectPosX = _rect.position.x - (_rectDeltaX - _rect.sizeDelta.x) / 2;
            _slider.direction = Slider.Direction.RightToLeft;
        }
        else
        {
            _rectPosX = _rect.position.x + (_rectDeltaX - _rect.sizeDelta.x) / 2;
            _slider.direction = Slider.Direction.LeftToRight;
        }

        _rect.sizeDelta = new Vector2(_rectDeltaX, _rect.sizeDelta.y);
        _rect.position = new Vector3(_rectPosX, _rect.position.y, _rect.position.z);
    }

    public static void AdjustCurrentValue(float adjust)
    {
        _current += adjust;
    }

    //HealthBar.AdjustCurrentValue(10); ----//----//----//(-10); Добавить здоровье; убрать здоровье;
}
