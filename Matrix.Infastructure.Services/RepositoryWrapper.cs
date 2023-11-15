using Matrix.Core.Application;
using Matrix.Core.Application.Interfaces;
using Matrix.Infastructure.Persistence;
using Matrix.Infastructure.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MatrixContext _repoContext;
        private ILocalPurchaseRepo _localpurchaseRepo;
        private ISupplierRepo _supplierRepo;
        private IWareHouseRepo _wareHouseRepo;

        public RepositoryWrapper(MatrixContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public ILocalPurchaseRepo LocalPurchaseRepo
        {
            get
            {
                if (_localpurchaseRepo != null)
                {
                    _localpurchaseRepo = new LocalPurchaseRepo(_repoContext);
                }
                return _localpurchaseRepo;
            }
        }
        public ISupplierRepo SupplierRepo
        {
            get
            {
                if (_supplierRepo != null)
                {
                    _supplierRepo = new SupplierRepo(_repoContext);
                }
                return _supplierRepo;
            }
        }
        public IWareHouseRepo WareHouseRepo
        {
            get
            {
                if (_wareHouseRepo != null)
                {
                    _wareHouseRepo = new WareHouseRepo(_repoContext);
                }
                return _wareHouseRepo;
            }
        }
    }
}
