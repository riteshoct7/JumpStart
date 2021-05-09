using JumpStart.Entities.Models;
using System.Collections.Generic;

namespace JumpStart.Services.Interfaces
{
    public interface IContactUsService
    {

        #region Methods

        IEnumerable<ContactUs> GetAllRecords();

        ContactUs GetRecordsById(int id);

        void Add(ContactUs model);

        void Update(ContactUs model);

        void Remove(ContactUs model);

        void Delete(ContactUs model);

        void Delete(int id); 

        #endregion

    }
}
