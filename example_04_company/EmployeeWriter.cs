using System;
using System.IO;

public class EmployeeWriter{
    public string DirPath {get; set;}
    
    public EmployeeWriter(string dirPath){
        this.DirPath = dirPath;
    }

    public void Write(Employees employees){
        if(Directory.Exists(this.DirPath)){
            Directory.CreateDirectory(this.DirPath);
        }
        Directory.SetCurrentDirectory(this.DirPath);

        string fileName = $"{employees.Id}.txt";
        string contents = $@"Selected Employee
                    ID: {employees.Id}
                    Full Name {employees.FullName}
                    Annual Salary {employees.AnnualSalary}
                    Position ID {employees.Position.Id}
                    Postion Description: {employees.Position.Description}
                    Benefits:
                    ";


    foreach(Benefits benefits in employees.Benefits){
        contents += $@" ID: {benefits.Id}
                        Description: {benefits.Description}
                        Additional Amount: {benefits.Additional}
                        ------------------------------------
                        ";
    }
    File.WriteAllText(fileName, contents);

    Directory.SetCurrentDirectory("..");

    }
    
    public void WriteAll(Employees[] employees){
         string fileName = $"{employees.Id}.txt";
        string contents = $@"Selected Employee
                    ID: {employees.Id}
                    Full Name {employees.FullName}
                    Annual Salary {employees.AnnualSalary}
                    Position ID {employees.Position.Id}
                    Postion Description: {employees.Position.Description}
                    Benefits:
                    ";
        for(Employees employees1 in ){

        }
    }
}