using UnityEngine;
using Unity.Barracuda;

namespace Cam {

public enum Architecture { MobileNetV1, ResNet50 }

[CreateAssetMenu(fileName = "Cam",
                 menuName = "ScriptableObjects/Cam Resource Set")]
public sealed class ResourceSet : ScriptableObject
{
    public NNModel model;
    public Architecture architecture;
    public ComputeShader preprocess;
    public Shader postprocess;
}

} // namespace Cam
