namespace Hse.Domain.States

open Hse.Domain.ValueObjects
open System

type ProductState =
    {
            Id: ProductId;
            Name: ProductName
    }
    with static member Empty = {Id = ProductId(Guid.Empty); Name = {Value = ""}}


type StockState =
    {
            Id: StockId;
            ProductId: ProductId;
            StockQuantity: StockQuantity
    }
    with static member Empty = {Id = StockId(Guid.Empty); ProductId = ProductId(Guid.Empty); StockQuantity = {Value = decimal(0)}}


type WareHouseState =
    {
            Id: WareHouseId;
            Name: WareHouseName
    }
    with static member Empty = {Id = WareHouseId(Guid.Empty); Name = WareHouseName.Empty}