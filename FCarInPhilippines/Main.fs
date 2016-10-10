open System
open Car
let main =
    printfn "Benz G65 from Germany (Europe county), 6.0L,  original price $217,900 USD: -> Included VAT %.2f Pesos" (PhilippinesCar.prices(217900.00, "Europe", 2)) 
    printfn "Honda Jazz 1.5L (Japan) original price $19,490 USD: -> Included VAT %.2f Pesos" (PhilippinesCar.prices(19490.00, "Japan", 0))
    printfn "Jeep wrangler 3.6L (USA) original price, $36,995 USD: -> Included VAT %.2f Pesos" (PhilippinesCar.prices(36995.00, "USA", 1))
    printfn "Chery QQ 1.0L (China) original price, $6,000 USD: -> Included VAT %.2f Pesos" (PhilippinesCar.prices(6000.00, "China", 1))
    Console.ReadLine() |> ignore
    0  
