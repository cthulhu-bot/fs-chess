﻿// Learn more about F# at http://fsharp.org

open System

// Board initialization
module Board =
    type coord = {Coordinate:string; Piece:string}

    let intialBoard = [
            {Coordinate="A1"; Piece="wc1"}
            {Coordinate="A2"; Piece="wp1"}
            {Coordinate="A3"; Piece=""}
            {Coordinate="A4"; Piece=""}
            {Coordinate="A5"; Piece=""}
            {Coordinate="A6"; Piece=""}
            {Coordinate="A7"; Piece="bp1"}
            {Coordinate="A8"; Piece="bc1"}
            {Coordinate="B1"; Piece="wk1"}
            {Coordinate="B2"; Piece="wp2"}
            {Coordinate="B3"; Piece=""}
            {Coordinate="B4"; Piece=""}
            {Coordinate="B5"; Piece=""}
            {Coordinate="B6"; Piece=""}
            {Coordinate="B7"; Piece="bp2"}
            {Coordinate="B8"; Piece="bk1"}
            {Coordinate="C1"; Piece="wb1"}
            {Coordinate="C2"; Piece="wp3"}
            {Coordinate="C3"; Piece=""}
            {Coordinate="C4"; Piece=""}
            {Coordinate="C5"; Piece=""}
            {Coordinate="C6"; Piece=""}
            {Coordinate="C7"; Piece="bp3"}
            {Coordinate="C8"; Piece="bb1"}
            {Coordinate="D1"; Piece="wQ"}
            {Coordinate="D2"; Piece="wp4"}
            {Coordinate="D3"; Piece=""}
            {Coordinate="D4"; Piece=""}
            {Coordinate="D5"; Piece=""}
            {Coordinate="D6"; Piece=""}
            {Coordinate="D7"; Piece="bp4"}
            {Coordinate="D8"; Piece="bQ"}
            {Coordinate="E1"; Piece="wK"}
            {Coordinate="E2"; Piece="wp5"}
            {Coordinate="E3"; Piece=""}
            {Coordinate="E4"; Piece=""}
            {Coordinate="E5"; Piece=""}
            {Coordinate="E6"; Piece=""}
            {Coordinate="E7"; Piece="bp5"}
            {Coordinate="E8"; Piece="bK"}
            {Coordinate="F1"; Piece="wb2"}
            {Coordinate="F2"; Piece="wp6"}
            {Coordinate="F3"; Piece=""}
            {Coordinate="F4"; Piece=""}
            {Coordinate="F5"; Piece=""}
            {Coordinate="F6"; Piece=""}
            {Coordinate="F7"; Piece="bp6"}
            {Coordinate="F8"; Piece="bb2"}
            {Coordinate="G1"; Piece="wk2"}
            {Coordinate="G2"; Piece="wp7"}
            {Coordinate="G3"; Piece=""}
            {Coordinate="G4"; Piece=""}
            {Coordinate="G5"; Piece=""}
            {Coordinate="G6"; Piece=""}
            {Coordinate="G7"; Piece="bp7"}
            {Coordinate="G8"; Piece="bk2"}
            {Coordinate="H1"; Piece="wc2"}
            {Coordinate="H2"; Piece="wp8"}
            {Coordinate="H3"; Piece=""}
            {Coordinate="H4"; Piece=""}
            {Coordinate="H5"; Piece=""}
            {Coordinate="H6"; Piece=""}
            {Coordinate="H7"; Piece="bp8"}
            {Coordinate="H8"; Piece="bc2"}
    ]


// Movement code
module Moves =
    type move = {Coord1:String; Coord2:String}


// Board visualization code
module Visualization =
    let visualizeBoard board =
        let line = "_________________"
        let columns = "| | | | | | | | |"

        let boardViz board =
            let delimiters = List.map (fun (coord:Board.coord) -> 
                                match coord.Piece with
                                | "" -> "| |"
                                | _ -> String.concat "" ["|"; coord.Piece; "|"]) board
            let boardSeq = seq { for a in delimiters do yield a }
            for i = 0 to 7 do
                let slice = Seq.skip (8 * i) boardSeq 
                let column = Seq.take 8 slice
                printfn "%A" (String.concat "" column)
                printfn "\n"
            boardSeq


        let whiteStarterBackRow = "|c|k|b|Q|K|b|k|c|"
        let blackStarterBackRow = "|c|k|b|Q|K|b|k|c|"
        let pawnStarterRow = "|p|p|p|p|p|p|p|p|"

        boardViz board



// Game code
module Game =
    let initialBoard = Board.intialBoard

    let printBoard board =
        initialBoard |> List.iter (fun coord ->
            printfn "Key: %A, Val: %A" coord.Coordinate coord.Piece)

    let movePiece board piece coord =
        printBoard board
    


    [<EntryPoint>]
    let main argv = 
        // pfft for loops
        // for KeyValue(k,v) in initialBoard do
        //     printfn "board coord is: %s, piece present is %s" k v
        printfn "%A" (Visualization.visualizeBoard initialBoard)
        0 // return an integer exit code

