﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SummerBoot.WebApi.Models
{
    public class Customer
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; } = 0;
        /// <summary>
        /// 会员号
        /// </summary>
        public string CustomerNo { set; get; }
        /// <summary>
        /// 总消费金额
        /// </summary>
        public decimal TotalConsumptionAmount { set; get; }
    }
}
