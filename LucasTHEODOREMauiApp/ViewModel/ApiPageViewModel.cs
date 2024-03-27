using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LucasTHEODOREMauiApp.ViewModel;

public class ApiPageViewModel: INotifyPropertyChanged
{

    private ObservableCollection<Character> _arrayList;
    
    
    public ObservableCollection<Character> ApiList
    {
        get { return _arrayList; }
        set
        {
            _arrayList = value;
            OnPropertyChanged(nameof(ApiList));
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    
}