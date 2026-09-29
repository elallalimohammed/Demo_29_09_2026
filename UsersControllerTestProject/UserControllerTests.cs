
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System.Timers;
    using UsersWebApi_Module3WithMoq.Controllers;
    using UsersWebApi_Module3WithMoq.Models;

namespace UsersTestProject
{
    [TestClass]
    public sealed class UsersControllerTests
    {
        private Mock<IUserRepository> _mockRepository;
        private UsersController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockRepository = new Mock<IUserRepository>();

            _controller = new UsersController(_mockRepository.Object);
        }

        // start test cases

    }
}