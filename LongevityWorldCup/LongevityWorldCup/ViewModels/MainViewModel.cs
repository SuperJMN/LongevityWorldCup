using ReactiveUI.SourceGenerators;

namespace LongevityWorldCup.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [Reactive] private string greeting = "Welcome to Avalonia!";
}