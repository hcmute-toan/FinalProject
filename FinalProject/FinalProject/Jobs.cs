﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Jobs
    {
        private string id;
        private string companyId;
        private string positionNeeded;
        private string companyName;
        private string salary;
        private string nameJob;
        private string address;
        private string postingTime;
        private string numberOfRecruit;
        //mo ta cong viec, mo ta cong ty, mo ta dai ngo, ....de sau lam
        public Jobs() 
        { }
        public string Id { get { return id; } set { id = value; } }
        public string CompanyId { get { return companyId; } set { companyId = value; } }
        public string NameJob { get { return nameJob; } set { nameJob = value; } }
        public string PositionNeeded { get { return positionNeeded; } set { positionNeeded = value; } }
        public string CompanyName { get { return companyName; } set { companyName = value; } }
        public string Salary { get { return salary; } set { salary = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string PostingTime { get { return postingTime; } set { postingTime = value; } }
        public string NumberOfRecruit { get { return numberOfRecruit; } set { numberOfRecruit = value; } }

    }
}