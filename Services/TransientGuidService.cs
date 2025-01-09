﻿namespace DI_Serivce_Lifetime.Services
{
    public class TransientGuidService : ITransientGuidService
    {
        private readonly Guid Id;
        public TransientGuidService()
        {
            Id = Guid.NewGuid();
        }

        public string getGuid()
        {
            return Id.ToString();
        }
    }
}
