using System; 
using System.IO;
using System.Text.Json;

string jsonFile = @"./company_info.json";

var json = File.ReadAllText(jsonFile);

// Console.WriteLine(json);
var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

Company microsoft = JsonSerializer.Deserialize<Company>(json, options);

// Print out the total number of employees that the company has.
// Print out the full name of the second employee (index 1) in the 
// following format: "Employee: <employee_fullname>."

// Employees emp = microsoft.Employees[1];

// Console.WriteLine("Num Employees: " + microsoft.Employees.Length);
// Console.WriteLine("Employee: " + microsoft.Employees[1].FullName);
// Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

// emp.AnnualSalary += 100;

// Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

/*
//     SELECT *
//     FROM Employees
//     WHERE position = 'Software Engineer';
// */
// var softwareEngineersLinq = new List<Employees>();
// softwareEngineersLinq = microsoft.Employees
//                         .Where(emp => emp.Position.Description == "Software Engineer")
//                         .ToList();
                        
// foreach(var eng in softwareEngineersLinq){
//     Console.WriteLine(eng.FullName);
// }

// var moreOptions = new JsonSerializerOptions {WriteIndented = true};
//Put back into Json
// string jsonString = JsonSerializer.Serialize(microsoft);


// File.WriteAllText(jsonFile, jsonString);
/***************************************************
    DIRECTORY EXMPLES BEGIN
****************************************************/
// does a directory exist
string dirPathA = "./tomato";
string fileName = "tester";
// string dirPathB = ".bozo";
Console.WriteLine($"Before we are currently at: {Directory.GetCurrentDirectory()}");


if(Directory.Exists(dirPathA)){
    Console.WriteLine($"{dirPathA} EXISTS");
    // Directory.SetCurrentDirectory(dirPathA);
    // string newDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), dirPathA);
    // Directory.SetCurrentDirectory(newDirectoryPath);

}else{
    Console.WriteLine($"{dirPathA} DOES NOT EXIST");
    Directory.CreateDirectory(dirPathA);
    Console.WriteLine("..but now it does");
}

// Directory.SetCurrentDirectory(dirPathA);
Console.WriteLine($"We are currently at {Directory.GetCurrentDirectory}");

string content = $@"The names:
                    - {dirPathA}
                    - {fileName}
                    are some bum names";

// File.WriteAllText($"{fileName}.txt", content);


Console.WriteLine($"We are currently at: {Directory.GetCurrentDirectory()}");

/***************************************************
    DIRECTORY EXMPLES END
****************************************************/

string employeeDir = "my_employees";
Employees newEmp = microsoft.Employees[2];

if(!Directory.Exists(employeeDir)){

    Directory.CreateDirectory(employeeDir);
}

Directory.SetCurrentDirectory(employeeDir);

string empFileName = $"{newEmp.Id}.txt";
string contents = $@"Selected Employee
                    ID: {newEmp.Id}
                    Full Name {newEmp.FullName}
                    Annual Salary {newEmp.AnnualSalary}
                    Position ID {newEmp.Position.Id}
                    Postion Description: {newEmp.Position.Description}
                    Benefits:
                    ";


foreach(Benefits benefits in newEmp.Benefits){
    contents += $@" ID: {benefits.Id}
                    Description: {benefits.Description}
                    Additional Amount: {benefits.Additional}
                    ------------------------------------
                    ";
}

File.WriteAllText(empFileName, contents);

/***************************************************
    EMPLOYEE WRITER TEST BEGIN
****************************************************/
string empDir = "./employees_directory";
Employees employeeB = microsoft.Employees[2];
EmployeeWriter empWriter = new EmployeeWriter(empDir);
empWriter.Write(employeeB);


for(int i = 0; i < microsoft.Employees.Length; i++){
    empWriter.Write(microsoft.Employees[i]);
    
}

Employees[] allEmployees = microsoft.Employees;

EmployeeOptions empOptions = new EmployeeOptions{IncludeBenefits = false, IncludePosition = true};
// Console.WriteLine($"options IncludeBenefits: {empOptions.IncludeBenefits}");
// Console.WriteLine($"options IncludePosition: {empOptions.IncludePosition}");

empWriter.WriteAll(allEmployees, empOptions);
// empWriter.WriteAll(microsoft.Employees);
// empWriter.Write(employeeB);


/***************************************************
    EMPLOYEE WRITER TEST END
****************************************************/

Console.WriteLine("done");
