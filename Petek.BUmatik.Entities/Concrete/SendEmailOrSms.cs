using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class SendEmailOrSms:Base
    {
        public string SmsOrEmail { get; set; }//SmsOrEmailEnum
        public string ToAddress { get; set; } //if send email, add email address
        public string SmsToNumber { get; set; } //if send sms, add phone number
        public string CcAddress { get; set; } //email cc address
        public string BCcAddress { get; set; } //email BCC address
        public string EmailSubject { get; set; } //Email subjects
        public int EmailOrSmsTemplate { get; set; } //TemplateEnum 
        public string EmailOrSmsValues { get; set; } // Json datas
        public bool IsHtml { get; set; }
        public bool IsSent { get; set; } = false;
        public virtual AdminUser AdminUser { get; set; }

    }
    public class SendEmailOrSmsConfiguration : IEntityTypeConfiguration<SendEmailOrSms>
    {
        public void Configure(EntityTypeBuilder<SendEmailOrSms> builder)
        {

        }
    }
}
