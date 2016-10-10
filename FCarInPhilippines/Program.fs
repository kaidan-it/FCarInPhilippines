namespace Car
module PhilippinesCar =    
    let ImportTaxRates = dict ["Europe",[1.0;1.2;2.0];"USA",[0.75;0.9;1.5];"Japan",[0.7;0.8;1.35];"China",[0.0; 0.0; 0.0]]      
    let prices (originalPrice, country, capacity) : float =
        let taxrate = ImportTaxRates.[country].[capacity]
        let impt = originalPrice * taxrate
        let vat = (originalPrice + impt) * 0.12
        (originalPrice + impt + vat) * 47.00

