using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonClick : MonoBehaviour
{
    [Header("Change Scale")]
    public Vector3 targetScale;
    public Color targetColor;
    public float targetOpacity;
    //
    Vector3 originalScale;
    Color originalColor;
    MeshRenderer meshRenderer;
    //
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;
        originalScale = transform.localScale;
    }
    public void _ButtonClicked() 
    {
        transform.DOScale(targetScale, targetOpacity).OnComplete(() =>
        {
            transform.DOScale(originalScale, targetOpacity);
        });
        meshRenderer.material.DOColor(targetColor, targetOpacity).OnComplete(() =>
        {
            meshRenderer.material.DOColor(originalColor, targetOpacity);
        });
    }
}
