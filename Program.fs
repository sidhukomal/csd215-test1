let calculateFederalIncomeTax salary =
    if salary > 216511.0 then
        salary * 0.33
    else
        0.0 // No tax for salaries below or equal to $216,511

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let federalIncomeTaxes = List.map calculateFederalIncomeTax salaries

printfn "Salaries: %A" salaries
printfn "Federal Income Taxes: %A" federalIncomeTaxes




