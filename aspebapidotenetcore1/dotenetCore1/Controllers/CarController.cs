using dotenetCore1.Context;
using dotenetCore1.Model;
using Microsoft.AspNetCore.Mvc;


namespace dotenetCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarContext context;

        public CarController(CarContext context) 
        {
            this.context = context;
        }


        
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return Ok(context.Cars.ToList());
        }

   
        [HttpGet("{id}")]
        public ActionResult<Car> GetById(int id)
        {
            var car = context.Cars.FirstOrDefault(car => car.Id == id);
            return Ok(car);
        }

        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Car updatedCar)
        {
            var carToUpdate = context.Cars.FirstOrDefault(car => car.Id == id);

            if(carToUpdate == null) 
            {
                return NotFound();
            }

            carToUpdate.Model = updatedCar.Model;
            carToUpdate.Brand = updatedCar.Brand;
            carToUpdate.Year = updatedCar.Year;

            context.SaveChanges();

            return NoContent();

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var carToRemove = context.Cars.FirstOrDefault(car => car.Id == id);

            if (carToRemove == null)
            {
                return NotFound();
            }

            context.Cars.Remove(carToRemove);
            context.SaveChanges();

            return NoContent();
        }
    }
}
