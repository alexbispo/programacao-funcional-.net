﻿module ControleFluxo

let verificaSeONumeroPar numero = 
    if numero % 2 = 0 
        then "Par"
        else "Ímpar"

let verificaSeONumeroParComPatternMatching numero = 
    match numero % 2 = 0  with
    | true -> "Par"
    | false -> "Ímpar"

let verificaSeONumeroParOuZero numero = 
    if numero % 2 = 0 
        then 
            if numero = 0 
                then "Zero" 
                else "Par"
        else "Ímpar"

let verificaSeONumeroParOuZeroComPatternMatching numero = 
    match numero with
    | 0 -> "Zero"
    | numero when numero % 2 = 0 -> "Par"
    | _ -> "Ímpar"

let fatorial numeroParaCalcularFatorial =
    let mutable acumulador = numeroParaCalcularFatorial
    for numero = numeroParaCalcularFatorial-1 downto 1 do
        acumulador <- acumulador * numero
    acumulador

let rec fatorialComPatternMatching numero = 
    match numero with
    | 0 | 1 -> 1
    | 2 -> 2
    | _ -> numero * fatorialComPatternMatching (numero-1)

let fatorialComFuncaoAninhada numero =
    let rec fatorial numero =
        match numero with
        | 0 | 1 -> 1
        | 2 -> 2
        | _ -> numero * fatorialComPatternMatching (numero-1)

    fatorial numero
