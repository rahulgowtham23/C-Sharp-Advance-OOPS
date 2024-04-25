using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IAccount
    {
        //property declaration only
        int AccountNumber {get;set;}
        string Name{get;set;}
        double Balance{get;set;}
    }
}