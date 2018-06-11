using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using FakeItEasy;
using RachelSoderberg_Lab2.Data.Entities;
using RachelSoderberg_Lab2.Models;
using RachelSoderberg_Lab2.Repositories;
using RachelSoderberg_Lab2.Services;

namespace RachelSoderberg_Lab2
{
    [TestFixture]
    public class EntitiesServiceTests
    {
        private IEntitiesRepository _entitiesRepository;

        [SetUp]
        public void SetUp()
        {
            _entitiesRepository = A.Fake<IEntitiesRepository>();
        }

        [Test]
        public void SalaryAtOneYear()
        {
            A.CallTo(() => _entitiesRepository.GetJob(A<int>.Ignored)).Returns(new Job
            {
                //TotalIncome = Year * Salary;
            });
        }

        public void SalaryAtTwoYears()
        {
            A.CallTo(() => _entitiesRepository.GetJob(A<int>.Ignored)).Returns(new Job
            {
                //TotalIncome = Year * Salary;
            });
        }
    }
}