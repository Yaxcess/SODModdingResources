Shader "Yax/DragonShader"
{
    Properties
    {
        _PrimaryColor("Primary Color", Color) = (1,1,1,1)
        _SecondaryColor("Secondary Color", Color) = (1,1,1,1)
        _TertiaryColor("Tertiary Color", Color) = (1,1,1,1)
        _DetailTex("Detail (RGB)", 2D) = "white" {}
        _MainTex("Main", 2D) = "white" {}
        [NoScaleOffset] _ColorMask("ColorMask", 2D) = "white" {}
        [NoScaleOffset] _NormalMap("Normal", 2D) = "bump" {}
        _NormalStrength("Normal Intensity", Range(0, 5)) = 1
        _LightInt("Shadows Intensity", Range(0.5, 2)) = 0.5
        [NoScaleOffset] _EmissiveMap("Emissive", 2D) = "white" {}
        [HDR] _EmissiveColor("Emissive Color", Color) = (0,0,0,1)
        _TextureLayerStrength("Texture Layer Strength", Range(0, 1)) = 0.5
        [NoScaleOffset] _SpecMap("Light Map", 2D) = "white" {}
        _ShadowColor("Shadows Color", Color) = (0,0,0,1)
        _LightMapInt("Light Map Intensity", Range(0.01, 1)) = 0.5
        
    }
    
    
        SubShader
        {
            Tags {"DisableBatching" = "True"
                 "RenderType" = "Opaque"
                 "LightMode" = "ForwardBase"}
            Pass
            {
                LOD 200
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"
                #include "Lighting.cginc"

                struct appdata_t
                {
                    float4 vertex : POSITION;
                    float2 uv : TEXCOORD0;
                    float3 normal : NORMAL;
                };

                struct v2f
                {
                    float2 uv : TEXCOORD0;
                    float3 normal : TEXCOORD1;
                    float4 vertex : SV_POSITION;
                    float3 worldPos : TEXCOORD2;
                };

                sampler2D _ColorMask;
                float4 _PrimaryColor;
                float4 _SecondaryColor;
                float4 _TertiaryColor;
                sampler2D _DetailTex;
                float _TextureLayerStrength;
                sampler2D _NormalMap;
                float _NormalStrength;
                half _LightInt;
                sampler2D _SpecMap;
                float4 _ShadowColor;
                half _LightMapInt;
                sampler2D _EmissiveMap;      
                float4 _EmissiveColor;
            

                v2f vert(appdata_t v)
                {
                    v2f o;
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = v.uv;
                    o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                    o.normal = UnityObjectToWorldNormal(v.normal);
                    return o;
                }

                fixed4 frag(v2f i) : SV_Target
                {
                    // Sample the color mask
                    fixed4 maskColor = tex2D(_ColorMask, i.uv);

                    fixed4 emissiveColor = tex2D(_EmissiveMap, i.uv);

                    // Sample the detail texture
                    fixed4 detailColor = tex2D(_DetailTex, i.uv);

                    fixed4 specMap = tex2D(_SpecMap, i.uv);

                    emissiveColor.rgb *= _EmissiveColor.rgb;

                    // Calculate lighting using the normal
                    float3 lightDir = normalize(_WorldSpaceLightPos0.xyz + i.worldPos);

                    // Sample the normal map
                    float3 normalMap = UnpackNormal(tex2D(_NormalMap, i.uv));

                    float diffuse = max(0.0, dot(i.normal, lightDir));

                    float3 viewDirection = normalize(_WorldSpaceCameraPos - mul(unity_ObjectToWorld, i.vertex).xyz);

                    float3 specularDirection = normalize(lightDir + viewDirection);

                    // Calculate the maximum of the RGB channels of the mask color
                    float maxMaskChannel = max(max(maskColor.r, maskColor.g), maskColor.b);

                    // Calculate the dot product between mask color and (0, 0, 0)
                    float maskDot = dot(maskColor.rgb, float3(0, 0, 0));

                    // Calculate the dot product between mask color and (1, 1, 1)
                    float whiteDot = dot(maskColor.rgb, float3(1, 1, 1));

                    // Calculate the dot product between mask color and (0.2, 0.2, 0.2)
                    float lowDot = dot(maskColor.rgb, float3(0.2, 0.2, 0.2));

                    float redDot = maskColor.r;

                    // Calculate luminance of colors
                    float primaryLuminance = dot(_PrimaryColor.rgb, float3(0.3, 0.59, 0.11));
                    float secondaryLuminance = dot(_SecondaryColor.rgb, float3(0.3, 0.59, 0.11));
                    float tertiaryLuminance = dot(_TertiaryColor.rgb, float3(0.3, 0.59, 0.11));

                    // Calculate influence based on luminance and redDot for each color property
                    float primaryInfluence = lerp(0.02, 0.5, primaryLuminance) * (1.0 - redDot) + redDot;
                    float secondaryInfluence = lerp(0.02, 0.5, secondaryLuminance) * (1.0 - redDot) + redDot;
                    float tertiaryInfluence = lerp(0.02, 0.5, tertiaryLuminance) * (1.0 - redDot) + redDot;

                    // Apply colors based on color mask
                    fixed4 blendedColor = _PrimaryColor * (1.0 - whiteDot) * (1.0 - redDot) * primaryInfluence; // No influence on (1, 1, 1)
                    blendedColor += _SecondaryColor * maskColor.g * (1.0 - redDot) * secondaryInfluence;
                    blendedColor += _TertiaryColor * maskColor.b * (1.0 - redDot) * tertiaryInfluence;

                    // Calculate additional influence based on maskDot and lowDot
                    blendedColor.rgb += _PrimaryColor.rgb * (maskDot * (1.0 - whiteDot) * (maskDot * (1.0 - redDot)) * maxMaskChannel);
                    blendedColor.rgb += _PrimaryColor.rgb * (lowDot * (1.0 - whiteDot) * (maskDot * (1.0 - redDot)) * max(0.0, 1.0 - lowDot));

                    // Calculate the final texture strength based on color influence for the red channel of the mask
                    float finalTextureStrength = _TextureLayerStrength * blendedColor * (1.0 - redDot) + redDot;

                    // Apply the texture layer over the blended color, with the calculated strength
                    fixed4 finalColor = lerp(blendedColor, detailColor, finalTextureStrength);

                    float4 specColor = _SpecColor;

                    specColor = _LightColor0;

                    float finalLightMap = specMap.rgb * _LightMapInt;

                    float3 halfVec = normalize(lightDir);

                    float intensityLight = pow(saturate(dot(halfVec, i.normal)), _LightInt);

                    float4 specular = intensityLight * finalLightMap * specColor;

                    float intensityShadow = pow(saturate(dot(-halfVec, i.normal)), _LightInt);

                    float4 shadow = intensityLight * finalLightMap * _ShadowColor;

                    float3 normal = normalize(i.normal * normalMap * 2.0 - 1.0) * _NormalStrength * specular;


                    float finalDiffuse = max(0.0, dot(normal, lightDir));
                

                    finalColor.rgb += finalDiffuse + specular + shadow + emissiveColor;
                    return finalColor;
                }
            ENDCG
            }
            Pass
            {
                Tags {"LightMode" = "ForwardAdd"}
                Blend One One
                LOD 200
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"
                #include "Lighting.cginc"

                struct appdata_t
                {
                    float4 vertex : POSITION;
                    float2 uv : TEXCOORD0;
                    float3 normal : NORMAL;
                };

                struct v2f
                {
                    float2 uv : TEXCOORD0;
                    float3 normal : TEXCOORD1;
                    float4 vertex : SV_POSITION;
                    float3 worldPos : TEXCOORD2;
                };

                uniform sampler2D _ColorMask;
                uniform float4 _PrimaryColor;
                uniform float4 _SecondaryColor;
                uniform float4 _TertiaryColor;
                uniform sampler2D _DetailTex;
                uniform float _TextureLayerStrength;
                uniform sampler2D _NormalMap;
                uniform float _NormalStrength;
                uniform half _LightInt;
                uniform sampler2D _SpecMap;
                uniform float4 _ShadowColor;
                uniform half _LightMapInt;

                v2f vert(appdata_t v)
                {
                    v2f o;
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = v.uv;
                    o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                    o.normal = UnityObjectToWorldNormal(v.normal); 
                    return o;
                }

                fixed4 frag(v2f i) : SV_Target
                {
                    fixed4 maskColor = tex2D(_ColorMask, i.uv);

                    fixed4 detailColor = tex2D(_DetailTex, i.uv);

                    fixed4 specMap = tex2D(_SpecMap, i.uv);

                    float3 lightDir = normalize(_WorldSpaceLightPos0.xyz + i.worldPos);

                    float3 normalMap = UnpackNormal(tex2D(_NormalMap, i.uv));

                    float diffuse = max(0.0, dot(i.normal, lightDir));

                    float3 viewDirection = normalize(_WorldSpaceCameraPos - mul(unity_ObjectToWorld, i.vertex).xyz);

                    float3 specularDirection = normalize(lightDir + viewDirection);

                    float maxMaskChannel = max(max(maskColor.r, maskColor.g), maskColor.b);

                    float maskDot = dot(maskColor.rgb, float3(0, 0, 0));

                    float whiteDot = dot(maskColor.rgb, float3(1, 1, 1));

                    float lowDot = dot(maskColor.rgb, float3(0.2, 0.2, 0.2));

                    float redDot = maskColor.r;

                    // Calculate luminance of colors
                    float primaryLuminance = dot(_PrimaryColor.rgb, float3(0.3, 0.59, 0.11));
                    float secondaryLuminance = dot(_SecondaryColor.rgb, float3(0.3, 0.59, 0.11));
                    float tertiaryLuminance = dot(_TertiaryColor.rgb, float3(0.3, 0.59, 0.11));

                    // Calculate influence based on luminance and redDot for each color property
                    float primaryInfluence = lerp(0.02, 0.5, primaryLuminance) * (1.0 - redDot) + redDot;
                    float secondaryInfluence = lerp(0.02, 0.5, secondaryLuminance) * (1.0 - redDot) + redDot;
                    float tertiaryInfluence = lerp(0.02, 0.5, tertiaryLuminance) * (1.0 - redDot) + redDot;

                    // Apply colors based on color mask
                    fixed4 blendedColor = _PrimaryColor * (1.0 - whiteDot) * (1.0 - redDot) * primaryInfluence; // No influence on (1, 1, 1)
                    blendedColor += _SecondaryColor * maskColor.g * (1.0 - redDot) * secondaryInfluence;
                    blendedColor += _TertiaryColor * maskColor.b * (1.0 - redDot) * tertiaryInfluence;

                    // Calculate additional influence based on maskDot and lowDot
                    blendedColor.rgb += _PrimaryColor.rgb * (maskDot * (1.0 - whiteDot) * (maskDot * (1.0 - redDot)) * maxMaskChannel);
                    blendedColor.rgb += _PrimaryColor.rgb * (lowDot * (1.0 - whiteDot) * (maskDot * (1.0 - redDot)) * max(0.0, 1.0 - lowDot));

                    // Calculate the final texture strength based on color influence for the red channel of the mask
                    float finalTextureStrength = _TextureLayerStrength * blendedColor * (1.0 - redDot) + redDot;

                    // Apply the texture layer over the blended color, with the calculated strength
                    fixed4 finalColor = lerp(blendedColor, detailColor, finalTextureStrength);

                    float4 specColor = _SpecColor;
                    specColor = _LightColor0;
                    float3 ambientLighting = UNITY_LIGHTMODEL_AMBIENT.rgb * _LightColor0;

                    float attenuation;
                    if (0.0 == _WorldSpaceLightPos0.w)
                    {
                        attenuation = 1.0;
                        lightDir = normalize(_WorldSpaceLightPos0.xyz);
                    }
                    else
                    {
                        float3 vertexToLightSource = _WorldSpaceLightPos0.xyz - i.worldPos.xyz;
                        float distance = length(vertexToLightSource);
                        attenuation = 1.0 / distance;
                        lightDir = normalize(vertexToLightSource);
                    }

                    float finalLightMap = specMap.rgb * _LightMapInt;

                    float3 halfVec = normalize(lightDir);

                    float intensityLight = pow(saturate(dot(halfVec, i.normal)), _LightInt);

                    float4 specular = intensityLight * finalLightMap * specColor;

                    float intensityShadow = pow(saturate(dot(-halfVec, i.normal)), _LightInt);

                    float4 shadow = intensityLight * finalLightMap * _ShadowColor * attenuation;

                    // Apply the normal map to the calculated normal
                    float3 normal = normalize(i.normal * normalMap * 2.0 - 1.0) * _NormalStrength * specular;

                    // Calculate final lighting and shading using the normal
                    float finalDiffuse = max(0.0, dot(normal, lightDir));
                    ;

                    // Combine the final color with the adjusted lighting
                    finalColor.rgb += finalDiffuse + specular + shadow;

                    return finalColor;
                }
            ENDCG
            }
        }
    FallBack "Specular"
}
