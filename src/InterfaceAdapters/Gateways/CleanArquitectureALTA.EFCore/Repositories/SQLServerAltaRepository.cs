using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alta.EFCore.DataContext;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Utils;
using Microsoft.EntityFrameworkCore;

namespace Alta.EFCore.Repositories
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

        //DONE
        public async Task<HeartbeatInitiate> InsertHeartbeatInitiateAsync(HeartbeatInitiate heartbeatInitiate)
        {
            await _context.HeartbeatInitiate.AddAsync(heartbeatInitiate);
            return heartbeatInitiate;
        }

        public Task InsertLogAsync()
        {
            //probablemente el mas importante
            throw new NotImplementedException();
        }
        
        public async Task InsertRequestInitiateAsync(RequestInitiate requestInitiate)
        {
            await _context.AddAsync(requestInitiate);
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
            //dudoso
            throw new NotImplementedException();
        }
        
        public async Task<CreateLineInventory> SaveDataToPrimeAsync(CreateLineInventory createLineInventory)
        {
            //TODO: ADD LOGIC TO VALIDATE POCO INSTANCE HERE
            /*await _context.CREATE_LINE_INVENTORY.AddAsync(createLineInventory);
            return createLineInventory;*/
            throw new NotImplementedException();
        }
        
        public async Task SetHeartbeatConfirmAsync(HeartbeatInitiate newHeartbeatInitiate, string message)
        {
            HeartbeatInitiate heartbeat = await _context.HeartbeatInitiate.FirstAsync(entity =>
                entity.TranDT == newHeartbeatInitiate.TranDT && entity.WCSId == newHeartbeatInitiate.WCSId && entity.WHId == newHeartbeatInitiate.WHId);
            heartbeat.ResponseDatetime = DateTime.Now;
            heartbeat.MessageReceived = message;
            _context.HeartbeatInitiate.Update(heartbeat);
        }
        
        public async Task SetLoadDetailAsync(LoadDetail loadDetail, bool noted, string message)
        {
            RequestInitiate requestInitiate = await _context.RequestInitiate.FirstAsync(
                e => e.CreationDatetime > DateTime.Now.AddDays(-1) && e.LODNum == loadDetail.LODNum);
            requestInitiate.Noted = noted;
            requestInitiate.MessageReceived = message;
            requestInitiate.ResponseDatetime = DateTime.Now;
            requestInitiate.Line = loadDetail.LODNum.LastChars(2) ?? loadDetail.LODNum_DEFAULT;
            _context.RequestInitiate.Update(requestInitiate);
        }
        
        public Task SetLoadErrorlAsync()
        {
            throw new NotImplementedException();
        }
    }
}