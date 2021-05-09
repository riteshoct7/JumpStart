using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using JumpStart.Services.Interfaces;
using System.Collections.Generic;

namespace JumpStart.Services.Implementation
{
    public class ContactUsService : IContactUsService
    {

        #region Properties

        private readonly IContactUsRepository contactUsRepository;

        #endregion

        #region Constructors

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        #endregion

        #region Methods

        public void Add(ContactUs model)
        {
            contactUsRepository.Save(model);
            contactUsRepository.SaveChanges();            
        }

        public void Delete(ContactUs model)
        {
            contactUsRepository.Delete(model);
            contactUsRepository.SaveChanges();            
        }

        public void Delete(int id)
        {
            contactUsRepository.Delete(id);
            contactUsRepository.SaveChanges();            
        }

        public IEnumerable<ContactUs> GetAllRecords()
        {
            return contactUsRepository.GetAll();            
        }

        public ContactUs GetRecordsById(int id)
        {
            return contactUsRepository.GetById(id);            
        }

        public void Remove(ContactUs model)
        {
            contactUsRepository.Remove(model);
            contactUsRepository.SaveChanges();
        }

        public void Update(ContactUs model)
        {
            contactUsRepository.Update(model);
            contactUsRepository.SaveChanges();
        }

        #endregion

    }
}
