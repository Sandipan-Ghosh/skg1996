import { Component,Inject } from '@angular/core';
import { Http } from "@angular/http";

@Component({
    selector: 'my-app',
    templateUrl: '../app/app.html',
})
export class AppComponent {
    name = 'Angular';
    isShown: boolean = true;
    employee: Employee = new Employee();
    employees: Employee[] = new Array<Employee>();
    employeesTemp: Employee[] = new Array<Employee>();
    searchString: string;
    constructor(public http: Http) {
        this.http.get("/api/Employees").subscribe((x) => {
            this.employees = x.json();
            this.employeesTemp = this.employees;
        });
    }
        onClick() {
            this.http.post("/api/Employees", this.employee).subscribe((x) => {
                if (x.ok)
                    this.employees.push(x.json())
                    this.employee = new Employee();
            });
            
    }
        onFilter(searchString:string) {
            this.http.get("/api/Employees/search?name=" + searchString).subscribe((x) => {
                this.employees = x.json();
            });
            //if (!(searchString === "")) {

            //    this.employees = this.employeesTemp.filter(x => x.Name.includes(searchString) || x.Address.includes(searchString));
            //}
            //else
            //    this.employees = this.employeesTemp;

        }

        onDelete(emp: Employee) {

            this.http.delete("/api/Employees/" + emp.Id).subscribe((x) => {
                this.employees.splice(this.employees.indexOf(emp), 1);
            });
        }
        onEdit(emp: Employee) {
          this.isShown = false;
    //varName = EXP?<True>:<False>
            this.employee = emp;
        }
        onUpdate() {
            this.http.put("/api/Employees/" + this.employee.Id, this.employee).subscribe((x) => {
                this.isShown = true;
                this.employee = new Employee();
            });
        }
}
class Employee {
    Id: number;
    Name: string;
    Address: string;
}
