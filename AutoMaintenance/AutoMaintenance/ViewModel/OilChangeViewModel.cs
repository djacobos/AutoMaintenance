using System;
using System.ComponentModel;

namespace AutoMaintenance
{
	public class OilChangeViewModel :  INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		private MaintenanceRepository _repository;

		public OilChangeViewModel ()
		{

			// This should be injected
			_repository = new MaintenanceRepository();

			// Populate the ViewModel
			var maintenance = _repository.GetMaintenanceAll();

		}

	}
}

