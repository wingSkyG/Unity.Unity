using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DOTweenScript : MonoBehaviour
{
    public Button btnPlayAnim;
    public Button btnPlaySequence;
    public Image image;
    public GameObject sphere;
    
    private Camera _camera;
    private Sequence sq;
    private Tweener tw;
    
    // Start is called before the first frame update
    void Start()
    {
        btnPlayAnim.onClick.AddListener(OnBtnClickPlayAnim);
        btnPlaySequence.onClick.AddListener(OnBtnClickPlaySequence);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBtnClickPlayAnim()
    {
        // _sp.transform.DOScale(2, 3);
        // _sp.transform.DOScale(new Vector3(2, 4, 6), 3);
        // _sp.transform.DOMove(new Vector3(1, 4, 6), 3, false);
        // _camera.DOShakePosition(5);
        // _sp.transform.DOMove(new Vector3(1, 4, 6), 1).SetRelative();
        // var newColor = new Color(image.material.color.r, image.material.color.g, image.material.color.b, 255f);
        // image.DOColor(RandomColor(), 3f).SetEase(Ease.InOutQuad);
        tw ??= sphere.transform.DOMove(new Vector3(1, 4, 6), 1).SetRelative().SetAutoKill(false);
        tw.Restart();
    }
    
    private void OnBtnClickPlaySequence()
    {
        // if (sq == null)
        // {
        //     sq = DOTween.Sequence();
        //     sq.SetAutoKill(false);
        //     sq.Append(sphere.transform.DOScale(2, 1))
        //         .Append(sphere.transform.DOScale(new Vector3(2, 4, 6), 1))
        //         .OnComplete(() =>
        //         {
        //             Debug.Log("all animation finished!");
        //         });
        // }
        //
        // sq.Restart();
        
        if (sq == null)
        {
            sq = DOTween.Sequence();
            sq.SetAutoKill(false);
            sq.OnStart(() =>
                {
                    Debug.Log("animation started!");
                })
                .OnPlay(() =>
                {
                    Debug.Log("animation playing!");
                })
                .OnUpdate(() =>
                {
                    Debug.Log("animation update!");
                })
                .OnComplete(() =>
                {
                    Debug.Log("animation finished!");
                });
        }

        sq.Restart();
    }
    
    private Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }
}
