using UnityEngine;
using Cam;

public class Background : MonoBehaviour{
    [SerializeField] private Compositor compositor;
    [SerializeField] private Camera backgroundCamera;
    
    private Texture2D background;

    private void Start(){
        //Resources 폴더에서 background 이미지 로드
        //var sprite = Resources.Load<Sprite>("background"); 

        compositor.Background = toTexture2D(backgroundCamera.targetTexture);
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        compositor.backgroundMaterial.SetTexture("_Background", toTexture2D(backgroundCamera.targetTexture));
        Graphics.Blit(null, destination, compositor.backgroundMaterial, 0);
    }


    Texture2D toTexture2D(RenderTexture rTex)
    {
        Texture2D tex = new Texture2D(512, 512, TextureFormat.RGB24, false);
        // ReadPixels looks at the active RenderTexture.
        RenderTexture.active = rTex;
        tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
        tex.Apply();
        return tex;
    }
}