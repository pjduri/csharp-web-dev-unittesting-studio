namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.
    // POSITIVE CASE TESTS
    [TestMethod]
    public void EmptyStringReturnsTrue()
    {
        string message = "'' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets(""), message);
    }

    [TestMethod]
    public void OnlyBracketsReturnsTrue()
    {
        string message = "'[]' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[]"), message);
    }

    [TestMethod]
    public void BracketsAroundStringReturnsTrue()
    {
        string message = "'[LaunchCode]' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"), message);
    }

    [TestMethod]
    public void BracketsBeforeStringReturnsTrue()
    {
        string message = "'[]LaunchCode' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"), message);
    }

    [TestMethod]
    public void ThreeSetsBracketsReturnsTrue()
    {
        string message = "'[][][]' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"), message);
    }

    [TestMethod]
    public void NestedBracketsReturnsTrue()
    {
        string message = "'[[]]' should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"), message);
    }

    [TestMethod]
    public void NestedBracketsWithinStringReturnsTrue()
    {
        string message = "'[L[a[un]c[hCo]de]]' should return true";
        string testString = "[L[a[un]c[hCo]de]]";
        IsTrue(BalancedBrackets.HasBalancedBrackets(testString), message);
    }

    // NEGATIVE CASE TESTS
    [TestMethod]
    public void OnlyOneBracketReturnsFalse()
    {
        string message = "'[' and ']' should both return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("["), message);
        IsFalse(BalancedBrackets.HasBalancedBrackets("]"), message);
    }

    [TestMethod]
    public void MoreOfOneBracketReturnsFalse()
    {
        string message = "'[[]' and '[]]' should both return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"), message);
        IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"), message);
    }
    
    [TestMethod]
    public void ClosingBracketFirstReturnsFalse()
    {
        string message = "'][' should return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("]["), message);
    }

    [TestMethod]
    public void MisNestedBracketsReturnsFalse()
    {
        string message = "'[]][[]' should return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[]][[]"), message);
    }

    [TestMethod]
    public void MisNestedBracketsInStringReturnsFalse()
    {
        string message = "'[L]au]nch[co[d]e' should return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[L]au]nch[co[d]e"), message);
    }
}
