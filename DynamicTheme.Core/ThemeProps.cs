using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace DynamicTheme.Core
{
    public class ThemeProps
    {
        // 获取Background属性的值
        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BackgroundProperty);
        }

        // 设置Background属性的值
        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        // 定义Background依赖属性
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(ThemeProps), new PropertyMetadata(null, OnBackgroundPropertyChanged));

        // Background属性改变时的回调方法
        private static void OnBackgroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element && e.NewValue is SolidColorBrush newBrush)
            {
                AnimateBrushProperty(element, newBrush, "Background");
            }
        }

        // 获取Foreground属性的值
        public static Brush GetForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ForegroundProperty);
        }

        // 设置Foreground属性的值
        public static void SetForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ForegroundProperty, value);
        }

        // 定义Foreground依赖属性
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(ThemeProps), new PropertyMetadata(null, OnForegroundPropertyChanged));

        // Foreground属性改变时的回调方法
        private static void OnForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element && e.NewValue is SolidColorBrush newBrush)
            {
                AnimateBrushProperty(element, newBrush, "Foreground");
            }
        }

        // 动画过渡Brush属性的方法
        private static void AnimateBrushProperty(FrameworkElement element, SolidColorBrush newBrush, string propertyName)
        {
            // 获取要动画的属性
            var property = element.GetType().GetProperty(propertyName);

            if (property == null) return;

            // 获取当前的Brush
            var currentBrush = property.GetValue(element) as SolidColorBrush;

            // 如果当前Brush为空或已冻结，创建新的Brush
            if (currentBrush == null || currentBrush.IsFrozen)
            {
                currentBrush = new SolidColorBrush(newBrush.Color);
                property.SetValue(element, currentBrush);
            }

            // 创建并开始颜色动画
            currentBrush.BeginAnimation(SolidColorBrush.ColorProperty, new ColorAnimation
            {
                To = newBrush.Color,
                Duration = TimeSpan.FromSeconds(1)
            });
        }
    }
}