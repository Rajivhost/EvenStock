namespace Hse.Domain.ValueObjects

open System

type ProductId = ProductId of Guid
type ProductName = {Value: string}

type StockId = StockId of Guid

type WareHouseId = WareHouseId of Guid
type WareHouseName = {Value: string}

type StockQuantity = {Value: decimal}