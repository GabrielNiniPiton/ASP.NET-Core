﻿namespace Dev_Piton.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        { }

        public int Id { get; private set; }
    }
}