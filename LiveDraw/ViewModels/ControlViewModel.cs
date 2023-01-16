using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AntFu7.LiveDraw.ViewModels;

public partial class ControlViewModel : ObservableObject
{
    
    [ObservableProperty] private double? _transparencyValue;

    public ICommand ColorPickerCommand { get; set; }
    public ICommand MinimizeWindowCommand { get; set; }
    public ICommand DetailToggleCommand { get; set; }
    public ICommand CloseWindowCommand { get; set; }
    public ICommand BrushCommand { get; set; }
    public ICommand LineCommand { get; set; }
    public ICommand UndoCommand { get; set; }
    public ICommand RedoCommand { get; set; }
    public ICommand EraseInkCommand { get; set; }
    public ICommand ClearInkCommand { get; set; }
    public ICommand PinTopmostCommand { get; set; }
    public ICommand SaveInkCommand { get; set; }
    public ICommand QuickSaveInkCommand { get; set; }
    public ICommand LoadInkCommand { get; set; }
    public ICommand ExportInkCommand { get; set; }
    public ICommand ExportInkWithBackgroundCommand { get; set; }
    public ICommand HideInkCommand { get; set; }
    public ICommand EnableInkCommand { get; set; }
    public ICommand OrientationSwitchCommand { get; set; }
}