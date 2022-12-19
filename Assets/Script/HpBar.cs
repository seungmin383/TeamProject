using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private Camera _mainCamera;
    private Slider _hp;
    private Transform _transform;

    public GameObject textBoxGameObject;
    public float hpMax;

    private void Awake()   
    {
        _mainCamera = Camera.main;
        _hp = transform.GetComponent<Slider>();
        _transform = transform;
        _hp.maxValue = hpMax;
        _hp.value = hpMax;
    }

    public void Damage(float damage)   
    {
        _hp.value -= damage;
        _isHit = true;
        if (_toTalDamage == 0)
        {
            StartCoroutine(DamageText(damage));
        }
    }

    private float _toTalDamage; 
    private Text _text;
    private bool _isHit;
    private float _vecTerY;

    IEnumerator DamageText(float damage) 
    {
        _isHit = false;
        _text = Instantiate(textBoxGameObject, transform.parent.parent.position, Quaternion.identity , _transform).GetComponent<Text>();
        _vecTerY = 1f;
        _toTalDamage += damage;
        _text.text = _toTalDamage.ToString();
        while (_vecTerY < 3f)
        {
            yield return new WaitForSeconds(0.01f);
            _vecTerY += 0.03f;
            _text.transform.position = _mainCamera.WorldToScreenPoint(transform.parent.parent.position + new Vector3(0, _vecTerY, 0));
            if (_isHit)
            {
                _toTalDamage += damage;
                _text.text = _toTalDamage.ToString();
                _vecTerY = 1f;
                _isHit = false;
            }
        }
        _toTalDamage = 0;
        Destroy(_text.gameObject);
        yield return null;
    }

    private void Die()
    {
        Debug.Log(gameObject.name + " is Die");
        Destroy(transform.parent.parent.gameObject);
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Damage(1);
        }

        if (_hp.value <= 0)
        {
            Die();
        }
        
        transform.position = _mainCamera.WorldToScreenPoint(transform.parent.parent.position + new Vector3(0, 1f, 0));
        if (transform.position.z < 0.0f)
        {
            transform.position *= -1.0f;
        }
    }
}
