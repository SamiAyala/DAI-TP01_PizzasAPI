using Pizzas.API.Models;

namespace Pizzas.API.Controllers {

[ApiController]

[Route("api/[controller]")]

public class PizzasController : ControllerBase {

[HttpGet]
public IActionResult GetAll() {
    List<Pizza> listaPizzas;
    listaPizzas = GetAll();
    return listaPizzas;
}

[HttpGet("{id}")]

public IActionResult GetById(int id) {
    Pizza pedido;
}

[HttpPost]

public IActionResult Create(Pizza pizza) {}

[HttpPut("{id}")]

public IActionResult Update(int id, Pizza pizza) {}

[HttpDelete("{id}")]

public IActionResult DeleteById(int id) {}

}
[HttpGet("{id}")]

public IActionResult GetById(int id) {

IActionResult respuesta = null;

Pizza entity;

entity = BD.GetById(id);

if (entity == null) {

respuesta = NotFound();

} else {

respuesta = Ok(entity);

}

return respuesta;

}
[HttpPost]

public IActionResult Create(Pizza pizza) {

int
intRowsAffected;

intRowsAffected = BD.Insert(pizza);

return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);

}
[HttpPut("{id}")]

public IActionResult Update(int id, Pizza pizza) {

IActionResult respuesta = null;

Pizza entity;

int intRowsAffected;

if (id != pizza.Id) {

respuesta = BadRequest();

} else {

entity = BD.GetById(id);

if (entity == null){

respuesta = NotFound();

} else {

intRowsAffected = BD.UpdateById(pizza);

if (intRowsAffected > 0){

respuesta = Ok(pizza);

} else {

respuesta = NotFound();

}

}

}

return respuesta;

}
[HttpDelete("{id}")]

public IActionResult DeleteById(int id) {

IActionResult respuesta = null;

Pizza entity;

int intRowsAffected;

entity = BD.GetById(id);

if (entity == null){

respuesta = NotFound();

} else {

intRowsAffected = BD.DeleteById(pizza);

if (intRowsAffected > 0){

respuesta = Ok(entity);

} else {

respuesta = NotFound();

}

}

return respuesta;

}

}