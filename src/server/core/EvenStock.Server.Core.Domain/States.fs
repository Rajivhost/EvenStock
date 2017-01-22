namespace Hse.Domain.States

open Hse.Domain
open Hse.Domain.ValueObjects
open System

type StockState =
    {
            Id: StockId;
            Quantity: Quantity
    }
    with static member Empty = {Id = StockId(Guid.Empty); Quantity = {Value = decimal(0)}}

