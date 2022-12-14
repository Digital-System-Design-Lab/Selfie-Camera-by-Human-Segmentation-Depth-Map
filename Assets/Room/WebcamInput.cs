using UnityEngine;

namespace Cam {

public sealed class WebcamInput : MonoBehaviour
{
    #region Editable attributes

    [SerializeField] string _deviceName = "";

    #endregion

    #region Internal objects

    WebCamTexture _webcam;
    RenderTexture _buffer;

    #endregion

    #region Public properties

    public Texture Texture => _buffer;

    #endregion

    #region MonoBehaviour implementation

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        _webcam = new WebCamTexture(devices[3].name);
        _buffer = new RenderTexture(1920, 1080, 0);
        _webcam.Play();
    }

    void OnDestroy()
    {
        Destroy(_webcam);
        Destroy(_buffer);
    }

    void Update()
    {
        if (!_webcam.didUpdateThisFrame) return;
        var vflip = _webcam.videoVerticallyMirrored;
        var scale = new Vector2(-1 ,1 ); // 1 ,1                1 ,-1
        var offset = new Vector2(1 ,0); // 0 ,0 위아래x 반전이 됨  0, 1    위아래o 좌우 o
        Graphics.Blit(_webcam, _buffer, scale, offset);
    }

    #endregion
}

} // namespace Cam
