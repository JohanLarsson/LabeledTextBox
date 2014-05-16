﻿namespace LabeledTextBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class Vm : INotifyPropertyChanged
    {
        private string _value1 = "1";
        private string _value2 = "2";
        private string _value3 = "3";

        public Vm()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                if (value == _value1)
                {
                    return;
                }
                _value1 = value;
                OnPropertyChanged();
            }
        }

        public string Value2
        {
            get { return _value2; }
            set
            {
                if (value == _value2)
                {
                    return;
                }
                _value2 = value;
                OnPropertyChanged();
            }
        }

        public string Value3
        {
            get { return _value3; }
            set
            {
                if (value == _value3)
                {
                    return;
                }
                _value3 = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
