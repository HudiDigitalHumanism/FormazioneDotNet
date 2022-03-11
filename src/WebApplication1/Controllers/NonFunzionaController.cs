using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NonFunzionaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new ModelExt
        {
            Name = "Prova",
            Due = new List<ModelDue> { new ModelDue { Text = "Due" } },
            Tre = new List<ModelTre> { new ModelTre { Text = "Tre", Text2 = "Tre" } },
        });
    }
}


public class Model
{
    public string Name { get; set; }
    public List<ModelDue> Due { get; set; }
}

public class ModelDue
{
    public string Text { get; set; }
}

public class ModelTre : ModelDue
{
    public string Text2 { get; set; }
}

public class ModelExt : Model
{
    public List<ModelTre> Tre { get; set; }
}