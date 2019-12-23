using System;
using System.Windows;
using System.Windows.Media;
using MaterialDesignColors;
using MaterialDesignColors.ColorManipulation;
using MaterialDesignThemes.Wpf;

namespace YC.ClientView.Additional
{
   public  class SkinViewModel
    {
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="swatch"></param>
        [Obsolete]
        public void Apply(string swatch)
        {
            //new PaletteHelper().ReplacePrimaryColor(swatch);

            var convertFromString = ColorConverter.ConvertFromString(swatch);
            if (convertFromString != null)
                SetSecondaryForegroundToSingleColor((Color)convertFromString, swatch);
        }

        private void SetSecondaryForegroundToSingleColor(Color color, string swatch)
        {
            try
            {
                ITheme theme = GetTheme();
                theme.PrimaryLight = new ColorPair(color.Lighten(), theme.PrimaryLight.ForegroundColor);
                theme.PrimaryMid = new ColorPair(color, theme.PrimaryMid.ForegroundColor);
                theme.PrimaryDark = new ColorPair(color.Darken(), theme.PrimaryDark.ForegroundColor);
                theme.TextFieldBoxHoverBackground = Color.FromRgb(247, 68, 1);
                SetTheme(theme, swatch);
            }
            catch (Exception ex)
            {
              
            }

        }

        /// <summary>
        /// 设置皮肤
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="swatch"></param>
        protected virtual void SetTheme(ITheme theme, string swatch)
        {
            if (theme == null) throw new ArgumentNullException(nameof(theme));
          
            Application.Current.Resources.SetTheme(theme);
        }

        protected virtual ITheme GetTheme()
        {
            return Application.Current.Resources.GetTheme();
        }

        /// <summary>
        /// 设置默认样式
        /// </summary>
        /// <param name="swatch"></param>
        public void ApplyDefault(string skinName)
        {
            //var Swatch = Swatches.FirstOrDefault(t => t.Name.Equals(skinName));
            //if (Swatch != null)
            //    new PaletteHelper().ReplacePrimaryColor(Swatch);

            var convertFromString = ColorConverter.ConvertFromString(skinName);
            if (convertFromString != null)
                SetSecondaryForegroundToSingleColor((Color)convertFromString, "");
        }

       

    }
}
