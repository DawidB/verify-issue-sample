using FluentAssertions;

namespace TestProject1;

public class StringExtensionsTests
{
    public StringExtensionsTests()
    {
        UseProjectRelativeDirectory("Snapshots");
    }
    
    [Fact]
    public Task Test1()
    {
        //Arrange
        const string input = """
Here's a JSON array of strings containing three alternative prompts based on the given story content:

```json
[
"Lorem ipsum dolor sit amet amet ut. Sanctus ea dolore possim duo lorem eos wisi aliquyam feugait tempor nonumy gubergren cum in sadipscing facilisi diam duo. Vel consetetur iriure voluptua consequat dolor clita quis. Justo sed kasd et justo stet nam dolores praesent qui amet consetetur est eos facer eirmod. Ea velit eum erat erat quod sea duo gubergren feugiat congue duo justo diam eum. Dolor at enim sed sadipscing sea justo consetetur minim et takimata dolores rebum minim accusam elit. Kasd autem dolor congue euismod et eos dolore delenit assum stet et sanctus dolore ipsum et dolor. Ea feugiat invidunt magna ea elitr justo commodo voluptua.",
"Clita eos voluptua sit eum labore sea amet sit est justo eos mazim lorem at odio. Assum no esse dolore sed consetetur sanctus cum at erat. Justo ut dolore sed dolores sanctus et. Aliquip nonumy et erat hendrerit aliquip eu tation vel diam lorem possim et sea congue stet. Magna stet dignissim. Justo vero ut facilisis voluptua amet suscipit ut justo dolor elitr nulla dolor. Rebum aliquyam erat invidunt sadipscing diam amet kasd elitr. Et ut labore ipsum sit elitr. Dolor vero sed dolores nonumy. Est sit elitr dolor sanctus lorem rebum ipsum dolore. Nibh sanctus duo ea sed est consectetuer dolore consetetur veniam. Velit takimata tation consetetur nostrud sit kasd eu dolor erat sit sit ut erat te. Sea lorem est dolor no sit rebum erat labore vero sea ea lorem dolor no duo erat.",
"Diam et ea ut sea rebum kasd takimata. Labore sed gubergren sed stet no takimata dolor blandit amet justo magna. Labore invidunt dolore diam. Dolor ea et kasd kasd adipiscing eirmod delenit eirmod et amet enim nostrud. Sanctus duis placerat amet erat dolor sed et nonumy."
]
```
""";

        //Act
        string jsonContent = input.TryExtractJson();
        string[] strings = jsonContent.ToArray();
        
        //Assert
        strings.Should().HaveCount(3);
        return Verify(jsonContent);
    }
    
    [Fact]
    public Task Test2()
    {
        //Arrange
        const string input = """
[
    "Lorem ipsum dolor sit amet amet ut. Sanctus ea dolore possim duo lorem eos wisi aliquyam feugait tempor nonumy gubergren cum in sadipscing facilisi diam duo. Vel consetetur iriure voluptua consequat dolor clita quis. Justo sed kasd et justo stet nam dolores praesent qui amet consetetur est eos facer eirmod. Ea velit eum erat erat quod sea duo gubergren feugiat congue duo justo diam eum. Dolor at enim sed sadipscing sea justo consetetur minim et takimata dolores rebum minim accusam elit. Kasd autem dolor congue euismod et eos dolore delenit assum stet et sanctus dolore ipsum et dolor. Ea feugiat invidunt magna ea elitr justo commodo voluptua.",
    "Clita eos voluptua sit eum labore sea amet sit est justo eos mazim lorem at odio. Assum no esse dolore sed consetetur sanctus cum at erat. Justo ut dolore sed dolores sanctus et. Aliquip nonumy et erat hendrerit aliquip eu tation vel diam lorem possim et sea congue stet. Magna stet dignissim. Justo vero ut facilisis voluptua amet suscipit ut justo dolor elitr nulla dolor. Rebum aliquyam erat invidunt sadipscing diam amet kasd elitr. Et ut labore ipsum sit elitr. Dolor vero sed dolores nonumy. Est sit elitr dolor sanctus lorem rebum ipsum dolore. Nibh sanctus duo ea sed est consectetuer dolore consetetur veniam. Velit takimata tation consetetur nostrud sit kasd eu dolor erat sit sit ut erat te. Sea lorem est dolor no sit rebum erat labore vero sea ea lorem dolor no duo erat.",
    "Diam et ea ut sea rebum kasd takimata. Labore sed gubergren sed stet no takimata dolor blandit amet justo magna. Labore invidunt dolore diam. Dolor ea et kasd kasd adipiscing eirmod delenit eirmod et amet enim nostrud. Sanctus duis placerat amet erat dolor sed et nonumy."
]
""";

        //Act
        string jsonContent = input.TryExtractJson();
        string[] strings = jsonContent.ToArray();
        
        //Assert
        strings.Should().HaveCount(3);
        return Verify(jsonContent);
    }
}