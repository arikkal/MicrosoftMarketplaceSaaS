using System;

namespace Marketplace.SaaS.Accelerator.CustomerSite.ViewModels;

public class ExceptionViewModel
{
    public bool ShowExceptionDetailForDeveloper { get; set; }
    public Exception Exception { get; set; }
}
