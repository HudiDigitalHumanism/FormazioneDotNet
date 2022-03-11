namespace ConsoleApp1;

public class ToDo
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public int? Age { get; set; }

    public Child Component { get; set; } = null!;
}

public class Child
{
    public string? Phone { get; set; }
}


public class UsingToDo
{
    private readonly ToDo prova = new();
    public void Prova()
    {
        AccettoToDo(prova);
    }

    public void AccettoToDo(ToDo to)
    {
        var a = 0;
        if (to.Name.ToString() == "A")
        {
            a++;
        }

        if (to.Description.ToString() == "A")
        {
        }

        //to.C = null!;


        //to.C.Phone = "A";


        int result = (to?.Age) ?? 0;
    }
}
