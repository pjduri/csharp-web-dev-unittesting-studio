namespace BalancedBracketsTests;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    // POSITIVE CASES
    // 1 test empty string - ""

    // 2 test solitary balanced brackets - []

    // 3 test string wrapped in brackets 
        // - [LaunchCode]

    // 4 test multiple empty balanced - [][][]

    // 5 test balanced outside string - 
        // []LaunchCode, LaunchCode[], 
        // and []LaunchCode[]

    // 6 test nested brackets - [[[]]]

    // 7 test nested brackets in string 
        // - [L[au[nch]Co]d]e
    
    // NEGATIVE CASES
    // 8 test more of one type of bracket
        // [[] and []]
    
    // 9 test only one type [ and ]

    // 10 test closer first - ][

    // 11 test misnested multiples [[[]]]][

    // 12 test misnested in string 
        // [La[unch[Co]d]]]e[
}
