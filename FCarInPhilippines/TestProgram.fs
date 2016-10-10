namespace TestCar
open NUnit.Framework   
open FsUnit
open Car
open System
[<TestFixture>] 
type ``Test an program to calculate the price end user should pay``() =
    let taxts = PhilippinesCar.ImportTaxRates                                                                                          
    [<TestCase("Europe",0, 1.0)>]
    [<TestCase("Europe",1, 1.2)>]
    [<TestCase("Europe",2, 2.0)>]

    [<TestCase("USA",0, 0.75)>]
    [<TestCase("USA",1, 0.9)>]
    [<TestCase("USA",2, 1.5)>]

    [<TestCase("Japan",0, 0.7)>]
    [<TestCase("Japan",1, 0.8)>]
    [<TestCase("Japan",2, 1.35)>]

    [<TestCase("China",0, 0.0)>]
    [<TestCase("China",1, 0.0)>]
    [<TestCase("China",2, 0.0)>]
    member self.``The function returns the right result``(country:string, capacity:int, expected:float) =       
        taxts.[country].[capacity] |> should equal expected