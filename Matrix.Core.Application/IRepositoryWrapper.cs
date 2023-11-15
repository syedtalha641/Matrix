using Matrix.Core.Application.Interfaces;

namespace Matrix.Core.Application
{
    public interface IRepositoryWrapper
    {
        public ILocalPurchaseRepo LocalPurchaseRepo { get; }
        public ISupplierRepo SupplierRepo { get; }
        public IWareHouseRepo WareHouseRepo { get; }
    }
}