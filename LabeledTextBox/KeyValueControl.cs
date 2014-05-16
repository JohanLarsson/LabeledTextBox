namespace LabeledTextBox
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;

    public class KeyValueControl : Control
    {
        public static readonly DependencyProperty KeyProperty = DependencyProperty.Register(
            "Key",
            typeof(string),
            typeof(KeyValueControl),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value",
            typeof(object),
            typeof(KeyValueControl),
            new FrameworkPropertyMetadata
            {
                DefaultValue = null,
                BindsTwoWayByDefault = true,
                DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
            });

        public static readonly DependencyProperty KeyTemplateProperty = DependencyProperty.Register(
            "KeyTemplate",
            typeof(DataTemplate),
            typeof(KeyValueControl),
            new PropertyMetadata(default(DataTemplate)));

        public static readonly DependencyProperty ValueTemplateProperty = DependencyProperty.Register(
            "ValueTemplate", 
            typeof (DataTemplate), 
            typeof (KeyValueControl), 
            new PropertyMetadata(default(DataTemplate)));

        public string Key
        {
            get
            {
                return (string)GetValue(KeyProperty);
            }
            set
            {
                SetValue(KeyProperty, value);
            }
        }

        public object Value
        {
            get
            {
                return GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }

        public DataTemplate KeyTemplate
        {
            get
            {
                return (DataTemplate)GetValue(KeyTemplateProperty);
            }
            set
            {
                SetValue(KeyTemplateProperty, value);
            }
        }

        public DataTemplate ValueTemplate
        {
            get
            {
                return (DataTemplate)GetValue(ValueTemplateProperty);
            }
            set
            {
                SetValue(ValueTemplateProperty, value);
            }
        }
    }
}
