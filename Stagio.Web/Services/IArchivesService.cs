﻿using System.Collections.Generic;
using Stagio.Domain.Entities;

namespace Stagio.Web.Services
{
    public interface IArchivesService
    {
        int GetStudentsCount();

        int GetStudentsWithInternshipCount();

        int GetInternshipApplicationsCount();

        int GetCompanyOffersCount();

        int GetInterviewsCount();

        int GetEmployeesCount();

        int GetCompaniesCount();

        int GetIntershipOffersCount();

        IEnumerable<InternshipPeriod> GetInternshipPeriodsList();
    }
}