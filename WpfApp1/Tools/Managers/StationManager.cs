using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tools.Managers
{
    internal class StationManager
    {
        private static readonly object Locker = new object();
        private static StationManager _instance;

        private IDataStorage _dataStorage;

        internal static StationManager Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                lock (Locker)
                {
                    return _instance ?? (_instance = new StationManager());
                }
            }
        }

        internal User currentUser { get; set; }

        internal IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        private StationManager()
        {
        }

        internal void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }
    }
}
