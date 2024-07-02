using AutoMapper;
using BookVaultAPI.Data.UnitOfWork;
using BookVaultAPI.Entities;
using BookVaultAPI.Services;
using Castle.Core.Configuration;
using Moq;
using Xunit;

namespace BookVaultAPI.Tests
{
    public class UserServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly IUserService _userService;

        public UserServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _configurationMock = new Mock<IConfiguration>(); 
        }

        [Fact]
        public async Task RegisterUserAsync_ShouldRegisterUser()
        {
            // Arrange
             
        }

        [Fact]
        public async Task LoginUserAsync_ShouldReturnUserDto()
        {
     
        }
    }
}
