﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.1+g046e9eb0a2
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile partly-cloudy-night.json
//       
//       Input file:
//           partly-cloudy-night.json (3104 bytes created 5:34+05:30 Dec 4 2023)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    42 |
// |--------------------------+-------|
// | Expression animators     |     1 |
// | KeyFrame animators       |     1 |
// | Reference parameters     |     1 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     2 |
// |--------------------------+-------|
// | Brushes                  |     4 |
// | Gradient stops           |     6 |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Drizzle.UI.UWP.AnimatedVisuals
{
    // Name:        partly-cloudy-night
    // Frame rate:  60 fps
    // Frame count: 360
    // Duration:    6000.0 mS
    sealed class PartlyCloudyNight
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 6.000 seconds.
        internal const long c_durationTicks = 60000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Partly_cloudy_night_AnimatedVisual.IsRuntimeCompatible())
            {
                var res = 
                    new Partly_cloudy_night_AnimatedVisual(
                        compositor
                        );
                    return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 360d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 360d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class Partly_cloudy_night_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 60000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - Layer aggregator
            // - - Path 1
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(74.6159973F, 21.4020004F));
                    builder.AddCubicBezier(new Vector2(27.4459991F, 21.4020004F), new Vector2(-10.7930002F, -16.3260002F), new Vector2(-10.7930002F, -62.8650017F));
                    builder.AddCubicBezier(new Vector2(-10.7930002F, -70.1780014F), new Vector2(-9.75F, -77.2340012F), new Vector2(-7.9749999F, -84F));
                    builder.AddCubicBezier(new Vector2(-50.7249985F, -79.3860016F), new Vector2(-84F, -43.6739998F), new Vector2(-84F, -0.26699999F));
                    builder.AddCubicBezier(new Vector2(-84F, 46.2719994F), new Vector2(-45.7610016F, 84F), new Vector2(1.40900004F, 84F));
                    builder.AddCubicBezier(new Vector2(41.1669998F, 84F), new Vector2(74.4810028F, 57.1590004F), new Vector2(84F, 20.8689995F));
                    builder.AddCubicBezier(new Vector2(80.9150009F, 21.2019997F), new Vector2(77.7910004F, 21.4020004F), new Vector2(74.6159973F, 21.4020004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<260, 256>
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(116F, -4F));
                    builder.AddCubicBezier(new Vector2(115.146004F, -4F), new Vector2(114.315002F, -3.91100001F), new Vector2(113.471001F, -3.87299991F));
                    builder.AddCubicBezier(new Vector2(115.063004F, -10.3319998F), new Vector2(116F, -17.0489998F), new Vector2(116F, -24F));
                    builder.AddCubicBezier(new Vector2(116F, -70.3919983F), new Vector2(78.3919983F, -108F), new Vector2(32F, -108F));
                    builder.AddCubicBezier(new Vector2(1.79900002F, -108F), new Vector2(-24.6009998F, -92.0090027F), new Vector2(-39.4039993F, -68.0849991F));
                    builder.AddCubicBezier(new Vector2(-47.7820015F, -73.0790024F), new Vector2(-57.5390015F, -76F), new Vector2(-68F, -76F));
                    builder.AddCubicBezier(new Vector2(-98.9280014F, -76F), new Vector2(-124F, -50.9280014F), new Vector2(-124F, -20F));
                    builder.AddCubicBezier(new Vector2(-124F, -16.8999996F), new Vector2(-123.682999F, -13.8800001F), new Vector2(-123.198997F, -10.9169998F));
                    builder.AddCubicBezier(new Vector2(-150.977997F, -5.66699982F), new Vector2(-172F, 18.6940002F), new Vector2(-172F, 48F));
                    builder.AddCubicBezier(new Vector2(-172F, 81.137001F), new Vector2(-145.136993F, 108F), new Vector2(-112F, 108F));
                    builder.AddCubicBezier(new Vector2(-110.649002F, 108F), new Vector2(-109.328003F, 107.886002F), new Vector2(-108F, 107.797997F));
                    builder.AddLine(new Vector2(-108F, 108F));
                    builder.AddLine(new Vector2(116F, 108F));
                    builder.AddCubicBezier(new Vector2(146.927994F, 108F), new Vector2(172F, 82.9280014F), new Vector2(172F, 52F));
                    builder.AddCubicBezier(new Vector2(172F, 21.0720005F), new Vector2(146.927994F, -4F), new Vector2(116F, -4F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Layer aggregator
            // Offset:<260, 256>
            CompositionColorBrush ColorBrush_AlmostLavender_FFE6EFFC()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xE6, 0xEF, 0xFC));
            }

            // - Layer aggregator
            // Path 1
            CompositionColorBrush ColorBrush_AlmostSkyBlue_FF72B9D5()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x72, 0xB9, 0xD5));
            }

            // - - Layer aggregator
            // -  Offset:<260, 256>
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostAliceBlue_FFF3F7FD()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0xF3, 0xF7, 0xFD));
            }

            // - - Layer aggregator
            // - Path 1
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostSkyBlue_FF85C3DB()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x85, 0xC3, 0xDB));
            }

            // - - Layer aggregator
            // -  Offset:<260, 256>
            // Stop 1
            CompositionColorGradientStop GradientStop_0p45_AlmostAliceBlue_FFF3F7FD()
            {
                return _c.CreateColorGradientStop(0.449999988F, Color.FromArgb(0xFF, 0xF3, 0xF7, 0xFD));
            }

            // - - Layer aggregator
            // - Path 1
            // Stop 1
            CompositionColorGradientStop GradientStop_0p45_AlmostSkyBlue_FF85C3DB()
            {
                return _c.CreateColorGradientStop(0.449999988F, Color.FromArgb(0xFF, 0x85, 0xC3, 0xDB));
            }

            // - - Layer aggregator
            // - Path 1
            // Stop 2
            CompositionColorGradientStop GradientStop_1_AlmostCornflowerBlue_FF5EAECF()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x5E, 0xAE, 0xCF));
            }

            // - - Layer aggregator
            // -  Offset:<260, 256>
            // Stop 2
            CompositionColorGradientStop GradientStop_1_AlmostLavender_FFDEEAFA()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0xDE, 0xEA, 0xFA));
            }

            // - Layer aggregator
            // Path 1
            CompositionLinearGradientBrush LinearGradientBrush_0()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostSkyBlue_FF85C3DB());
                colorStops.Add(GradientStop_0p45_AlmostSkyBlue_FF85C3DB());
                colorStops.Add(GradientStop_1_AlmostCornflowerBlue_FF5EAECF());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-52F, -68F);
                result.EndPoint = new Vector2(32.5410004F, 78.4290009F);
                return result;
            }

            // - Layer aggregator
            // Offset:<260, 256>
            CompositionLinearGradientBrush LinearGradientBrush_1()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostAliceBlue_FFF3F7FD());
                colorStops.Add(GradientStop_0p45_AlmostAliceBlue_FFF3F7FD());
                colorStops.Add(GradientStop_1_AlmostLavender_FFDEEAFA());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-76F, -81F);
                result.EndPoint = new Vector2(57.1860008F, 149.684998F);
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Layer aggregator
            // Offset:<260, 256>
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry_0());
                result.Offset = new Vector2(164F, 192F);
                result.FillBrush = LinearGradientBrush_0();
                result.StrokeBrush = ColorBrush_AlmostSkyBlue_FF72B9D5();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeLineJoin = CompositionStrokeLineJoin.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 4F;
                result.StartAnimation("RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_m15_to_m15());
                var controller = result.TryGetAnimationController("RotationAngleInDegrees");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress", "_", _root);
                return result;
            }

            // Layer aggregator
            // cloud-path
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<260, 256>
                var geometry = PathGeometry_1();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 260F, 256F), LinearGradientBrush_1());;
                result.StrokeBrush = ColorBrush_AlmostLavender_FFE6EFFC();
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 6F;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F));
            }

            // - Layer aggregator
            // Path 1
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_m15_to_m15()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, -15F, HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(0.5F, 9F, CubicBezierEasingFunction_0());
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, -15F, _cubicBezierEasingFunction_0);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(512F, 512F);
                var shapes = result.Shapes;
                // Path 1
                shapes.Add(SpriteShape_0());
                // Offset:<260, 256>
                shapes.Add(SpriteShape_1());
                return result;
            }

            // - - Layer aggregator
            // - Path 1
            // RotationAngleInDegrees
            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            internal Partly_cloudy_night_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(512F, 512F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}