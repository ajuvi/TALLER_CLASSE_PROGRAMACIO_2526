using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEmpleats
{
    public class Employee
    {

        #region Atributs
        private int id;
        private string firstName;
        private string lastName;
        private double salary;
        private double commission;
        private DateTime hireDate;
        #endregion

        #region Constructors

        public Employee(int id, string firstName, string lastName, double salary, double commission, DateTime hireDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.commission = commission;
            this.hireDate = hireDate;
        }
        public Employee(int id, string firstName, string lastName, double salary) : this(id, firstName, lastName, salary, 0, DateTime.Now){ }

        #endregion

        #region Propietats
        /// <summary>
        /// Obtenir i assignar el cognom de l'empleat
        /// </summary>
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        /// <summary>
        /// Obtenir i assignar un valor a la comissió
        /// <exception cref="Exception"> Genera una excepció si s'assigna 
        /// una comissió negativa</exception>
        /// </summary>
        public double Commission
        {
            get { return this.commission; }
            set
            {
                if (value < 0)
                    throw new Exception("La commissió no pot ser menor que 0");
                this.commission = value;
            }
        }

        /// <summary>
        /// Obtenir el salari total d'un empleat a partir 
        /// del salari i de la comissió.
        /// </summary>
        public double SalariTotal
        {
            get
            {
                return salary * (1 + commission);
            }
        }

        /// <summary>
        /// Obtenir el nombre d'anys que ha treballat un empleat.
        /// </summary>
        public double AnysTreballats
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Mètodes
        /// <summary>
        /// Incrementa el salari una quantitat
        /// </summary>
        /// <param name="quantitat">Quantitat a incrementar</param>
        /// <exception cref="Exception">Dona error si la quantitat és negativa</exception>
        public void IncrementarSalary(double quantitat)
        {
            if (quantitat < 0)
                throw new Exception("La quantitat a incrementar no pot ser negativa");
            this.salary = this.salary + quantitat;
        }

        public override string ToString()
        {
            return $"{id};{firstName};{lastName};{salary};{commission};{hireDate}";
        }

        #endregion

    }
}
