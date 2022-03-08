using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTP_API.Models;

namespace VTP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private IParticipantService _participantService;
        public StatisticsController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet("getagestatistics")]
        public IActionResult GetAgeStatistics()
        {
            AgeStatistics ageStatistics = new AgeStatistics();
            ageStatistics.Age_17 = this._participantService.GetAll(m => m.Age == 17).Data.Count;
            ageStatistics.Age_18 = this._participantService.GetAll(m => m.Age == 18).Data.Count;
            ageStatistics.Age_19 = this._participantService.GetAll(m => m.Age == 19).Data.Count;
            ageStatistics.Age_20 = this._participantService.GetAll(m => m.Age == 20).Data.Count;
            ageStatistics.Age_21 = this._participantService.GetAll(m => m.Age == 21).Data.Count;
            ageStatistics.Age_22 = this._participantService.GetAll(m => m.Age == 22).Data.Count;
            ageStatistics.Age_23 = this._participantService.GetAll(m => m.Age == 23).Data.Count;
            ageStatistics.Age_24 = this._participantService.GetAll(m => m.Age == 24).Data.Count;
            ageStatistics.Age_25 = this._participantService.GetAll(m => m.Age == 25).Data.Count;
            return Ok(ageStatistics);
        }
        [HttpGet("getdegreestatistics")]
        public IActionResult GetDegreeStatistics()
        {
            DegreeStatistics degreeStatistics = new DegreeStatistics();
            degreeStatistics.Bachelor = this._participantService.GetAll(m => m.Degree.ToLower() == "bachelor").Data.Count;
            degreeStatistics.Master = this._participantService.GetAll(m => m.Degree.ToLower() == "master").Data.Count;
            return Ok(degreeStatistics);

        }
        [HttpGet("getdepartmentstatistics")]
        public IActionResult GetDepartmentStatistics()
        {
            DepartmentStatistics departmentStatistics = new DepartmentStatistics();
            departmentStatistics.InformationTechnology = this._participantService.GetAll(m=>m.DepartmentId==1).Data.Count;
            departmentStatistics.HumanResources = this._participantService.GetAll(m=>m.DepartmentId==2).Data.Count;
            departmentStatistics.LogisticsPurchasing = this._participantService.GetAll(m=>m.DepartmentId==3).Data.Count;
            departmentStatistics.AccountingFinance = this._participantService.GetAll(m=>m.DepartmentId==4).Data.Count;
            return Ok(departmentStatistics);

        }
        [HttpGet("getgenderstatistics")]
        public IActionResult GetGenderStatistics()
        {
            GenderStatistics genderStatistics = new GenderStatistics();
            genderStatistics.Male = this._participantService.GetAll(m=>m.Gender.ToLower()=="male").Data.Count;
            genderStatistics.Female = this._participantService.GetAll(m => m.Gender.ToLower() == "female").Data.Count;
            return Ok(genderStatistics);

        }
        [HttpGet("getuniversitystatistics")]
        public IActionResult GetUniversityStatistics()
        {
            UniversityStatistics universityStatistics = new UniversityStatistics();
            universityStatistics.ADA = this._participantService.GetAll(m=>m.University.ToLower()=="ada").Data.Count;
            universityStatistics.NAA = this._participantService.GetAll(m=>m.University.ToLower()=="naa").Data.Count;
            universityStatistics.ADU = this._participantService.GetAll(m=>m.University.ToLower()=="adu").Data.Count;
            universityStatistics.ANDSU = this._participantService.GetAll(m=>m.University.ToLower()=="adnsu").Data.Count;
            universityStatistics.BANM = this._participantService.GetAll(m=>m.University.ToLower()=="banm").Data.Count;
            universityStatistics.BDU = this._participantService.GetAll(m=>m.University.ToLower()=="bdu").Data.Count;
            universityStatistics.BMU = this._participantService.GetAll(m=>m.University.ToLower()=="bmu").Data.Count;
            universityStatistics.DIA = this._participantService.GetAll(m=>m.University.ToLower()== "dia").Data.Count;
            universityStatistics.FiratUniversity = this._participantService.GetAll(m=>m.University.ToLower()== "firat university").Data.Count;
            universityStatistics.KhazarUniversity= this._participantService.GetAll(m=>m.University.ToLower()== "khazar university").Data.Count;
            universityStatistics.UNEC = this._participantService.GetAll(m=>m.University.ToLower()== "unec").Data.Count;
            universityStatistics.YTU = this._participantService.GetAll(m=>m.University.ToLower()== "ytu").Data.Count;
            return Ok(universityStatistics);

        }

    }
}
