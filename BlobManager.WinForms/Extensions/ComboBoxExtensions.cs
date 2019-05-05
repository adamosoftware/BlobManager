using System.Collections.Generic;
using System.Windows.Forms;

namespace BlobManager.WinForms.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void Fill<TEnum>(this ComboBox comboBox, Dictionary<TEnum, string> values)
        {
            comboBox.Items.Clear();
            foreach (var kp in values) comboBox.Items.Add(new ComboBoxItem<TEnum>(kp.Key, kp.Value));
        }

        public static TEnum GetValue<TEnum>(this ComboBox comboBox)
        {
            var item = comboBox.SelectedItem as ComboBoxItem<TEnum>;
            return (item != null) ? item.Value : default(TEnum);            
        }
    }    

    public class ComboBoxItem<T>
    {
        public ComboBoxItem(T value, string text)
        {
            Value = value;
            Text = text;
        }

        public T Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(object obj)
        {
            var item = obj as ComboBoxItem<T>;
            return (item != null) ? item.Value.Equals(Value) : false;            
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}