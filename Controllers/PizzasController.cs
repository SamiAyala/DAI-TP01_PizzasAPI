using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
using Pizzas.API.Utils;

namespace Pizzas.Controllers;

[ApiController]
[Route("[Controller]")]
public class PizzasController : ControllerBase
{
    private readonly ILogger<PizzasController> _logger;

    public PizzasController(ILogger<PizzasController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        List<Pizza> listaPizzas;
        IActionResult respuesta;
        listaPizzas = BD.GetAll();
        respuesta = Ok(listaPizzas);
        return respuesta;
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Pizza pedido = BD.GetById(id);
        IActionResult respuesta;
        if (id <= 0)
        {
            respuesta = BadRequest();
        }
        else if (pedido == null)
        {
            respuesta = NotFound();
        }
        else
        {
            respuesta = Ok(pedido);
        }
        return respuesta;
    }
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        int cantCambios;

        cantCambios = BD.CreatePizza(pizza);

        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {

        IActionResult respuesta = null;
        Pizza pizzaObjetivo;
        int cantCambios;

        if (id != pizza.Id)
        {
            respuesta = BadRequest();
        }
        else
        {
            pizzaObjetivo = BD.GetById(id);
            if (pizzaObjetivo == null)
            {
                respuesta = NotFound();
            }
            else
            {
                cantCambios = BD.UpdateById(pizza);
                if (cantCambios > 0)
                {
                    respuesta = Ok(pizza);
                }
                else
                {
                    respuesta = NotFound();
                }
            }
        }
        return respuesta;
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
        IActionResult respuesta = null;
        Pizza pizzaObjetivo;
        int cantCambios;

        if (id <=0)
        {
            respuesta = BadRequest();
        }
        else
        {
            pizzaObjetivo = BD.GetById(id);
            if (pizzaObjetivo == null)
            {
                respuesta = NotFound();
            }
            else
            {
                cantCambios = BD.DeleteById(id);
                if (cantCambios > 0)
                {
                    respuesta = Ok(pizzaObjetivo);
                }
                else
                {
                    respuesta = NotFound();
                }
            }
        }
        return respuesta;
    }

}
