﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Voxels
{
    internal static partial class ShaderMixins
    {
        internal partial class MarchAttributesEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "MarchAttributes");
                if (context.GetParam(MarchAttributesKeys.AttributeSamplers) != null)
                {
                    foreach(var attr in context.GetParam(MarchAttributesKeys.AttributeSamplers))

                    {

                        {
                            var __mixinToCompose__ = (attr);
                            var __subMixin = new ShaderMixinSource();
                            context.PushCompositionArray(mixin, "AttributeSamplers", __subMixin);
                            context.Mixin(__subMixin, __mixinToCompose__);
                            context.PopComposition();
                        }
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("MarchAttributesEffect", new MarchAttributesEffect());
            }
        }
    }
}
