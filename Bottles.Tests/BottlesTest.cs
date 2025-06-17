namespace Bottles.Tests;

[TestFixture]
public class BottlesTests
{
    private Bottles _bottles;

    [SetUp]
    public void SetUp()
    {
        _bottles = new Bottles();
    }

    [Test]
    public void TestVerse99()
    {
        var expected = "99 bottles of beer on the wall, " +
                       "99 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "98 bottles of beer on the wall.\n";
        Assert.That(_bottles.Verse(99), Is.EqualTo(expected));
    }

    [Test]
    public void TestVerse3()
    {
        var expected = "3 bottles of beer on the wall, " +
                       "3 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "2 bottles of beer on the wall.\n";
        Assert.That(_bottles.Verse(3), Is.EqualTo(expected));
    }

    [Test]
    public void TestVerse2()
    {
        var expected = "2 bottles of beer on the wall, " +
                       "2 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "1 bottle of beer on the wall.\n";
        Assert.That(_bottles.Verse(2), Is.EqualTo(expected));
    }

    [Test]
    public void TestVerse1()
    {
        var expected = "1 bottle of beer on the wall, " +
                       "1 bottle of beer.\n" +
                       "Take it down and pass it around, " +
                       "no more bottles of beer on the wall.\n";
        Assert.That(_bottles.Verse(1), Is.EqualTo(expected));
    }

    [Test]
    public void TestVerse0()
    {
        var expected = "No more bottles of beer on the wall, " +
                       "no more bottles of beer.\n" +
                       "Go to the store and buy some more, " +
                       "99 bottles of beer on the wall.\n";
        Assert.That(_bottles.Verse(0), Is.EqualTo(expected));
    }

    [Test]
    public void TestVerses()
    {
        var expected = "3 bottles of beer on the wall, " +
                       "3 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "2 bottles of beer on the wall.\n\n" +
                       "2 bottles of beer on the wall, " +
                       "2 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "1 bottle of beer on the wall.\n\n" +
                       "1 bottle of beer on the wall, " +
                       "1 bottle of beer.\n" +
                       "Take it down and pass it around, " +
                       "no more bottles of beer on the wall.\n";
        var actual = _bottles.Verses(3, 1);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestSong()
    {
        // This test just ensures the song method works
        // We don't test the full output as it's very long
        var song = _bottles.Song();
        Assert.That(song, Is.Not.Null);
        Assert.That(song, Does.StartWith("99 bottles of beer"));
        Assert.That(song, Does.EndWith("99 bottles of beer on the wall.\n"));
    }
}