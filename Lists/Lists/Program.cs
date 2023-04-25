// Lists

using Lists;

List<Part> lst = new List<Part>();

lst.Add(new Part {  PartName = "Headlight", PartId = 1 });
lst.Add(new Part { PartName = "Bumper", PartId = 2 });

foreach (Part part in lst)
{
    Console.WriteLine(part.PartName.ToString());
    Console.WriteLine(part.PartId.ToString());
}