Shader "Yax/PropertiesShader"
/*This shader doesn't have any functionality other than containing properties.
It's just needed for customising values that will be used in og sod shader it will be replaced with at runtime.
Replacing shaders requires client modding, example ShaderSwap method can be found in ExampleScriptForShaderSwap.cs*/
{
    Properties
            {
                _PrimaryColor("Primary Color", Color) = (1,1,1,1)
                _SecondaryColor("Secondary Color", Color) = (1,1,1,1)
                _TertiaryColor("Tertiary Color", Color) = (1,1,1,1)
                _DetailTex("Detail (RGB)", 2D) = "white" {}
                [NoScaleOffset] _ColorMask("ColorMask", 2D) = "white" {}
                [NoScaleOffset] _BumpMap("Normal", 2D) = "bump" {}
                _BumpStrength("Normal Intensity", Range(0, 5)) = 1
                _Bump("Bump", Range(0, 500)) = 95
                _SpecColor("Specular Color", Color) = (0.5,0.5,0.5,1)
                _SpecularMap("Specular (R)", 2D) = "white" {}
                _Glossiness("Smoothness", Range(0.01, 1)) = 0.5
                [NoScaleOffset] _EmissiveMap("Emissive", 2D) = "white" {}
                [HDR] _EmissiveColor("Emissive Color", Color) = (0,0,0,1)
                _DecalMap("Decal", 2D) = "white" {}
                _DecalOpacity("Decal Opacity", Range(0, 1)) = 0
                _MKGlowColor("Glow Color", Color) = (1,1,1,1)
                _MKGlowPower("Glow Power", Range(0, 2.5)) = 0
                _MKGlowTex("Glow Texture", 2D) = "black" {}
                _MKGlowTexColor("Glow Texture Color", Color) = (1,1,1,1)
                _MKGlowTexStrength("Glow Texture Strength ", Range(0, 10)) = 0
            }

    SubShader
            {
                Pass
                {
                    LOD 200
                    CGPROGRAM
                    
                    float4 _PrimaryColor;
                    float4 _SecondaryColor;
                    float4 _TertiaryColor;
                    sampler2D _DetailTex;
                    sampler2D _ColorMask;
                    sampler2D _BumpMap;
                    half _BumpStrength;
                    float4 _SpecColor;
                    sampler2D _SpecularMap;
                    half _Glossiness;
                    sampler2D _EmissiveMap;
                    float4 _EmissiveColor;
                    sampler2D _DecalMap;
                    half _DecalOpacity;
                    float4 _MKGlowColor;
                    half _MKGlowPower;
                    sampler2D _MKGlowTex;
                    float4 _MKGlowTexColor;
                    half _MKGlowTexStrength;
                    half _Bump;
 
                    ENDCG
                }
            }
    
    FallBack "JS Games/Dragon Bumped Spec"
}
