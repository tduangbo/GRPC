﻿using Grpc.Core;
using MeterReaderWeb.Data;
using MeterReaderWeb.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReaderWeb.Services
{
    public class MeterService: MeterReadingService.MeterReadingServiceBase
    {
        private readonly ILogger<MeterService> _logger;
        private readonly IReadingRepository _repository;

        public MeterService(ILogger<MeterService> logger, IReadingRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }
        public override async Task<StatusMessage> AddReading(ReadingPacket request, ServerCallContext context)
        {
            // return base.AddReading(request, context);
            var result = new StatusMessage()
            {
                Success = ReadingStatus.Failure
            };

            if(request.Successful == ReadingStatus.Success)
            {
                try
                {
                    foreach(var r in request.Readings)
                    {
                        //save to db
                        var reading = new MeterReading()
                        {
                            Value = r.ReadingValue,
                            ReadingDate = r.ReadingTime.ToDateTime(),
                            CustomerId = r.CustomerId

                        };

                        _repository.AddEntity(reading);
                    }

                    if( await _repository.SaveAllAsync())
                    {
                        result.Success = ReadingStatus.Success;
                    }
                }catch(Exception e)
                {
                    result.Message = "Exception thron during process";
                    _logger.LogError($"Exception thrown during saving of reading : {e}");
                }

            }
            //  return Task.FromResult(result);
            return result;
        }
    }
}
