Shader "Yax/DragonShaderV2"
{
    Properties
    {
        [Header(Main colors)]
        [Space]
        _PrimaryColor("Primary Color", Color) = (1,1,1,1)
        _SecondaryColor("Secondary Color", Color) = (1,1,1,1)
        _TertiaryColor("Tertiary Color", Color) = (1,1,1,1)
        [Header(Main texture)]
        [Space]
        _DetailTex("Detail (RGB)", 2D) = "white" {}
        _TextureLayerStrength("Texture Layer Strength", Range(-10, 10)) = 1
        [Header(Color mask)]
        [Space]
        [NoScaleOffset] _ColorMask("ColorMask", 2D) = "white" {}
        [Header(Emission)]
        [Space]
        [NoScaleOffset] _EmissiveMap("Emissive", 2D) = "white" {}
        [HDR] _EmissiveColor("Emissive Color", Color) = (0,0,0,1)
        [Toggle]_EmissionColorDep("Use blended Main Colors as Emissive Color", float) = 0
        _EmissionStrength("Emission Strength", Range(0, 10)) = 1
        [Header(Normal Map)]
        [Space]
        _BumpMap("Normal map", 2D) = "bump" {}
        _NormalIntensity("Normal Intensity", Range(-10, 10)) = 1
        [Header(Specular)]
        [Space]
        _SpecColor("Specular Color", Color) = (1,1,1,1)
        _SpecularIntensity("Specular Intensity", Range(-10, 10)) = 1
        [Header(Glossiness)]
        [Space]
        _Glossiness("Glossiness", Range(-10, 10)) = 1
        _SpecularThreshold("Highlight Threshold", Range(0, 10)) = 1
        [Header(Decal)]
        [Space]
        _DecalMap("Decal", 2D) = "white" {}
        _DecalOpacity("Decal Opacity", Range(0, 1)) = 0
        [Header(Glow(for algae vials))]
        [Space]
        _MKGlowTex("Glow Texture", 2D) = "black" {}
        _MKGlowColor("Glow Color", Color) = (1,1,1,1)
        _MKGlowPower("Glow Power", Range(0, 10)) = 0
        _MKGlowTexColor("Glow Texture Color", Color) = (1,1,1,1)
        _MKGlowTexStrength("Glow Texture Strength", Range(0, 10)) = 0
        [Header(Shadows)]
        [Space]
        _ShadowIntensity("Shadow Intensity", Range(0, 10)) = 1
        _ShadowsColor("Shadows Color", Color) = (0,0,0,1)
        [Header(Misc)]
        [Space]
        _ColorSaturation("Colors Saturation", Range(0, 10)) = 1
        _DiffuseIntensity("Lighting Intensity", Range(-10, 10)) = 1
        [Enum(UnityEngine.Rendering.CullMode)] _Culling ("Culling", Float) = 2
    }
    
        SubShader{
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
            "IgnoreProjector"="True"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode" = "ForwardBase"
            }
            Cull [_Culling]


            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
            #pragma target 3.0
            uniform sampler2D _DetailTex; 
            uniform float4 _DetailTex_ST;
            uniform float4 _PrimaryColor;
            uniform float4 _SecondaryColor;
            uniform float4 _TertiaryColor;
            uniform float4 _EmissiveColor;
            uniform sampler2D _ColorMask;
            uniform sampler2D _EmissiveMap;
            uniform float _TextureLayerStrength;
            uniform float _EmissionStrength;
            uniform float4 _MKGlowColor;
            uniform float _MKGlowPower;
            uniform sampler2D _MKGlowTex;
            uniform float4 _MKGlowTexColor;
            uniform float _MKGlowTexStrength;
            uniform sampler2D _BumpMap; 
            uniform sampler2D _DecalMap; 
            uniform float4 _BumpMap_ST;
            uniform float _NormalIntensity;
            uniform float _SpecularIntensity;
            uniform float _SpecularThreshold;
            uniform float _Glossiness;
            uniform float _DecalOpacity;
            uniform float _ColorSaturation;
            uniform float _DiffuseIntensity;
            uniform float _EmissionColorDep;
            uniform float _ShadowIntensity;
            uniform float4 _ShadowsColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                UNITY_LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert(VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #if defined(LIGHTMAP_ON)
                    float3 bakedLightmap = DecodeLightmap(UNITY_SAMPLE_TEX2D(unity_Lightmap, i.ambientOrLightmapUV.xy));
                    indirectDiffuse += bakedLightmap;
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize(mul(unity_ObjectToWorld, float4(v.tangent.xyz, 0.0)).xyz);
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = (facing >= 0 ? 1 : 0);
                float faceSign = (facing >= 0 ? 1 : -1);
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3(i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 normalLocal = lerp(float3(0,0,1),_BumpMap_var.rgb,_NormalIntensity);
                float3 normalDirection = normalize(mul(normalLocal, tangentTransform)); // Perturbed normals
                float3 viewReflectDirection = reflect(-viewDirection, normalDirection);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection + lightDirection);
                float4 _DetailTex_var = tex2D(_DetailTex, TRANSFORM_TEX(i.uv0, _DetailTex));
                clip(_DetailTex_var.a - 0.1);
                float4 _DecalMap_var = tex2D(_DecalMap, i.uv0);
                float4 maskColor = tex2D(_ColorMask, i.uv0);
                float4 mKTex = tex2D(_MKGlowTex, i.uv0);
                float4 emissiveColor = tex2D(_EmissiveMap, i.uv0);

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
                float primaryLuminance = dot(_PrimaryColor.rgba, float3(0.3, 0.59, 0.11));
                float secondaryLuminance = dot(_SecondaryColor.rgba, float3(0.3, 0.59, 0.11));
                float tertiaryLuminance = dot(_TertiaryColor.rgba, float3(0.3, 0.59, 0.11));

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

                float detailLuminance = dot(_DetailTex_var.rgb, float3(0.3, 0.59, 0.11));

                // Reduce texture strength in bright areas using inverse luminance
                float finalTextureStrength = (_TextureLayerStrength * blendedColor * (1.0 - redDot) * (1.0 - detailLuminance)) + redDot;
                
                float3 finalColor = lerp(blendedColor.rgb, _DetailTex_var.rgb, finalTextureStrength);
                finalColor = saturate(lerp(dot(finalColor, float3(0.3, 0.59, 0.11)), finalColor, _ColorSaturation));


                emissiveColor.rgb *= (_EmissionColorDep == 1) ? blendedColor.rgb : _EmissiveColor.rgb;

                ////// Lighting:
                                UNITY_LIGHT_ATTENUATION(attenuation, i, i.posWorld.xyz);
                                attenuation = pow(attenuation, _ShadowIntensity);
                                float3 attenColor = attenuation * _LightColor0.xyz;
                                float Pi = 3.141592654;
                                float InvPi = 0.31830988618;
                                ///////// Gloss:
                                                float smoothness = -_Glossiness;
                                                float perceptualRoughness = 1.0 - smoothness;
                                                perceptualRoughness = lerp(perceptualRoughness, 1.0, _SpecularThreshold);
                                                float roughness = perceptualRoughness * perceptualRoughness;
                                                float specPow = exp2((smoothness * 10.0) + 1.0);
                                                specPow = lerp(specPow, specPow * 0.25, _SpecularThreshold);
                                                /////// GI Data:
                                                                UnityLight light;
                                                                #ifdef LIGHTMAP_OFF
                                                                    light.color = lightColor;
                                                                    light.dir = lightDirection;
                                                                    light.ndotl = LambertTerm(normalDirection, light.dir);
                                                                #else
                                                                    light.color = half3(0.f, 0.f, 0.f);
                                                                    light.ndotl = 0.0f;
                                                                    light.dir = half3(0.f, 0.f, 0.f);
                                                                #endif
                                                                UnityGIInput d;
                                                                d.light = light;
                                                                d.worldPos = i.posWorld.xyz;
                                                                d.worldViewDir = viewDirection;
                                                                d.atten = attenuation;
                                                                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                                                                    d.ambient = 0;
                                                                    d.lightmapUV = i.ambientOrLightmapUV;
                                                                #else
                                                                    d.ambient = i.ambientOrLightmapUV;
                                                                #endif
                                                                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                                                                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                                                                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                                                                #endif
                                                                #if UNITY_SPECCUBE_BOX_PROJECTION
                                                                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                                                                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                                                                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                                                                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                                                                #endif
                                                                d.probeHDR[0] = unity_SpecCube0_HDR;
                                                                d.probeHDR[1] = unity_SpecCube1_HDR;
                                                                Unity_GlossyEnvironmentData ugls_en_data;
                                                                ugls_en_data.roughness = 1.0 - smoothness;
                                                                ugls_en_data.reflUVW = viewReflectDirection;
                                                                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data);
                                                                lightDirection = gi.light.dir;
                                                                lightColor = gi.light.color;
                                                                ////// Specular:
                                                                                float NdotL = saturate(dot(normalDirection, lightDirection));
                                                                                float LdotH = saturate(dot(lightDirection, halfDirection));
                                                                                float3 specularColor = ((_DetailTex_var.a * _SpecularIntensity * 0.02) * _SpecColor.rgb);
                                                                                float specularMonochrome;
                                                                                float3 diffuseColor = finalColor;
                                                                                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                                                                                specularMonochrome = 1.0 - specularMonochrome;
                                                                                float NdotV = abs(dot(normalDirection, viewDirection));
                                                                                float NdotH = saturate(dot(normalDirection, halfDirection));
                                                                                float VdotH = saturate(dot(viewDirection, halfDirection));
                                                                                float visTerm = SmithJointGGXVisibilityTerm(NdotL, NdotV, roughness);
                                                                                float normTerm = GGXTerm(NdotH, roughness);
                                                                                float specularPBL = (visTerm * normTerm) * UNITY_PI;
                                                                                #ifdef UNITY_COLORSPACE_GAMMA
                                                                                    specularPBL = sqrt(max(1e-4h, specularPBL));
                                                                                #endif
                                                                                specularPBL = max(0, specularPBL * NdotL);
                                                                                #if defined(_SPECULARHIGHLIGHTS_OFF)
                                                                                    specularPBL = 0.0;
                                                                                #endif
                                                                                half surfaceReduction;
                                                                                #ifdef UNITY_COLORSPACE_GAMMA
                                                                                    surfaceReduction = 1.0 - 0.28 * roughness * perceptualRoughness;
                                                                                #else
                                                                                    surfaceReduction = 1.0 / (roughness * roughness + 1.0);
                                                                                #endif
                                                                                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                                                                                float3 directSpecular = attenColor * specularPBL * FresnelTerm(specularColor, LdotH);
                                                                                half grazingTerm = saturate(smoothness + specularMonochrome);
                                                                                float3 indirectSpecular = (gi.indirect.specular);
                                                                                indirectSpecular *= FresnelLerp(specularColor, grazingTerm, NdotV);
                                                                                indirectSpecular *= surfaceReduction;
                                                                                float3 specular = (directSpecular * attenuation + indirectSpecular);
                                                                                /////// Diffuse:
                                                                                                NdotL = max(0.0,dot(normalDirection, lightDirection));
                                                                                                half fd90 = 1.0f + 2 * LdotH * LdotH * (1 - smoothness);
                                                                                                float nlPow5 = Pow5(1 - NdotL);
                                                                                                float nvPow5 = Pow5(1 - NdotV);
                                                                                                float3 directDiffuse = ((1.0f + (fd90 - 1) * nlPow5) * (1 + (fd90 - 1) * nvPow5) * NdotL) * attenColor;
                                                                                                float3 indirectDiffuse = gi.indirect.diffuse;
                                                                                                #if defined(LIGHTMAP_ON)
                                                                                                    indirectDiffuse += DecodeLightmap(UNITY_SAMPLE_TEX2D(unity_Lightmap, i.ambientOrLightmapUV.xy));
                                                                                                #endif
                                                                                                diffuseColor *= 1.0f - specularMonochrome;
                                                                                                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
                                                                                                /// Final Color:
                                                                                                float3 mkTexColor = mKTex * _MKGlowTexColor * _MKGlowTexStrength;
                                                                                                
                                                                                                finalColor += diffuse * _DiffuseIntensity + specular + _DecalMap_var * _DecalOpacity;
                                                                                                fixed4 finalRGBA = fixed4((finalColor + directDiffuse * 0.1 + indirectDiffuse * 0.1) * 0.3 + emissiveColor * _EmissionStrength + mkTexColor, 1);
                                                                                                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                                                                                                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
            "LightMode" = "ForwardAdd"
            }
            Blend One One
            Cull Back


            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
            #pragma target 3.0
            uniform sampler2D _DetailTex;
            uniform float4 _DetailTex_ST;
            uniform float4 _PrimaryColor;
            uniform float4 _SecondaryColor;
            uniform float4 _TertiaryColor;
            uniform float4 _EmissiveColor;
            uniform sampler2D _ColorMask;
            uniform sampler2D _EmissiveMap;
            uniform float _TextureLayerStrength;
            uniform float _EmissionStrength;
            uniform float4 _MKGlowColor;
            uniform float _MKGlowPower;
            uniform sampler2D _MKGlowTex;
            uniform float4 _MKGlowTexColor;
            uniform float _MKGlowTexStrength;
            uniform sampler2D _BumpMap;
            uniform sampler2D _DecalMap;
            uniform float4 _BumpMap_ST;
            uniform float _NormalIntensity;
            uniform float _SpecularIntensity;
            uniform float _SpecularThreshold;
            uniform float _Glossiness;
            uniform float _DecalOpacity;
            uniform float _ColorSaturation;
            uniform float _DiffuseIntensity;
            uniform float _EmissionColorDep;
            uniform float _ShadowIntensity;
            uniform float4 _ShadowsColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                UNITY_LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert(VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize(mul(unity_ObjectToWorld, float4(v.tangent.xyz, 0.0)).xyz);
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = (facing >= 0 ? 1 : 0);
                float faceSign = (facing >= 0 ? 1 : -1);
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3(i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 normalLocal = lerp(float3(0,0,1),_BumpMap_var.rgb,_NormalIntensity);
                float3 normalDirection = normalize(mul(normalLocal, tangentTransform)); // Perturbed normals
                float3 viewReflectDirection = reflect(-viewDirection, normalDirection);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection + lightDirection);

                float4 _DetailTex_var = tex2D(_DetailTex, TRANSFORM_TEX(i.uv0, _DetailTex));
                float4 _DecalMap_var = tex2D(_DecalMap, i.uv0);
                float4 maskColor = tex2D(_ColorMask, i.uv0);
                float4 mKTex = tex2D(_MKGlowTex, i.uv0);
                float4 emissiveColor = tex2D(_EmissiveMap, i.uv0);

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
                float3 finalColor = lerp(blendedColor * _ColorSaturation, _DetailTex_var, finalTextureStrength) + _MKGlowColor * _MKGlowPower;

                emissiveColor.rgb *= (_EmissionColorDep == 1) ? blendedColor.rgb : _EmissiveColor.rgb;

                ////// Lighting:
                                UNITY_LIGHT_ATTENUATION(attenuation,i, i.posWorld.xyz);
                                attenuation = pow(attenuation, _ShadowIntensity);
                                float3 attenColor = attenuation * _LightColor0.xyz;
                                float Pi = 3.141592654;
                                float InvPi = 0.31830988618;
                                ///////// Gloss:
                                                float smoothness = -_Glossiness;
                                                float perceptualRoughness = 1.0 - smoothness;
                                                perceptualRoughness = lerp(perceptualRoughness, 1.0, _SpecularThreshold); // Control highlight spread
                                                float roughness = perceptualRoughness * perceptualRoughness;
                                                float specPow = exp2((smoothness * 10.0) + 1.0);
                                                specPow = lerp(specPow, specPow * 0.25, _SpecularThreshold);
                                                /////// GI Data:
                                                                UnityLight light;
                                                                #ifdef LIGHTMAP_OFF
                                                                    light.color = lightColor;
                                                                    light.dir = lightDirection;
                                                                    light.ndotl = LambertTerm(normalDirection, light.dir);
                                                                #else
                                                                    light.color = half3(0.f, 0.f, 0.f);
                                                                    light.ndotl = 0.0f;
                                                                    light.dir = half3(0.f, 0.f, 0.f);
                                                                #endif
                                                                UnityGIInput d;
                                                                d.light = light;
                                                                d.worldPos = i.posWorld.xyz;
                                                                d.worldViewDir = viewDirection;
                                                                d.atten = attenuation;
                                                                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                                                                    d.ambient = 0;
                                                                    d.lightmapUV = i.ambientOrLightmapUV;
                                                                #else
                                                                    d.ambient = i.ambientOrLightmapUV;
                                                                #endif
                                                                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                                                                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                                                                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                                                                #endif
                                                                #if UNITY_SPECCUBE_BOX_PROJECTION
                                                                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                                                                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                                                                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                                                                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                                                                #endif
                                                                d.probeHDR[0] = unity_SpecCube0_HDR;
                                                                d.probeHDR[1] = unity_SpecCube1_HDR;
                                                                Unity_GlossyEnvironmentData ugls_en_data;
                                                                ugls_en_data.roughness = 1.0 - smoothness;
                                                                ugls_en_data.reflUVW = viewReflectDirection;
                                                                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data);
                                                                lightDirection = gi.light.dir;
                                                                lightColor = gi.light.color;
                                                                ////// Specular:
                                                                                float NdotL = saturate(dot(normalDirection, lightDirection));
                                                                                float LdotH = saturate(dot(lightDirection, halfDirection));
                                                                                float3 specularColor = ((_DetailTex_var.a * _SpecularIntensity * 0.02) * _SpecColor.rgb);
                                                                                float specularMonochrome;
                                                                                float3 diffuseColor = (_DetailTex_var.rgb * finalColor.rgb);
                                                                                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                                                                                specularMonochrome = 1.0 - specularMonochrome;
                                                                                float NdotV = abs(dot(normalDirection, viewDirection));
                                                                                float NdotH = saturate(dot(normalDirection, halfDirection));
                                                                                float VdotH = saturate(dot(viewDirection, halfDirection));
                                                                                float visTerm = SmithJointGGXVisibilityTerm(NdotL, NdotV, roughness);
                                                                                float normTerm = GGXTerm(NdotH, roughness);
                                                                                float specularPBL = (visTerm * normTerm) * UNITY_PI;
                                                                                #ifdef UNITY_COLORSPACE_GAMMA
                                                                                    specularPBL = sqrt(max(1e-4h, specularPBL));
                                                                                #endif
                                                                                specularPBL = max(0, specularPBL * NdotL);
                                                                                #if defined(_SPECULARHIGHLIGHTS_OFF)
                                                                                    specularPBL = 0.0;
                                                                                #endif
                                                                                half surfaceReduction;
                                                                                #ifdef UNITY_COLORSPACE_GAMMA
                                                                                    surfaceReduction = 1.0 - 0.28 * roughness * perceptualRoughness;
                                                                                #else
                                                                                    surfaceReduction = 1.0 / (roughness * roughness + 1.0);
                                                                                #endif
                                                                                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                                                                                float3 directSpecular = attenColor * specularPBL * FresnelTerm(specularColor, LdotH);
                                                                                half grazingTerm = saturate(smoothness + specularMonochrome);
                                                                                float3 indirectSpecular = (gi.indirect.specular);
                                                                                indirectSpecular *= FresnelLerp(specularColor, grazingTerm, NdotV);
                                                                                indirectSpecular *= surfaceReduction;
                                                                                float3 specular = (directSpecular * attenuation + indirectSpecular);
                                                                                /////// Diffuse:
                                                                                                NdotL = max(0.0,dot(normalDirection, lightDirection));
                                                                                                half fd90 = 1.0f + 2 * LdotH * LdotH * (1 - smoothness);
                                                                                                float nlPow5 = Pow5(1 - NdotL);
                                                                                                float nvPow5 = Pow5(1 - NdotV);
                                                                                                float3 directDiffuse = ((1.0f + (fd90 - 1) * nlPow5) * (1 + (fd90 - 1) * nvPow5) * NdotL) * attenColor;
                                                                                                float3 indirectDiffuse = gi.indirect.diffuse;
                                                                                                #if defined(LIGHTMAP_ON)
                                                                                                    indirectDiffuse += DecodeLightmap(UNITY_SAMPLE_TEX2D(unity_Lightmap, i.ambientOrLightmapUV.xy));
                                                                                                #endif
                                                                                                diffuseColor *= 1.0f - specularMonochrome;
                                                                                                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
                                                                                                /// Final Color:
                                                                                                float3 mkTexColor = mKTex * _MKGlowTexColor * _MKGlowTexStrength;

                                                                                                finalColor += diffuse * _DiffuseIntensity + specular + _DecalMap_var * _DecalOpacity;
                                                                                                fixed4 finalRGBA = fixed4((finalColor + directDiffuse * 0.1 + indirectDiffuse * 0.1) * 0.4 + emissiveColor * _EmissionStrength + mkTexColor, 1);
                                                                                                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                                                                                                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode" = "ShadowCaster"
            }
            Offset 1, 1
            Cull Off
        
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
            #pragma target 3.0
            

            uniform sampler2D _DetailTex; 
            uniform float4 _DetailTex_ST;
        
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            
            VertexOutput vert(VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                    float4 _DetailTex_var = tex2D(_DetailTex, TRANSFORM_TEX(i.uv0, _DetailTex));
                    clip(_DetailTex_var.a - 0.1);
                    float isFrontFace = (facing >= 0 ? 1 : 0);
                    float faceSign = (facing >= 0 ? 1 : -1);
                    float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                    
                    SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode" = "Meta"
            }
            Cull Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
            #pragma target 3.0
            uniform sampler2D _DetailTex; uniform float4 _DetailTex_ST;
            uniform float4 _PrimaryColor;
            uniform float4 _SecondaryColor;
            uniform float4 _TertiaryColor;
            uniform float4 _EmissiveColor;
            uniform sampler2D _ColorMask;
            uniform sampler2D _EmissiveMap;
            uniform float4 _MKGlowColor;
            uniform float _MKGlowPower;
            uniform sampler2D _MKGlowTex;
            uniform float4 _MKGlowTexColor;
            uniform float _MKGlowTexStrength;
            uniform float _TextureLayerStrength;
            uniform float _EmissionStrength;
            uniform float _SpecularIntensity;
            uniform float _Glossiness;
            uniform float _DecalOpacity;
            uniform float _ColorSaturation;
            uniform float _DiffuseIntensity;
            uniform float _EmissionColorDep;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert(VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = (facing >= 0 ? 1 : 0);
                float faceSign = (facing >= 0 ? 1 : -1);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT(UnityMetaInput, o);

                float4 _DetailTex_var = tex2D(_DetailTex, TRANSFORM_TEX(i.uv0, _DetailTex));
                float4 maskColor = tex2D(_ColorMask, i.uv0);
                float4 mKTex = tex2D(_MKGlowTex, i.uv0);
                float4 emissiveColor = tex2D(_EmissiveMap, i.uv0);

                o.Emission = emissiveColor.rgb * _EmissionStrength + _MKGlowColor.rgb * _MKGlowPower + mKTex.rgb * _MKGlowTexColor.rgb * _MKGlowTexStrength;

                

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
                float3 finalColor = lerp(blendedColor, _DetailTex_var, finalTextureStrength) + _MKGlowColor * _MKGlowPower * 0.1f;

                emissiveColor.rgb *= (_EmissionColorDep == 1) ? blendedColor.rgb : _EmissiveColor.rgb;

                finalColor += emissiveColor * _EmissionStrength;

                float3 mkTexColor = mKTex * _MKGlowTexColor * _MKGlowTexStrength * 0.1f;

                finalColor += mkTexColor;

                float3 diffColor = (_DetailTex_var.rgb * finalColor.rgb);
                float3 specColor = ((_DetailTex_var.a * _SpecularIntensity * 0.02) * _SpecColor.rgb);
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0 - specularMonochrome);
                float roughness = 1.0 - _Glossiness * -0.02;
                float3 albedo = blendedColor.rgb * _ColorSaturation * _DetailTex_var.rgb;
                o.Albedo = albedo;

                return UnityMetaFragment(o);
                }
                ENDCG
            }
        }
            FallBack "Diffuse"
}