public class CompanyInfo{

    public string BotName {get; set;}
    public Company CompanyObj {get; set;}

    public CompanyInfo(string name, Company obj){
        this.BotName = name;
        this.CompanyObj = obj;
    }

    public Cofounder GetCofounderByName(string name){
        /*
        Search through the this.CompanyObj and find the cofounder
        whose name mathces the name that was passed. 
        If you find that cofounder, return that cofounder out.
        Otherwise, return null
        */

      Cofounder? founder = null;
      Cofounder[] allCofounders = this.CompanyObj.Cofounder;

      foreach(Cofounder person in allCofounders){
        if(person.Name == name){
            founder = person;
            break;
        }

      }

        return null;
    }

    public int GetNumberOfEmployees(){
        int number = this.CompanyObj.Employees.Length;

        return number;
    }

}