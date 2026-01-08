Shader "Custom/URP/PulsingColor"
{
    Properties
    {
        _BaseColor ("Base Color", Color) = (1,0,0,1)
        _Speed ("Pulse Speed", Float) = 2
    }

    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" }
        LOD 100

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Attributes
            {
                float4 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
            };

            float4 _BaseColor;
            float _Speed;

            Varyings vert(Attributes v)
            {
                Varyings o;
                o.positionHCS = TransformObjectToHClip(v.positionOS.xyz);
                return o;
            }

            half4 frag(Varyings i) : SV_Target
            {
                float pulse = abs(sin(_Time.y * _Speed));
                return half4(_BaseColor.rgb * pulse, 1);
            }
            ENDHLSL
        }
    }
}
