namespace Hse.Domain.ValueObjects

open System

type ProductId = ProductId of Guid
type ProductName = {Value: string}

type StockId = StockId of Guid

type WareHouseId = WareHouseId of Guid
type WareHouseName = WareHouseName of string
    with static member Empty = WareHouseName("")

type StockQuantity = {Value: decimal}