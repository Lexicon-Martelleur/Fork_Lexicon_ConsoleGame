using Consoleg.ConsoleGame;
using Consoleg.ConsoleGame.Extensions;
using Microsoft.Extensions.Configuration;
using Moq;

namespace ConsoleGame.Tests
{
    public class MapTests
    {
        //[Fact]
        //public void Constructor_SetCorrectWidth_WithExtenion2()
        //{
        //    //Arrange
        //    const int expectedWidth = 10;

        //    var iconfigMock = new Mock<IConfiguration>();
        //    var getMapSizeMock = new Mock<IGetMapSizeFor>();

        //    getMapSizeMock.Setup(x => x.GetMapSizeFor(iconfigMock.Object, It.IsAny<string>())).Returns(expectedWidth);
        //    ConfigExtensions2.Implementation = getMapSizeMock.Object;

        //    //Act
        //    var map = new Map(iconfigMock.Object);

        //    //Assert
        //    Assert.Equal(expectedWidth, map.Width);
        //}

        //[Fact]
        //public void Constructor_SetCorrectWidth_WithExtenion3_Delegate()
        //{
        //    //Arrange
        //    const int expectedWidth = 10;

        //    var iconfigMock = new Mock<IConfiguration>();
        //    ConfigExtensions3.Implementation = (iconfig, key) => expectedWidth;

        //    //Act
        //    var map = new Map(iconfigMock.Object);

        //    //Assert
        //    Assert.Equal(expectedWidth, map.Width);
        //}

            
            [Fact]
        public void Constructor_SetCorrectWidth_With_IMapService()
        {
            //Arrange
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var mapServiceMock = new Mock<IMapService>();
            mapServiceMock.Setup(x => x.GetMap()).Returns((expectedWidth, expectedHeight));

            //Act
            var map = new Map(mapServiceMock.Object);

            //Assert
            Assert.Equal(expectedWidth, map.Width);

        }
    }
}