using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF3
{
    public class Employee
    {
        // Поля
        private string name;
        private int salary;
        private DateTime hireDate;
        public int id;
        public static int nextId = 0;

        // Конструкторы

        //default
        public Employee()
        {
            name = "Иванов Иван Иванович";
            salary = 1000;
            hireDate = DateTime.Now;
            this.id = getNextId();
        }
        // 5 параметров: имя, зарплата, дд, мм,гггг  - трудоустройства.
        public Employee(string name, int salary, int day, int month, int year)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = new DateTime(year, month, day);
            this.id = getNextId();
        }

        // 2 параметра: имя, зарплата (дата трудоустройства - время создания объекта).
        public Employee(string name, int salary) 
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.id = getNextId();
        }

        // Свойства
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение должно быть положительным");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public virtual int getSalary()
        {
            return this.salary;
        }

        public override string ToString()
        {
            return this.name +", зарплата = " + this.salary + " дата приема = " + this.hireDate;
            //return "id: " + id + " сотрудник ФИО: " + this.name + ", зарплата = " + this.salary + ", дата приема на работу: " + this.hireDate;
        }

        // Метод увеличения зарплаты на заданный процент
        public void IncreaseSalary(int percent)
        {
            this.Salary += this.salary * percent / 100;
        }

        public int getNextId()
        {
            nextId += 1;
            return nextId;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId()
        {
            this.id = getNextId();
        }
    }
}
