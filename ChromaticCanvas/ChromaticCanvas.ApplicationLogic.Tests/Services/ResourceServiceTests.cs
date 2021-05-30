using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using ChromaticCanvas.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromaticCanvas.ApplicationLogic.Tests.Services
{
    [TestClass]
    public class ResourceServiceTests
    {
        private Mock<IResourceRepository> resourceRepoMock = new Mock<IResourceRepository>();
        private Guid existingResourceGuid = Guid.NewGuid();

        [TestInitialize]
        public void InitializeTest()
        {
            var resource = new Resource
            {
                ID = existingResourceGuid
            };

            resourceRepoMock.Setup(resourceRepo => resourceRepo.GetResourceById(existingResourceGuid)).Returns(resource);
        }

        [TestMethod]
        public void GetResourceById_ThrowsException_WhenResourceIdHasInvalidValue()
        {
            var resourcesService = new ResourcesService(resourceRepoMock.Object);

            var badId = "ljkhgfgd fhjlikh jguygf";

            Assert.ThrowsException<Exception>(() =>
            {
                resourcesService.GetResourceById(badId);
            });
        }

        [TestMethod]
        public void GetResourceById_ThrowsEntityNotFound_WhenResourceDoesNotExist()
        {
            var nonExistingId = Guid.NewGuid();
            var resourcesService = new ResourcesService(resourceRepoMock.Object);

            Assert.ThrowsException<EntityNotFoundException>(() =>
            {
                resourcesService.GetResourceById(nonExistingId.ToString());
            });
        }

        [TestMethod]
        public void GetResourceById_Returns_ResourceWhenExists()
        {
            Exception throwException = null;
            var resourcesService = new ResourcesService(resourceRepoMock.Object);
            Resource resource= null;

            try
            {
                resource = resourcesService.GetResourceById(existingResourceGuid.ToString());
            }
            catch (Exception e)
            {
                throwException = e;
            }

            Assert.IsNull(throwException, $"Exception was thrown");
            Assert.IsNotNull(resource);
        }
    }
}
