namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_message_when_speed_and_carname()
        {
            //given
            Car car = new Car("Cool Car", "oil");
            //when
            string message = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up to 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_speed_and_truckname()
        {
            //given
            Truck truck = new Truck("Big Truck", "ev");
            //when
            string message = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up to 10 km/h", message);
        }
    }
}
