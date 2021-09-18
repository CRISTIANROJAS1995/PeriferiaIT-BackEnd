using Core.Entities.User;
using System;
using System.Collections.Generic;

namespace Core.DataTransferObject.PeriferiaIT
{

    public class SendTransactionDto : ResponseApi
    {
        public Transaction LstTransaction { get; set; }
    }
}


