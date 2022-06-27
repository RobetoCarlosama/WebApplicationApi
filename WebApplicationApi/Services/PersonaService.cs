using PatternShared.Entities;
using System.Collections.Generic;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaAdapter _personaAdapter;
        private readonly IUnitOfWorkService _unitOfWorkService;
        public PersonaService(IUnitOfWorkService unitOfWorkService, IPersonaAdapter personaAdapter)
        {
            _unitOfWorkService = unitOfWorkService;
            _personaAdapter = personaAdapter;
        }

        public void Add(Persona persona)
        {
            if (Validate(persona))
            {
                _unitOfWorkService.Persona.Add(_personaAdapter.Adapt(persona));
                //_unitOfWorkService.StudentSport.Add(_personaAdapter.AdaptToStudentSport(persona));
                //_unitOfWorkService.StudentAddress.Add(_personaAdapter.AdaptToStudentAddress(persona));

                _unitOfWorkService.Save();
            }
        }

        public IEnumerable<Persona> GetAll()
        {
            List<Persona> listPersona = new List<Persona>();
            foreach (PersonaEntity personaEntity in _unitOfWorkService.Persona.GetAll())
            {
                listPersona.Add(_personaAdapter.Adapt(personaEntity));
            }
            return listPersona;
        }

        public Persona GetByPersonaIdentificacion(string personaIdentificacion)
        {
            PersonaEntity personaEntity = _unitOfWorkService.Persona.GetByPersonaIdentificacion(personaIdentificacion);

            return _personaAdapter.Adapt(personaEntity);
        }

        public void Remove(Persona persona)
        {
            _unitOfWorkService.Persona.Remove(_personaAdapter.Adapt(persona));
            _unitOfWorkService.Save();
        }

        public bool Validate(Persona persona)
        {
            return true;
        }
    }
}
