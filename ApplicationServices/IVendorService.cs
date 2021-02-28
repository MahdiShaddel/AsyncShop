using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Controllers;
using VenderConvention.DTOs;
using VenderConvention.Models;
using VenderFluentApi.DTOs;

namespace VenderConvention.ApplicationServices
{
   public interface IVendorService
    {
        Task<ListDTO> GetAllById(int id);
        Task<ResponseInsertDTO> Insert(InsertVendorDTO DTO);
        Task<int> Update(UpdateDTO dTO, int id);
        Task<int> Delete(int id);
        Task<int> UpdatePatch(JsonPatchDocument<UpdatePatchDTO> state, int id);







        //ListDTO GetAll();

    }
}
