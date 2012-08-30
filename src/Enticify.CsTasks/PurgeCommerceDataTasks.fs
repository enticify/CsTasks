﻿[<AutoOpen>]
module CsTasks.PurgeCommerceDataTasks
    open Microsoft.CommerceServer.Marketing
    open Microsoft.CommerceServer
    open System.Data
    open System
    open System.Diagnostics
    open Fake

    type PurgeCommerceDataArgs = {
        ToolPath : string
        SiteName : string
        Timeout : TimeSpan
        }
        
    let PurgeDiscounts purgeCommerceDataArgs =
        let exitCode = 
            ExecProcess (fun psi ->
            psi.FileName <- purgeCommerceDataArgs.ToolPath
            psi.Arguments <- (sprintf "%s -m -d 0" purgeCommerceDataArgs.SiteName)) purgeCommerceDataArgs.Timeout
        ()
    


