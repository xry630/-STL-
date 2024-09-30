using DynamicTheme.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using 一言.Services;
using 一言.Pages;

namespace 一言.Pages
{
    public partial class ShellView : Window
    {
        private readonly ApiService _apiService;
        private ShellViewModel? _viewModel; // 声明为可空类型
        private ThemeManager _themeManager; // 声明私有ThemeManager对象
        private bool isDarkTheme = false;
        private bool _isLoadingData = false;  // 标志是否正在加载数据

        public ShellView()
        {
            InitializeComponent();
            UpdateTitleText();
            _apiService = new ApiService();
            this.Loaded += ShellView_Loaded; // 在Loaded事件中初始化_viewModel
            LoadPoemAndHitokoto();  // 初次加载诗句和一言

            _themeManager = new ThemeManager(); // 实例化ThemeManager对象

            // 注册深色主题
            _themeManager.RegisterTheme("Dark", "DynamicTheme.Resources", "DarkTheme.xaml");
            // 注册浅色主题
            _themeManager.RegisterTheme("Light", "DynamicTheme.Resources", "LightTheme.xaml");

            // 为Switch控件的Checked事件添加处理方法
            ThemeToggleButton.Checked += ThemeToggleButton_Checked;
            // 为Switch控件的Unchecked事件添加处理方法
            ThemeToggleButton.Unchecked += ThemeToggleButton_Unchecked;
        }

        private void ShellView_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel = (ShellViewModel)this.DataContext;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isLoadingData)
            {
                LoadPoemAndHitokoto();  // 刷新内容
            }
        }

        private async void LoadPoemAndHitokoto()
        {
            if (_isLoadingData) return;  // 如果已经在加载数据，则返回
            _isLoadingData = true;

            try
            {
                // 异步加载数据
                var poemTask = _apiService.GetPoem();
                var hitokotoTask = _apiService.GetHitokoto();

                PoemTextBox.Text = await poemTask;
                HitokotoTextBox.Text = await hitokotoTask;
            }
            finally
            {
                _isLoadingData = false;  // 数据加载完成
            }
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.SelectAll(); // 全选文本
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // 在这里处理窗口大小变化的逻辑
        }

        private void UpdateTitleText()
        {
            TitleTextBlock.Text = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!isDarkTheme) // 确保只在切换时应用浅色主题
            {
                _themeManager.ApplyTheme("Light"); // 应用浅色主题
                isDarkTheme = true;  // 更新主题标志
            }
        }

        private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (isDarkTheme) // 确保只在切换时应用深色主题
            {
                _themeManager.ApplyTheme("Dark"); // 应用深色主题
                isDarkTheme = false;  // 更新主题标志
            }
        }

        #region 语言切换

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LanguageComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string languageCode = selectedItem.Tag.ToString();
                SwitchLanguage(languageCode);
            }
        }

        private void SwitchLanguage(string languageCode)
        {
            switch (languageCode)
            {
                case "en":
                    _viewModel?.SwitchToEng();
                    break;
                case "zh-CN":
                    _viewModel?.SwitchToCn();
                    break;
                case "ru":
                    _viewModel?.SwitchToRu();
                    break;
            }
        }

        #endregion
    }
}
