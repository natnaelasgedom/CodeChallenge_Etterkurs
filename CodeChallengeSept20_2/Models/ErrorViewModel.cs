using System;
using System.Collections;
using System.Reflection;

namespace CodeChallengeSept20_2.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
