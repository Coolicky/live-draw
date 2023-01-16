﻿using System.Windows;
using System.Windows.Controls;

namespace AntFu7.LiveDraw.Controls;

class ActivableButton : Button
{
    public static readonly DependencyProperty IsActivedProperty = DependencyProperty.Register(
        "IsActived", typeof(bool), typeof(ActivableButton), new PropertyMetadata(default(bool)));

    public bool IsActived
    {
        get { return (bool)GetValue(IsActivedProperty); }
        set { SetValue(IsActivedProperty, value); }
    }
}