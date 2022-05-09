﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.EFCore.DataContext;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;



namespace Alta.EFCore.Repostiories
{
    public class SQLServerAltaRepository : IAltaRepository
    {
        private readonly AltaContext _context;
        public SQLServerAltaRepository(AltaContext context)
        {
            _context = context;
        }



        public Task<IEnumerable<RequestInbox>> CheckReprocessAsync()
        {
            throw new NotImplementedException();
        }



        public Task InsertHeartbeatInitiateAsync(HeartBeatInitiateDTO dto)
        {
            _context.Add(dto);
        }



        public Task InsertLogAsync()
        {
            throw new NotImplementedException();
        }



        public Task InsertRequestInitiateAsync()
        {
            throw new NotImplementedException();
        }



        public Task InsertRequestToReprocessAsync()
        {
            throw new NotImplementedException();
        }



        public Task SaveDataFromPrimeAsync()
        {
            throw new NotImplementedException();
        }



        public Task SaveDataToPrimeAsync()
        {
            throw new NotImplementedException();
        }



        public async Task<CreateLineInventory> SaveDataToPrimeAsync(CreateLineInventory createLineInventory)
        {
            //TODO: ADD LOGIC TO VALIDATE POCO INSTANCE HERE
            await _context.CREATE_LINE_INVENTORY.AddAsync(createLineInventory);
            return createLineInventory;
        }



        public Task SetHeartbeatConfirmAsync()
        {
            throw new NotImplementedException();
        }



        public Task SetLoadDetailAsync()
        {
            throw new NotImplementedException();
        }



        public Task SetLoadErrorlAsync()
        {
            throw new NotImplementedException();
        }
    }
}