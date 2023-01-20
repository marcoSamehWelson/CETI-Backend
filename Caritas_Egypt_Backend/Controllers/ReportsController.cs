using Caritas_Egypt_Backend.Models;
using Caritas_Egypt_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caritas_Egypt_Backend.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Reports()
        {
            return View();
        }
        private readonly CETICaretasEgyptContext _context;

        public ReportsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        public IActionResult ServicesReport(ServiceReportFilter serviceReportFilter)
        {
           ServiceReportResult res = new ServiceReportResult();
      

            if (serviceReportFilter.FromDate == null) {


                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
                ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");






                return View(res);

            }
            //Get Session Reservation with filters
            var ServiceRep = _context.SessionReservation.Include(s => s.student).Include(s => s.coursePrice).ThenInclude(s => s.service).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= serviceReportFilter.FromDate && s.SessionDateTime <= serviceReportFilter.ToDate);
            if (!string.IsNullOrWhiteSpace(serviceReportFilter.ServiceID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.ServiceId== serviceReportFilter.ServiceID);
            }
            if (!string.IsNullOrWhiteSpace(serviceReportFilter.BranchID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.BranchId == serviceReportFilter.BranchID);
                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name", serviceReportFilter.BranchID);

            }
            else {
                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");

            }
            if (serviceReportFilter.FromAge.HasValue && serviceReportFilter.FromAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age >= serviceReportFilter.FromAge.Value);
                ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name",serviceReportFilter.ServiceID);
            }
            else {

                ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");
            }

            if (serviceReportFilter.ToAge.HasValue && serviceReportFilter.ToAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age <= serviceReportFilter.ToAge.Value);
            }

            var x = 0;

         var  result= ServiceRep.ToList();
            for (var i=0; i< result.Count; i++)

            {
                x += Int32.Parse(result[i].coursePrice.Price);
            }
            res.TotalIncome = x;
            res.TotalBeneficiaries = result.Count;
            res.ServiceName = _context.Services.Where(x => x.Id == serviceReportFilter.ServiceID).First().Name;
            res.BranchName = _context.Branches.Where(x => x.Id == serviceReportFilter.BranchID).First().Name;
            res.FromAge = serviceReportFilter.FromAge.Value;
            res.ToAge = serviceReportFilter.ToAge.Value;
            res.FromDate = serviceReportFilter.FromDate.Value;
            res.ToDate = serviceReportFilter.ToDate.Value;








            return View(res);
        }
        public IActionResult DisabilitiesReport(DisabilitiesReportFilter disabilitiesReportFilter)
        {
            DisabilitiesReportResult res = new DisabilitiesReportResult();


            if (disabilitiesReportFilter.FromDate == null)
            {


                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");





                return View(res);

            }
            //Get Session Reservation with filters
            var disabilitiesRep = _context.SessionReservation.Include(s => s.student).Include(s => s.student).ThenInclude(s => s.TypeOfDisability).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= disabilitiesReportFilter.FromDate && s.SessionDateTime <= disabilitiesReportFilter.ToDate);
            if (!string.IsNullOrWhiteSpace(disabilitiesReportFilter.TypeOfDisabilityID.ToString()))
            {
                disabilitiesRep = disabilitiesRep.Where(sc => sc.student.TypeOfDisabilityId == disabilitiesReportFilter.TypeOfDisabilityID);
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name", disabilitiesReportFilter.TypeOfDisabilityID);

            }
            else {
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");


            }
            if (!string.IsNullOrWhiteSpace(disabilitiesReportFilter.BranchID.ToString()))
            {
                disabilitiesRep = disabilitiesRep.Where(sc => sc.coursePrice.BranchId == disabilitiesReportFilter.BranchID);
                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name",disabilitiesReportFilter.BranchID);

            }
            else
            {

                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");

            }
            if (disabilitiesReportFilter.FromAge.HasValue && disabilitiesReportFilter.FromAge.Value >= 0)
            {
                disabilitiesRep = disabilitiesRep.Where(com => com.student.Age >= disabilitiesReportFilter.FromAge.Value);
            }

            if (disabilitiesReportFilter.ToAge.HasValue && disabilitiesReportFilter.ToAge.Value >= 0)
            {
                disabilitiesRep = disabilitiesRep.Where(com => com.student.Age <= disabilitiesReportFilter.ToAge.Value);
            }




            var x = 0;

            var result = disabilitiesRep.ToList();
            for (var i = 0; i < result.Count; i++)

            {
                x += Int32.Parse(result[i].coursePrice.Price);
            }
            res.TotalIncome = x;
            res.TotalBeneficiaries = result.Count;
            res.TypeOfDisabilityName = _context.TypeOfDisabilitys.Where(x => x.Id == disabilitiesReportFilter.TypeOfDisabilityID).First().Name;
            res.BranchName = _context.Branches.Where(x => x.Id == disabilitiesReportFilter.BranchID).First().Name;
            res.FromAge = disabilitiesReportFilter.FromAge.Value;
            res.ToAge = disabilitiesReportFilter.ToAge.Value;
            res.FromDate = disabilitiesReportFilter.FromDate.Value;
            res.ToDate = disabilitiesReportFilter.ToDate.Value;








            return View(res);
        }
        public IActionResult SecDisabilitiesReport(SecDisabilitiesReportFilter secDisabilitiesReportFilter)
        {
            SecDisabilitiesReportResult res = new SecDisabilitiesReportResult();
            if (secDisabilitiesReportFilter.FromDate == null)
            {


                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");





                return View(res);

            }

            //Get Session Reservation with filters
            var disabilitiesRep = _context.SessionReservation.Include(s => s.student).Include(s => s.student).ThenInclude(s => s.TypeOfDisability).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= secDisabilitiesReportFilter.FromDate && s.SessionDateTime <= secDisabilitiesReportFilter.ToDate);
            if (!string.IsNullOrWhiteSpace(secDisabilitiesReportFilter.TypeOfDisabilityID.ToString()))
            {
                disabilitiesRep = disabilitiesRep.Where(sc => sc.student.TypeOfDisabilityId == secDisabilitiesReportFilter.TypeOfDisabilityID);
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name", secDisabilitiesReportFilter.TypeOfDisabilityID);

            }
            else
            {
                ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");


            }
            if (!string.IsNullOrWhiteSpace(secDisabilitiesReportFilter.BranchID.ToString()))
            {
                disabilitiesRep = disabilitiesRep.Where(sc => sc.coursePrice.BranchId == secDisabilitiesReportFilter.BranchID);
                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name", secDisabilitiesReportFilter.BranchID);

            }
            else
            {

                ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");

            }
            if (secDisabilitiesReportFilter.FromAge.HasValue && secDisabilitiesReportFilter.FromAge.Value >= 0)
            {
                disabilitiesRep = disabilitiesRep.Where(com => com.student.Age >= secDisabilitiesReportFilter.FromAge.Value);
            }

            if (secDisabilitiesReportFilter.ToAge.HasValue && secDisabilitiesReportFilter.ToAge.Value >= 0)
            {
                disabilitiesRep = disabilitiesRep.Where(com => com.student.Age <= secDisabilitiesReportFilter.ToAge.Value);
            }




            var x = 0;

            var result = disabilitiesRep.ToList();
            for (var i = 0; i < result.Count; i++)

            {
                x += Int32.Parse(result[i].coursePrice.Price);
            }
            res.TotalIncome = x;
            res.TotalBeneficiaries = result.Count;
            res.TypeOfDisabilityName = _context.TypeOfDisabilitys.Where(x => x.Id == secDisabilitiesReportFilter.TypeOfDisabilityID).First().Name;
            res.BranchName = _context.Branches.Where(x => x.Id == secDisabilitiesReportFilter.BranchID).First().Name;
            res.FromAge = secDisabilitiesReportFilter.FromAge.Value;
            res.ToAge = secDisabilitiesReportFilter.ToAge.Value;
            res.FromDate = secDisabilitiesReportFilter.FromDate.Value;
            res.ToDate = secDisabilitiesReportFilter.ToDate.Value;
 





            return View(res);
        }
            public IActionResult BrothersReport(BrothersReportFilter brothersReportFilter)
        {
            //Get Session Reservation with filters
            var ServiceRep = _context.SessionReservation.Include(s => s.student).Include(s => s.student).ThenInclude(s => s.TypeOfDisability).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= brothersReportFilter.FromDate && s.SessionDateTime <= brothersReportFilter.ToDate);
            if (!string.IsNullOrWhiteSpace(brothersReportFilter.TypeOfDisabilityID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.student.TypeOfDisabilityId == brothersReportFilter.TypeOfDisabilityID);
            }
            if (!string.IsNullOrWhiteSpace(brothersReportFilter.BranchID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.BranchId == brothersReportFilter.BranchID);
            }
            if (brothersReportFilter.FromAge.HasValue && brothersReportFilter.FromAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age >= brothersReportFilter.FromAge.Value);
            }

            if (brothersReportFilter.ToAge.HasValue && brothersReportFilter.ToAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age <= brothersReportFilter.ToAge.Value);
            }


            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
            ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");






            return View();
        }
        public IActionResult TrainersReport(TrainersReportFilter trainersReportFilter)
        {
            //Get Session Reservation with filters
            var ServiceRep = _context.SessionReservation.Include(s => s.student).Include(s => s.trainer).Include(s => s.coursePrice).ThenInclude(s => s.service).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= trainersReportFilter.FromDate && s.SessionDateTime <= trainersReportFilter.ToDate);
            if (!string.IsNullOrWhiteSpace(trainersReportFilter.ServiceID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.ServiceId == trainersReportFilter.ServiceID);
            }
            if (!string.IsNullOrWhiteSpace(trainersReportFilter.BranchID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.BranchId == trainersReportFilter.BranchID);
            }
            if (!string.IsNullOrWhiteSpace(trainersReportFilter.TrainerID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.TrainerId == trainersReportFilter.TrainerID);
            }
            if (trainersReportFilter.FromAge.HasValue && trainersReportFilter.FromAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age >= trainersReportFilter.FromAge.Value);
            }

            if (trainersReportFilter.ToAge.HasValue && trainersReportFilter.ToAge.Value >= 0)
            {
                ServiceRep = ServiceRep.Where(com => com.student.Age <= trainersReportFilter.ToAge.Value);
            }


            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "Fullname");







            return View();
        }

        public IActionResult SecTrainersReport(SecTrainersReportFilter secTrainersReportFilter)
        {
            //Get Session Reservation with filters
            var ServiceRep = _context.SessionReservation.Include(s => s.student).Include(s => s.trainer).Include(s => s.coursePrice).ThenInclude(s => s.branch).Where(s => s.SessionDateTime >= secTrainersReportFilter.FromDate && s.SessionDateTime <= secTrainersReportFilter.ToDate);
        
            if (!string.IsNullOrWhiteSpace(secTrainersReportFilter.BranchID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.coursePrice.BranchId == secTrainersReportFilter.BranchID);
            }
            if (!string.IsNullOrWhiteSpace(secTrainersReportFilter.TrainerID.ToString()))
            {
                ServiceRep = ServiceRep.Where(sc => sc.TrainerId == secTrainersReportFilter.TrainerID);
            }
     


            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "Fullname");







            return View();
        }


    }
}
