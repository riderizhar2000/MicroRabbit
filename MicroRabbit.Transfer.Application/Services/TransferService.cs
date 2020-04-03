using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transfetRepository, IEventBus bus)
        {
            _transferRepository = transfetRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _transferRepository.GetTransferLog();
        }       
    }
}
