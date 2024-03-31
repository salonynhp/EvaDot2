using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Employee
    {
        /*public int EmployeeId { get; set; } //without set can we assign new id to new emp?
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime JoinDate { get; set; } */

        int _EmployeeId;
        string _Name;
        string _Position;
        double _Salary;
        DateTime _JoinDate;

       /* public Employee(int _EmployeeId, string _Name, string _Position, double _Salary, DateTime _JoinDate)
        {
            this._EmployeeId = _EmployeeId;
            this._Name = _Name;
            this._Position = _Position;
            this._Salary = _Salary;
            this._JoinDate = _JoinDate;
        } */
    
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set {_EmployeeId=value;}
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

    }
}