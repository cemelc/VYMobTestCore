using System;
using System.Collections.Generic;


namespace ParseJson.Login.LoginClasses
{
    public class PersonExtraData
    {
        public string Title { get; set; }
        public object LastName2 { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsResident { get; set; }
        public ResidentData ResidentData { get; set; }
        public bool IsFamNum { get; set; }
        public FamNumData FamNumData { get; set; }
        public string Poblacion { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string AeropuertoOrigen { get; set; }
        public object VipCard { get; set; }
        public DateTime VipExpiration { get; set; }
        public bool ForcePassReset { get; set; }
        public List<object> Docs { get; set; }
        public List<CustomerProgram> CustomerPrograms { get; set; }
        public object LastSearch { get; set; }
    }
}
