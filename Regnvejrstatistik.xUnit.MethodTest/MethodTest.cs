namespace Regnvejrstatistik.xUnit.MethodTest
{
    public class MethodTest
    {
        [Fact]
        public void UdskrivMaxV�rdiTest()
        {
            //Arrange
            double[] array = new double[5] { 6.7, 16.2, 15.1, 19.9, 11.3 };
            string v�rdi = ($"Max v�rdi: {array.Max():F2} mm");

            //Act
            

            //Assert
            Assert.Equal();
        }

    }
}