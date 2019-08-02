using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using ddd.insfrastructure.Interfaces;
using ddd.service.DTO;

namespace ddd.service.Services
{
    public class BalanceService
    {
        IUnitOfWork _unitOfWork;
        IBalanceRespository _balanceRespository;
        public BalanceService(IUnitOfWork unitOfWork, IBalanceRespository balanceRespository)
        {
            _unitOfWork = unitOfWork;
            _balanceRespository = balanceRespository;
        }
        public BalanceInfo CreateBalanceInfo(CreateBalanceDTO createBalanceDTO)
        {
            var balance = new BalanceInfo();
            balance.BlongAccount = createBalanceDTO.BlongAccount;
            balance.IsValid = createBalanceDTO.IsValid;
            balance.MerchantId = createBalanceDTO.MerchantId;
            balance.MoneyInfo = new MoneyInfo().GenerateMonryInfo(createBalanceDTO.Money, createBalanceDTO.ServiceRate);
            balance.PersonInfo = new PersonInfo().GeneratePersonInfo(createBalanceDTO.Name, createBalanceDTO.IdCard, createBalanceDTO.PhoneNum, createBalanceDTO.BankCard);
            _balanceRespository.CreateBalanceInfo(balance);
            _unitOfWork.Commit();
            return balance;
        }
    }
}
