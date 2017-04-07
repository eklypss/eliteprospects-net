﻿using eliteprospects_net.Source.Enum;
using eliteprospects_net.Source.Interfaces;
using eliteprospects_net.Source.Model;
using eliteprospects_net.Source.Model.Parameters;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace eliteprospects_net.Source
{
    public class EPClient : IEPClient
    {
        private static EPClient instance;
        private Requester requester;

        public static EPClient GetInstance()
        {
            if (instance == null)
            {
                instance = new EPClient();
            }
            return instance;
        }

        public EPClient()
        {
            requester = new Requester();
        }

        public RetiredNumber GetRetiredNumber(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.RetiredNumbers, parameters)));
            return JsonConvert.DeserializeObject<RetiredNumber>(result);
        }

        public Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}