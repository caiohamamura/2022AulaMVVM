using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    partial class MeuViewModel : ObservableObject
    {
        [ObservableProperty]
        int contagem = 0;

        [RelayCommand]
        void Incrementa()
        {
            Contagem++;
        }
    }
}
