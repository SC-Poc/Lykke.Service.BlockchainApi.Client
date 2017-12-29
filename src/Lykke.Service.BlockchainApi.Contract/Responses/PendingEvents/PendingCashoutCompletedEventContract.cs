﻿using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Lykke.Service.BlockchainApi.Contract.Responses.PendingEvents
{
    [PublicAPI]
    public class PendingCashoutCompletedEventContract : BasePendingEventContract
    {
        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }
    }
}