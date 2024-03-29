using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ReceptProjekt.ViewModels
{
    public abstract class BaseViewModel:ObservableObject
    {
        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
