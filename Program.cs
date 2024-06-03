using System.Xml;

XmlDocument doc = new XmlDocument();
doc.Load("/dev/Polygon/testfile.xml");
XmlElement? root = doc.DocumentElement;
if (root != null)
{
    foreach (XmlElement node in root)
    {
        Console.WriteLine(node.Name);
        Console.WriteLine(node.InnerText);
        Console.WriteLine(node.LocalName);
        Console.WriteLine(node.ParentNode);
        Console.WriteLine(node.Prefix);
    }
}