﻿using System;
using Abp.Application.Services.Dto;
using HC.WeChat.ShopEvaluations.Dtos.LTMAutoMapper;
using HC.WeChat.ShopEvaluations;
using HC.WeChat.WechatEnums;

namespace HC.WeChat.ShopEvaluations.Dtos
{
    public class ShopEvaluationListDto : EntityDto<Guid>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public Guid? PurchaseRecordId { get; set; }
        //购买记录（增加的）
        public string Specification { get; set; }
        public int? Quantity { get; set; }

        //微信昵称（增加的）
        public string NickName { get; set; }

        public Guid ShopId { get; set; }
        public string OpenId { get; set; }
        public ScoreLevelEmun? Evaluation { get; set; }
        public bool? IsCorrectQuantity { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        public string EvaluationName
        {
            get
            {
                return Evaluation.ToString();
            }
        }
    }
}