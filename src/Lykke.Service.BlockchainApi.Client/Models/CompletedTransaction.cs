﻿using JetBrains.Annotations;
using Lykke.Service.BlockchainApi.Contract.Transactions;

namespace Lykke.Service.BlockchainApi.Client.Models
{
    /// <summary>
    /// Observed transaction, that is completed.
    /// </summary>
    [PublicAPI]
    public class CompletedTransaction : BaseObservedTransaction
    {
        /// <summary>
        /// Transaction hash as base64 string.
        /// </summary>
        public string Hash { get; }

        public CompletedTransaction(CompletedTransactionContract contract, int assetAccuracy) :
            base(contract, assetAccuracy)
        {
            if (string.IsNullOrWhiteSpace(contract.Hash))
            {
                throw new ResultValidationException("Hash is required", contract.Hash);
            }

            Hash = contract.Hash;
        }
    }
}