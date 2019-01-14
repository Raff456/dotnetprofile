using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace netcoremain.Models
{
  public class SendMail
  {
    public string FromEmail { get; set; }
    public string FromName { get; set; }
    public string Body { get; set; }
  }
}