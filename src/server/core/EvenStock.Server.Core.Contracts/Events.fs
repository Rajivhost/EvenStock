namespace Hse.Contracts.Events

open System

type StockQuantityIncreased = {WarehouseId: Guid; ProductId: Guid; StockQuantity: decimal }
type StockQuantityDecreased = {WarehouseId: Guid; ProductId: Guid; StockQuantity: decimal }

type WarehouseCreated = {Id: Guid; Name: string}