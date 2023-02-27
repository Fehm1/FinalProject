using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.ContactDTOs;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public ContactManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ContactGetDto>> AddAsync(ContactPostDto contactPost)
        {
            if (contactPost != null)
            {
                Contact contact = _mapper.Map<Contact>(contactPost);
                await _unityOfWork.Contact.CreateAsync(contact);
                await _unityOfWork.SaveAsync();

                ContactGetDto contactGet = _mapper.Map<ContactGetDto>(contact);

                return new DataResult<ContactGetDto>(ResultStatus.Success, contactGet);
            }

            return new DataResult<ContactGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Contact contact = await _unityOfWork.Contact.GetAsync(x => x.Id == id);

            if (contact != null)
            {
                contact.IsDeleted = true;
                contact.IsActive = false;
                _unityOfWork.Contact.Update(contact);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no contact in this id!");
        }

        public async Task<IDataResult<ContactListDto>> GetAllAsync()
        {
            List<Contact> contacts = await _unityOfWork.Contact.GetAllAsync();

            List<ContactGetDto> contactGetList = _mapper.Map<List<ContactGetDto>>(contacts);

            return new DataResult<ContactListDto>(ResultStatus.Success, new ContactListDto { Contacts = contactGetList });
        }

        public async Task<IDataResult<ContactListDto>> GetAllByNonDeleteAsync()
        {
            List<Contact> contacts = await _unityOfWork.Contact.GetAllAsync(x => x.IsDeleted == false);

            List<ContactGetDto> contactGetList = _mapper.Map<List<ContactGetDto>>(contacts);

            return new DataResult<ContactListDto>(ResultStatus.Success, new ContactListDto { Contacts = contactGetList });
        }

        public async Task<IDataResult<ContactListDto>> GetAllDeletedAsync()
        {
            List<Contact> contacts = await _unityOfWork.Contact.GetAllAsync(x => x.IsDeleted == true);

            List<ContactGetDto> contactGetList = _mapper.Map<List<ContactGetDto>>(contacts);

            return new DataResult<ContactListDto>(ResultStatus.Success, new ContactListDto { Contacts = contactGetList });
        }

        public async Task<IDataResult<ContactGetDto>> GetAsync(int id)
        {
            Contact contact = await _unityOfWork.Contact.GetAsync(x => x.Id == id);

            if (contact != null)
            {
                ContactGetDto contactGet = _mapper.Map<ContactGetDto>(contact);

                return new DataResult<ContactGetDto>(ResultStatus.Success, contactGet);
            }

            return new DataResult<ContactGetDto>(ResultStatus.Error, null, "There is no contact in this id!");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Contact contact = await _unityOfWork.Contact.GetAsync(x => x.Id == id);

            if (contact != null)
            {
                _unityOfWork.Contact.Delete(contact);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no contact in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Contact contact = await _unityOfWork.Contact.GetAsync(x => x.Id == id);

            if (contact != null)
            {
                contact.IsDeleted = false;
                _unityOfWork.Contact.Update(contact);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no contact in this id!");
        }

        public async Task<IResult> Status(int id)
        {
            Contact contact = await _unityOfWork.Contact.GetAsync(x => x.Id == id);

            if (contact != null)
            {
                contact.IsActive = false;
                _unityOfWork.Contact.Update(contact);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no contact in this id!");
        }
    }
}
