using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Contexts;
using VenderConvention.Models;

namespace VenderConvention.Inferastructurs
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ShopContext _context;

        public VendorRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task<vendor>  GetAllById(int id)
        {
            return await _context.Vendor.Where(v => v.Id == id).Include(t => t.Tag).SingleOrDefaultAsync();
        }

        public async Task<vendor> InsertVendor(vendor vendor)
        {
            _context.Vendor.Add(vendor);
            var result= await _context.SaveChangesAsync();
            return vendor;     
        }

        public async Task<int> Delete(vendor vendor)
        {
            _context.Vendor.Remove(vendor);
            return _context.SaveChangesAsync().Result;
        }

        public async Task<int>  UpdateVendor(vendor vendor)
        {
            _context.Vendor.Update(vendor);
            return _context.SaveChangesAsync().Result;
        }

        public vendor GetByIdVender(int id)
        {
            var vendor =  _context.Set<vendor>().Find(id);
            _context.Entry(vendor).State = EntityState.Detached;
            _context.Vendor.AsNoTracking();
            return vendor;
        }

        public vendor GetByIdVendorDelete(int id)
        {
            return _context.Vendor.Where(x => x.Isdeleted == false).FirstOrDefault();
        }

        public List<Tag> GetByIdTag(int id)
        {
            return _context.Tag.Where(t => t.VendorId == id).ToList();
        }

        //public List<vendor> GetAll()
        //{
        //    //var result = (from v in _context.Vendor
        //    //              join vt in _context.Tag
        //    //              on v.Id equals vt.VendorId
        //    //              select v).ToList();
        //    //return result;

        //    return _context.Vendor.Include(x => x.Tag).ToList();

        //}

    }
}
