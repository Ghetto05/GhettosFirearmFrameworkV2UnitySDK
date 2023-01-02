using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhettosFirearmSDKv2
{
    [AddComponentMenu("Firearm SDK v2/Attachments/Systems/Illuminators/NVG Only Renderer - Mesh module")]
    public class NVGOnlyRendererMeshModule : MonoBehaviour
    {
        public enum Types
        {
            InfraRed,
            Thermal
        }

        public Types renderType;
        public List<GameObject> objects;
    }
}
