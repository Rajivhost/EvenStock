namespace Hse.Domain.Reducers

module WareHouseReducers =

    open Hse.Domain.ValueObjects
    open Hse.Domain.States
    open Hse.Contracts.Events

    let Reduce (previousState: WareHouseState) event =
        let newState = {previousState with Id = WareHouseId(event.Id); Name = WareHouseName(event.Name)}
        newState