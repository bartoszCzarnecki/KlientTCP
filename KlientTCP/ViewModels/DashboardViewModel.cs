using Caliburn.Micro;
using KlientTCP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class DashboardViewModel : Conductor<object>
    {
        private TriangleViewModel _triangleVM;
        private IEventAggregator _aggregator;

        public DashboardViewModel(TriangleViewModel triangleVM, IEventAggregator aggregator)
        {
            _triangleVM = triangleVM;
            _aggregator = aggregator;
            LoadTrianglePage();
        }

        public void LoadTrianglePage()
        {
            ActivateItem(_triangleVM);
        }

        public void LoadPasswordChangePage()
        {

        }

        public void LoadDeleteAccountPage()
        {

        }

        public void Logout()
        {
            _aggregator.PublishOnUIThread(new LogoutEvent());
        }
    }
}
