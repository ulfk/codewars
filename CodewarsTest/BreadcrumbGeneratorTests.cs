using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class BreadcrumbGeneratorTests
{
    [DataTestMethod]
    [DataRow("mysite.com/pictures/holidays.html", " : ", "<a href=\"/\">HOME</a> : <a href=\"/pictures/\">PICTURES</a> : <span class=\"active\">HOLIDAYS</span>")]
    [DataRow("www.codewars.com/users/GiacomoSorbi", " / ", "<a href=\"/\">HOME</a> / <a href=\"/users/\">USERS</a> / <span class=\"active\">GIACOMOSORBI</span>")]
    [DataRow("www.microsoft.com/docs/index.htm", " * ", "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>")]
    [DataRow("www.microsoft.com/docs/index.htm?key=value", " * ", "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>")]
    [DataRow("www.microsoft.com/docs/index.htm#anchor", " * ", "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>")]
    [DataRow("www.microsoft.com", " * ", "<span class=\"active\">HOME</span>")]
    [DataRow("mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp"," > ","<a href=\"/\">HOME</a> > <a href=\"/very-long-url-to-make-a-silly-yet-meaningful-example/\">VLUMSYME</a> > <span class=\"active\">EXAMPLE</span>")]
    [DataRow("https://www.agcpartners.co.uk/index.html", " >>> ", "<span class=\"active\">HOME</span>")]
    [DataRow("https://www.agcpartners.co.uk/", " >>> ", "<span class=\"active\">HOME</span>")]
    public void BasicTests(string url, string separator, string expected)
    {
        BreadcrumbGenerator.GenerateBC(url, separator).Should().Be(expected);
    }
}