using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Models;

namespace VenderConvention.Inferastructurs
{
   public interface IVendorRepository
    {
        //List<vendor> GetAll();
        //int InsertVendor(vendor vendor);
        //int InsertTag(Tag tag);
        //vendor GetByIdVender(int id);
        //Tag GetByIdTag(int id);


        Task<vendor> GetAllById(int id);
        Task<vendor> InsertVendor(vendor vendor);
        Task<int> UpdateVendor(vendor vendor);
        Task<int> Delete(vendor vendor);
        List<Tag> GetByIdTag(int id);
        vendor GetByIdVender(int id);
        vendor GetByIdVendorDelete(int id);
       




    }
}
