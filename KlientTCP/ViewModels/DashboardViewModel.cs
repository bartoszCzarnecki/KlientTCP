﻿using Caliburn.Micro;
using KlientTCP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlientTCP.Services;

namespace KlientTCP.ViewModels
{
    public class DashboardViewModel : Conductor<object>
    {
        private TriangleViewModel _triangleVM;
        private ChangePasswordViewModel _changePasswordVM;
        private DeleteAccountViewModel _deleteAccountVM;
        private IEventAggregator _aggregator;
        private IServerCommunication _communication;

        public DashboardViewModel(
            TriangleViewModel triangleVM,
            ChangePasswordViewModel changePasswordVM,
            DeleteAccountViewModel deleteAccountVM,
            IEventAggregator aggregator,
            IServerCommunication communication
            )
        {
            _triangleVM = triangleVM;
            _changePasswordVM = changePasswordVM;
            _deleteAccountVM = deleteAccountVM;
            _aggregator = aggregator; 
            _communication = communication;
        }

        public void LoadTrianglePage()
        {
            string msg = _communication.GetMessage();
            _communication.SendMessage("get_status");
            if (_communication.GetMessage() != "menu")
                _communication.SendMessage("cancel");
            ActivateItem(_triangleVM);
        }

        public void LoadChangePasswordPage()
        {
            _communication.GetMessage();
            _communication.SendMessage("get_status");
            if (_communication.GetMessage() != "menu")
                _communication.SendMessage("cancel");
            ActivateItem(_changePasswordVM);
        }

        public void LoadDeleteAccountPage()
        {
            _communication.GetMessage();
            _communication.SendMessage("get_status");
            if (_communication.GetMessage() != "menu")
                _communication.SendMessage("cancel");
            ActivateItem(_deleteAccountVM);
        }

        public void Logout()
        {
            _communication.SendMessage("cancel");
            _communication.GetMessage();
            _aggregator.PublishOnUIThread(new LogoutEvent(_communication));
        }
    }
}
