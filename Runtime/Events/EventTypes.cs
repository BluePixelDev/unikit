using UnityEngine;

namespace BP.UniKit
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "UniKit/Events/Float")]
    public class FloatEvent : EventAsset<float> { }

    [CreateAssetMenu(fileName = "New Bool Event", menuName = "UniKit/Events/Boolean")]
    public class BoolEvent : EventAsset<float> { }

    [CreateAssetMenu(fileName = "New String Event", menuName = "UniKit/Events/String")]
    public class StringEvent : EventAsset<string> { }

    [CreateAssetMenu(fileName = "New Void Event", menuName = "UniKit/Events/Void")]
    public class VoidEvent : EventAsset { }
}
