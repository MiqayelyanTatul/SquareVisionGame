using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Color = UnityEngine.Color;
using Image = UnityEngine.UI.Image;
using Random = UnityEngine.Random;

public class TrueCube : MonoBehaviour
{
    [SerializeField] private GameObject _nextLvlPanel;
    [SerializeField] private Animator _cubesAnimator;
    [SerializeField] private GridLayoutGroup _grid;
    [SerializeField] private Image[] _cubesImage;
    private float _rRandomNumber, _gRandomNumber, _bRandomNumber;
    private static readonly int True = Animator.StringToHash("True");
    private static readonly int IsTrue = Animator.StringToHash("isTrue");
    private int _point;
    private bool _permit;
    [SerializeField]private Timer _timer;

    private void Awake()
    {
        _point = 0;
        _permit = true;
    }

    private enum StartCorner
    {
        UpperLeft = 0,
        UpperRight = 1,
        LoverLeft = 2,
        LoverRight = 3
    }
    private enum StartAxis
    {
        Vertical = 0,
        Horizontal = 1,
    }

    public void OnClickTrueCube()
    {
        if (_permit)
        {
            StartCoroutine(IFadeOn());
            Invoke(nameof(CubeColor),1f);
            _point++;
            _timer._timerCount = 20;
        }
    }
    private void CubeColor()
    {
        _rRandomNumber = Random.Range(0f, 1f);
        _gRandomNumber = Random.Range(0f, 1f);
        _bRandomNumber = Random.Range(0f, 1f);
        foreach (var image in _cubesImage)
        {
            image.color = new Color(_rRandomNumber, _gRandomNumber, _bRandomNumber,1);
        }

        _cubesImage[4].color = new Color(_rRandomNumber + 0.07f, _gRandomNumber - 0.07f, _bRandomNumber + 0.07f,1);;
    }

    private IEnumerator IFadeOn()
    {
        _permit = false;
        //////////////////////////////////////////////////
        StartCorner startCorner = StartCorner.UpperLeft;
        int randomIndex = UnityEngine.Random.Range(0, Enum.GetNames(typeof(StartCorner)).Length);
        startCorner = (StartCorner)randomIndex;
        //////////////////////////////////////////////////
        StartAxis startAxis = StartAxis.Vertical;
        int randIndex = UnityEngine.Random.Range(0, Enum.GetNames(typeof(StartAxis)).Length);
        startAxis = (StartAxis)randIndex;
        //////////////////////////////////////////////
        _cubesAnimator.SetBool(IsTrue,true);
        yield return new WaitForSeconds(1f);
        _grid.startCorner = (GridLayoutGroup.Corner)startCorner;
        _grid.startAxis = (GridLayoutGroup.Axis)startAxis;
        _cubesAnimator.SetBool(IsTrue,false);
        _permit = true;
    }

    private void FixedUpdate()
    {
        if (_point == 5)
        {
            Invoke(nameof(NextLvlPanel),1f);
        }
    }

    private void NextLvlPanel()
    {
        _nextLvlPanel.SetActive(true);
    }
    public void OnClickGoToNextLVL()
    {
        Invoke(nameof(NextLvl), 1f);
    }

    private void NextLvl()
    {
        SceneManager.LoadScene(sceneBuildIndex: + 1);
    }
    
}
