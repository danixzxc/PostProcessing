using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class EffectSettings : MonoBehaviour
{

    [SerializeField]
    private Button _noirePostProcessButton;
    
    [SerializeField]
    private Button _warmPostProcessButton;
    
    [SerializeField]
    private Button _coldPostProcessButton;
    
    [SerializeField]
    private Button _drunkPostProcessButton;

    [SerializeField]
    private PostProcessProfile _noirePostProcessProfile;

    [SerializeField]
    private PostProcessProfile _warmPostProcessProfile;

    [SerializeField]
    private PostProcessProfile _coldPostProcessProfile;

    [SerializeField]
    private PostProcessProfile _drunkPostProcessProfile;


    [SerializeField]
    private PostProcessVolume _postProcessVolume;

    [SerializeField]
    private GameObject _camera;


    private void Start()
    {


        AddListeners();
    }
    private void AddListeners()
    {
        _noirePostProcessButton.onClick.AddListener(() => ChangeSettings(_noirePostProcessProfile));
        _warmPostProcessButton.onClick.AddListener(() => ChangeSettings(_warmPostProcessProfile));
        _coldPostProcessButton.onClick.AddListener(() => ChangeSettings(_coldPostProcessProfile));
        _drunkPostProcessButton.onClick.AddListener(() => ChangeSettings(_drunkPostProcessProfile));
    }

    private void OnDestroy()
    {
        _noirePostProcessButton.onClick.RemoveAllListeners();
        _warmPostProcessButton.onClick.RemoveAllListeners();
        _coldPostProcessButton.onClick.RemoveAllListeners();
        _drunkPostProcessButton.onClick.RemoveAllListeners();
    }
    private void ChangeSettings(PostProcessProfile profile)
    {
        _postProcessVolume.profile = profile;
    }

}
