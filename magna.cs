// Define the LinkItem class
public class LinkItem
{
    public string Href { get; set; }
    public string Text { get; set; }

    // Add any additional properties or methods you need
}

// Initialize a new list of LinkItem objects
List<LinkItem> list = new List<LinkItem>();

// Add items to the list
list.Add(new LinkItem { Href = "http://example.com", Text = "Example" });
list.Add(new LinkItem { Href = "http://anotherexample.com", Text = "Another Example" });

// Iterate over the list and print details
foreach (var linkItem in list)
{
    Console.WriteLine($"Href: {linkItem.Href}, Text: {linkItem.Text}");
}
