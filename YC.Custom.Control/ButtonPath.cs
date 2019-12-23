using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YC.Custom.Control
{
    public class ButtonPath : Button
    {
        static ButtonPath()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonPath), new FrameworkPropertyMetadata(typeof(ButtonPath)));
        }


        public ButtonType ButtonType
        {
            get { return (ButtonType) GetValue(ButtonTypeProperty); }
            set { SetValue(ButtonTypeProperty, value); }
        }

        public static readonly DependencyProperty ButtonTypeProperty =
            DependencyProperty.Register("ButtonType", typeof(ButtonType), typeof(ButtonPath),
                new PropertyMetadata(ButtonType.IconText));


        public ImageSource Icon
        {
            get { return (ImageSource) GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(ButtonPath), new PropertyMetadata(null));


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ButtonPath),
                new PropertyMetadata(new CornerRadius(0)));


        public Brush MouseOverForeground
        {
            get { return (Brush) GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(ButtonPath), new PropertyMetadata());


        public Brush MousePressedForeground
        {
            get { return (Brush) GetValue(MousePressedForegroundProperty); }
            set { SetValue(MousePressedForegroundProperty, value); }
        }

        public static readonly DependencyProperty MousePressedForegroundProperty =
            DependencyProperty.Register("MousePressedForeground", typeof(Brush), typeof(ButtonPath),
                new PropertyMetadata());


        public Brush MouseOverBorderbrush
        {
            get { return (Brush) GetValue(MouseOverBorderbrushProperty); }
            set { SetValue(MouseOverBorderbrushProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBorderbrushProperty =
            DependencyProperty.Register("MouseOverBorderbrush", typeof(Brush), typeof(ButtonPath), new PropertyMetadata());


        public Brush MouseOverBackground
        {
            get { return (Brush) GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ButtonPath), new PropertyMetadata());


        public Brush MousePressedBackground
        {
            get { return (Brush) GetValue(MousePressedBackgroundProperty); }
            set { SetValue(MousePressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MousePressedBackgroundProperty =
            DependencyProperty.Register("MousePressedBackground", typeof(Brush), typeof(ButtonPath),
                new PropertyMetadata());
    }

    public enum ButtonType
    {
        IconText
    }
}
