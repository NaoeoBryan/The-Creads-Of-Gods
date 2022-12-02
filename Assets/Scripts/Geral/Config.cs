using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    public bool ifFullscreen;
    public int resolutionIndex;
    public int qualityTexture;
    public float musicVolume;

    // Objetos
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown qualityTextureDropdown;
    public Slider musicVolumeSlide;

    public Resolution[] resolutions;

    // Fun��o
    private void OnEnable()
    {
        resolutions = Screen.resolutions;
        foreach (Resolution reso in resolutions)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(reso.ToString()));
        }

        // Chamado das fun��es
        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        qualityTextureDropdown.onValueChanged.AddListener(delegate { OnTextureQualityChange(); });
        musicVolumeSlide.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });
    }

    // Start is called before the first frame update
    // Resolu��o de tela
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Se a tela est� cheia ou n�o
    public void OnFullScreenToggle() {
        Screen.fullScreen = fullscreenToggle.isOn;
        OnResolutionChange();
    }
    // Se a fun��o foi modificada resolu��o
    public void OnResolutionChange() {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, fullscreenToggle.isOn);
    }
    // Se a qualidade foi modificada
    public void OnTextureQualityChange() {
        QualitySettings.SetQualityLevel(qualityTextureDropdown.value);
    }

    public void OnMusicVolumeChange() { 
    
    }
}
