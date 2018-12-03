using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KloudCodingChallenge.Model.Interfaces;

namespace KloudCodingChallenge.Service.Interfaces
{
    public interface IDataService
    {
       
        Task<List<IData>> FetchDataAsync();
     
    }
}
