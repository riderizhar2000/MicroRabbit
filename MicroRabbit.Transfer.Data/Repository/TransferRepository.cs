using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }        

        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _context.TransferLog;
        }

        public void Add(TransferLog transferLog)
        {
            _context.TransferLog.Add(transferLog);
            _context.SaveChanges();
        }        
    }
}
