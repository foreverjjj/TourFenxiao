using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Enterprise_Hotel:Enterprise
    {
        
        /// <summary>
        /// 商业街区
        /// </summary>
        public string BusinessZone{get;set;}
        /// <summary>
        /// 等级
        /// </summary>
        public string Star { get; set; }
        public string Category{get;set;}
        public int Roomnum{get;set;}
        public string Availpolicy{get;set;}
        public string Position{get;set;}
        public Brand Brand{get;set;}
        public bool isEconomic{get;set;}
        public bool isApartment{get;set;}
        public double lowestPrice{get;set;}
    }
}
