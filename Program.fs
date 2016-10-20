// Learn more about F# at http://fsharp.org

open System

let board =
    Map.empty.
        Add("A1", "wc1").
        Add("A2", "wp1").
        Add("A3", "").
        Add("A4", "").
        Add("A5", "").
        Add("A6", "").
        Add("A7", "bp1").
        Add("A8", "bc1").
        Add("B1", "wk1").
        Add("B2", "wp2").
        Add("B3", "").
        Add("B4", "").
        Add("B5", "").
        Add("B6", "").
        Add("B7", "bp2").
        Add("B8", "bk1").
        Add("C1", "wb1").
        Add("C2", "wp3").
        Add("C3", "").
        Add("C4", "").
        Add("C5", "").
        Add("C6", "").
        Add("C7", "bp3").
        Add("C8", "bb1").
        Add("D1", "wQ").
        Add("D2", "wp4").
        Add("D3", "").
        Add("D4", "").
        Add("D5", "").
        Add("D6", "").
        Add("D7", "bp4").
        Add("D8", "bQ").
        Add("E1", "wK").
        Add("E2", "wp5").
        Add("E3", "").
        Add("E4", "").
        Add("E5", "").
        Add("E6", "").
        Add("E7", "bp5").
        Add("E8", "bK").
        Add("F1", "wb2").
        Add("F2", "wp6").
        Add("F3", "").
        Add("F4", "").
        Add("F5", "").
        Add("F6", "").
        Add("F7", "bp6").
        Add("F8", "bb2").
        Add("G1", "wk2").
        Add("G2", "wp7").
        Add("G3", "").
        Add("G4", "").
        Add("G5", "").
        Add("G6", "").
        Add("G7", "bp7").
        Add("G8", "bk2").
        Add("H1", "wc2").
        Add("H2", "wp8").
        Add("H3", "").
        Add("H4", "").
        Add("H5", "").
        Add("H6", "").
        Add("H7", "bp8").
        Add("H8", "bc2")

let visualizeBoard board =
    let line = "_________________"
    let whiteStarterBackRow = "|c|k|b|Q|K|b|k|c|"
    let blackStarterBackRow = "|c|k|b|Q|K|b|k|c|"
    let pawnStarterRow = "|p|p|p|p|p|p|p|p|"
    let columns = "| | | | | | | | |"
    [line;whiteStarterBackRow;line;pawnStarterRow;line;columns;line;columns;line;pawnStarterRow;line;blackStarterBackRow;line]

let printBoard board =
    board |> List.map (printfn "%A")

[<EntryPoint>]
let main argv = 
    printfn "%A" board
    0 // return an integer exit code

