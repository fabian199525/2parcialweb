
using System.Collections.Generic;
using Entity;
using System;
using Datos;

namespace Logica
{
public class PersonaService
    {
         private readonly PersonaRepository _repositorio;
        private readonly ConnectionManager _conexion;
       

public PersonaService(string connectionString)
        {
            _repositorio = new PersonaRepository(_conexion);
            _conexion = new ConnectionManager(connectionString);
            
        }
 public GuardarResponse Guardar(Persona psn)
        {
            try
            {
                _conexion.Open();
                _repositorio.Guardar(psn);
                _conexion.Close();
                return new GuardarResponse(psn);
            }
            catch (Exception e)
            {
                return new GuardarResponse($"ERROR: {e.Message}");
            }
            finally { _conexion.Close(); }
        }

        public List<Persona> ConsultarTodos()
        {
            _conexion.Open();
            List<Persona> psns = _repositorio.ConsultarTodos();
            _conexion.Close();
            return psns;
        }

    }
public class GuardarResponse
    {
        public GuardarResponse(Persona psn)
        {
            Error = false;
            Persona = psn;
        }
        public GuardarResponse(string mensaje)
        {      
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
}

}





