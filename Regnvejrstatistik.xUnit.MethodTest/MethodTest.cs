namespace Regnvejrstatistik.xUnit.MethodTest
{
    public class MethodTest
    {
        [Fact]
        public void UdskrivMaxVærdiTest()
        {
            //Arrange
            double[] array = new double[5] { 6.7, 16.2, 15.1, 19.9, 11.3 };
            string værdi = ($"Max værdi: {array.Max():F2} mm");

            //Act
            

            //Assert
            Assert.Equal();
        }

    }
}