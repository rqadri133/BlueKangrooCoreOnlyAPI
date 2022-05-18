using System;
using Xunit;
using BlueKangrooCoreOnlyAPI.Repository;
using Moq;
using BlueKangrooCoreOnlyAPI.Models;
namespace BlueKangrooServiceTest
{
    public class AcitivityRepositoryTest
    {
        Mock<IActivityRepository> repository = null;
       

        AcitivityRepositoryTest()
        {
            repository = new Mock<IActivityRepository>();
            

        }
       
        [Fact]
        public void AddActivityTest()
        {
            AppActivity activty = new AppActivity();
              
              //  repository.SetupAdd()

        }
    }
}
