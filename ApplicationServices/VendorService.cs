using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Contexts;
using VenderConvention.Controllers;
using VenderConvention.DTOs;
using VenderConvention.Inferastructurs;
using VenderConvention.Models;

using Microsoft.EntityFrameworkCore;
using VenderFluentApi.DTOs;

namespace VenderConvention.ApplicationServices
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _repository;
        private readonly ShopContext _context;

        public VendorService(IVendorRepository repository, ShopContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<ListDTO> GetAllById(int id)
        {
            var data = await _repository.GetAllById(id);

            return new ListDTO()

            {

                Id = data.Id,
                VendorName = data.VendorName,
                Title = data.Title,
                Modifiedate = data.Modifiedate,
                Createdate = data.Createdate,
                PhoneNumber = data.PhoneNumber,
                Address = data.Address,
                NameTag = data.Tag.Select(t => t.NameTag).ToList()

            };

        }

        public async Task<ResponseInsertDTO> Insert(InsertVendorDTO DTO)

        {
            var TagList = new List<Tag>();
            if (DTO.Tags != null && DTO.Tags.Count > 0)
            {

                foreach (var item in DTO.Tags)
                {
                    Tag tag = new Tag();
                    tag.NameTag = item.NameTag;
                    TagList.Add(tag);
                }
            }

            var vendor = new vendor()
            {
                VendorName = DTO.VenderName,
                Title = DTO.Title,
                PhoneNumber = DTO.PhoneNumber,
                Address = DTO.Address,
                Tag = TagList
            };
            
              var vender = await _repository.InsertVendor(vendor);
            ResponseInsertDTO response = new ResponseInsertDTO()
            {
                Id = vender.Id,
                VenderName = vender.VendorName,
                Title = vender.Title,
                PhoneNumber = vender.PhoneNumber,
                Address = vender.Address,
                NameTag = vender.Tag.Select(t => t.NameTag).ToList()
            };
            return response;


        }
     

        public async Task<int> Update(UpdateDTO dTO, int id)
        {
           
            var TagList = new List<Tag>();
           
                foreach (var item in dTO.Tags)
                {
                    Tag tag = new Tag();
                    tag.NameTag = item.NameTag;
                    TagList.Add(tag);
                }
           
            var ven = _repository.GetByIdVender(id);

            ven.VendorName = dTO.VendorName;
            ven.Title = dTO.Title;
            ven.PhoneNumber = dTO.PhoneNumber;
            ven.Address = dTO.Address;
            ven.Tag = TagList;


           return await _repository.UpdateVendor(ven);
            
        }

        public async Task<int> UpdatePatch(JsonPatchDocument<UpdatePatchDTO> state, int id)
        {
           
            var ven = _repository.GetByIdVender(id);

            var dto = new UpdatePatchDTO()
            {
                VendorName = ven.VendorName,
                Title = ven.Title,
                PhoneNumber = ven.PhoneNumber,
                Address = ven.Address
            };

            state.ApplyTo(dto);

            var vendor = new vendor()
            {
                Id=id,
                VendorName = dto.VendorName,
                Title = dto.Title,
                PhoneNumber = dto.PhoneNumber,
                Address = dto.Address
            };
            return await _repository.UpdateVendor(vendor);
            
        }

        public async Task<int> Delete(int id)
        {
          var iddelete = _repository.GetByIdVendorDelete(id);
         return await  _repository.Delete(iddelete);
            
        }


    }



    //public ListDTO GetAll()
    //{
    //    var Data = _repository.GetAll();
    //    ListDTO ff;

    //    foreach (var item in Data)
    //    {

    //        var a = new ListDTO()
    //        {

    //            Id = item.Id,
    //            VendorName = item.VendorName,
    //            Title = item.Title,
    //            Modifiedate = item.Modifiedate,
    //            Createdate = item.Createdate,
    //            PhoneNumber = item.PhoneNumber,
    //            Address = item.Address,
    //            NameTag = item.Tag.Select(t=>t.NameTag).ToList()

    //        };

    //        ff = a;
    //    }
    //    return ;

    //}






    }




