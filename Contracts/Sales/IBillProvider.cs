﻿using dotnetcore_webapi_and_ravendb.Models.Dtos.SalesDtos;
using dotnetcore_webapi_and_ravendb.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_webapi_and_ravendb.Contracts.Sales
{
    public interface IBillProvider
    {
        Task NewBill(InputBillDto inputBillDto, string destiny);
        Task<List<Bill>> GetBillsByDate(DateTime startDate, DateTime endDate, string destiny);
        Task<List<Bill>> GetAllBills();
        Task<Bill> GetById(string id);
        Task UpdatePaymentMethod(string id, string paymentMethodSysId);
        Task UpdateDueDate(string id, DateTime dueDate);
        Task UpdateValue(string id, decimal value);
        Task Cancel(string id);
        Task<OutputAccountBalanceDto> GetAccountBalance(DateTime startDate, DateTime endDate);
        Task MakeRetirement(string billId);
    }
}
