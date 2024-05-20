namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.
    // POSITIVE CASE TESTS
    // "" should return true
    [TestMethod]
    public void EmptyStringReturnsTrue()
    {
        string message = "empty string should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets(""), message);
    }

    // "[]" should return true
    [TestMethod]
    public void OnlyBracketsReturnsTrue()
    {
        string message = "single set of balanced brackets returns true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[]"), message);
    }

    // '[LaunchCode]' should return true
    [TestMethod]
    public void BracketsAroundStringReturnsTrue()
    {
        string message = "balanced brackets around a string should return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"), message);
    }

    // "[]LaunchCode", "LaunchCode[]", and "[]LaunchCode[] return true
    [TestMethod]
    public void BracketsBeforeAndAfterStringReturnsTrue()
    {
        string message = "brackets before and/or after string returns true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"), message);
        IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode[]"), message);
        IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode[]"), message);
    }

    // [][][] returns true
    [TestMethod]
    public void ThreeSetsBracketsReturnsTrue()
    {
        string message = "multiple balanced pairs returns true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"), message);
    }

    // [[]] returns true
    [TestMethod]
    public void NestedBracketsReturnsTrue()
    {
        string message = "nested brackets return true";
        IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"), message);
    }

    // [L[a[un]c[hCo]de]] returns true
    [TestMethod]
    public void NestedBracketsWithinStringReturnsTrue()
    {
        string message = "nested brackets in string returns true";
        string testString = "[L[a[un]c[hCo]de]]";
        IsTrue(BalancedBrackets.HasBalancedBrackets(testString), message);
    }

    // NEGATIVE CASE TESTS
    // [ and ] alone should return false
    [TestMethod]
    public void OnlyOneBracketReturnsFalse()
    {
        string message = "single brackets should return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("["), message);
        IsFalse(BalancedBrackets.HasBalancedBrackets("]"), message);
    }

    // '[[]' and '[]]' should both return false
    [TestMethod]
    public void MoreOfOneBracketReturnsFalse()
    {
        string message = "more of one bracket type should return false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"), message);
        IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"), message);
    }
    
    // '][' should return false
    [TestMethod]
    public void WrongOrderBracketsReturnsFalse()
    {
        string message = "closing bracket before opening returns false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("]["), message);
    }

    // '[]][[]' should return false
    [TestMethod]
    public void MisNestedBracketsReturnsFalse()
    {
        string message = "any closing bracket before its opener returns false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[]][[]"), message);
    }

    // '[L]au]nch[co[d]e' should return false
    [TestMethod]
    public void MisNestedBracketsInStringReturnsFalse()
    {
        string message = "any closer before its opener in a string returns false";
        IsFalse(BalancedBrackets.HasBalancedBrackets("[L]au]nch[co[d]e"), message);
    }
}
