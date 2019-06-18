using System;
using System.Collections.Generic;
using System.Text;
using CourseInterfaces.Services;

namespace CourseInterfaces.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
