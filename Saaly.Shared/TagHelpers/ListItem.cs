namespace Saaly.Shared.TagHelpers;

public class ListItem
{
    public string? ClassName { get; set; } = "breadcrumb-item";
    public string? LinkClass{ get; set; } = "link-fx";
    public string? AriaCurrent { get; set; } = "page";
    public bool HasAriaCurrent { get; set; }
    public bool HasLink { get; set; }
    public string? Label { get; set; }
    public string? Url { get; set; }
    public int Order { get; set; }
}