// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LeetCodeProblems.LeetCode_150;

//LeetCode_23_Easy.Test();

using DSA.Trees;

namespace Trees
{
    public static class Program
    {
        public static void Main()
        {
            int selectedSubOptionInt = -1;

            do
            {
                Console.WriteLine("\nSupported sub-options in LeetCodeProblems:");
                Console.WriteLine("1. Merge");
                Console.WriteLine("2. RemoveElement");
                Console.WriteLine("3. RemoveDuplicates");
                Console.WriteLine("4. MajorityElement");
                Console.WriteLine("5. MaxProfit");
                Console.WriteLine("6. RomanToInt");
                Console.WriteLine("7. LengthOfLastWord");
                Console.WriteLine("8. LongestCommonPrefix");
                Console.WriteLine("9. StrStr");
                Console.WriteLine("10. IsPalindrome");
                Console.WriteLine("11. IsSubsequence");
                Console.WriteLine("12. CanConstruct");
                Console.WriteLine("13. IsIsomorphic");
                Console.WriteLine("14. WordPattern");
                Console.WriteLine("15. IsAnagram");
                Console.WriteLine("16. TwoSum");
                Console.WriteLine("17. getNextNo");
                Console.WriteLine("18. ContainsNearbyDuplicate");
                Console.WriteLine("19. SummaryRanges");
                Console.WriteLine("20. IsValid");
                Console.WriteLine("21. HasCycle");
                Console.WriteLine("22. MergeTwoLists");

                Console.WriteLine("23. MaxDepth");
                Console.WriteLine("24. IsSameTree");
                Console.WriteLine("25. InvertTree");
                Console.WriteLine("26. IsSymmetric");
                Console.WriteLine("27. PathSum");
                Console.WriteLine("28. CountNodes");
                Console.WriteLine("29. AverageOfLevels");
                Console.WriteLine("30. GetMinimumDifference");
                Console.WriteLine("31. SortedArrayToBST");
                Console.WriteLine("32. SearchInsert");
                Console.WriteLine("33. AddBinary");
                Console.WriteLine("34. ReverseBits");
                Console.WriteLine("35. HammingWeight");
                Console.WriteLine("36. SingleNumber");
                Console.WriteLine("37. IsPalindrome");
                Console.WriteLine("38. PlusOne");
                Console.WriteLine("39. MySqrt");
                Console.WriteLine("40. ClimbStairs");

                Console.WriteLine("41. RemoveDuplicates");
                Console.WriteLine("42. Rotate");
                Console.WriteLine("43. MaxProfit");
                Console.WriteLine("44. CanJump");
                Console.WriteLine("45. Jump");
                Console.WriteLine("46. H-Index");
                Console.WriteLine("47. RandomizedSet");
                Console.WriteLine("48. ProductExceptSelf");
                Console.WriteLine("49. --");
                Console.WriteLine("50. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");
                Console.WriteLine("5. --");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option from above LeetCode problem: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                Console.WriteLine("Selected sub-option: " + selectedSubOptionInt.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOptionInt)
                {
                    case 1: LeetCode_01_Easy.Merge(); break;
                    case 2: LeetCode_02_Easy.RemoveElement(); break;
                    case 3: LeetCode_03_Easy.RemoveDuplicates(); break;
                    case 4: LeetCode_04_Easy.MajorityElement(); break;
                    case 5: LeetCode_05_Easy.MaxProfit(); break;
                    case 6: LeetCode_06_Easy.RomanToInt(); break;
                    case 7: LeetCode_07_Easy.LengthOfLastWord(); break;
                    case 8: LeetCode_08_Easy.LongestCommonPrefix(); break;
                    case 9: LeetCode_09_Easy.StrStr(); break;
                    case 10: LeetCode_10_Easy.IsPalindrome(); break;
                    case 11: LeetCode_11_Easy.IsSubsequence(); break;
                    case 12: LeetCode_12_Easy.CanConstruct(); break;
                    case 13: LeetCode_13_Easy.IsIsomorphic(); break;
                    case 14: LeetCode_14_Easy.WordPattern(); break;
                    case 15: LeetCode_15_Easy.IsAnagram(); break;
                    case 16: LeetCode_16_Easy.TwoSum(); break;
                    case 17: LeetCode_17_Easy.getNextNo(); break;
                    case 18: LeetCode_18_Easy.ContainsNearbyDuplicate(); break;
                    case 19: LeetCode_19_Easy.SummaryRanges(); break;
                    case 20: LeetCode_20_Easy.IsValid(); break;
                    case 21: LeetCode_21_Easy.HasCycle(); break;
                    case 22: LeetCode_22_Easy.MergeTwoLists(); break;

                    case 23: LeetCode_23_Easy.MaxDepth(); break;
                    case 24: LeetCode_24_Easy.IsSameTree(); break;
                    case 25: LeetCode_25_Easy.InvertTree(); break;
                    case 26: LeetCode_26_Easy.IsSymmetric(); break;
                    case 27: LeetCode_27_Easy.HasPathSum(); break;
                    case 28: LeetCode_28_Easy.CountNodes(); break;
                    case 29: LeetCode_29_Easy.AverageOfLevels(); break;
                    case 30: LeetCode_30_Easy.GetMinimumDifference(); break;
                    case 31: LeetCode_31_Easy.SortedArrayToBST(); break;
                    case 32: LeetCode_32_Easy.SearchInsert(); break;
                    case 33: LeetCode_33_Easy.AddBinary(); break;
                    case 34: LeetCode_34_Easy.ReverseBits(); break;
                    case 35: LeetCode_35_Easy.HammingWeight(); break;
                    case 36: LeetCode_36_Easy.SingleNumber (); break;
                    case 37: LeetCode_37_Easy.IsPalindrome(); break;
                    case 38: LeetCode_38_Easy.PlusOne(); break;
                    case 39: LeetCode_39_Easy.MySqrt(); break;
                    case 40: LeetCode_40_Easy.ClimbStairs(); break;

                    case 41: LeetCode_41_Medium.RemoveDuplicates(); break;
                    case 42: LeetCode_42_Medium.RemoveElement(); break;
                    case 43: LeetCode_43_Medium.MaxProfit(); break;
                    case 44: LeetCode_44_Medium.CanJump(); break;
                    case 45: LeetCode_45_Medium.Jump(); break;
                    case 46: LeetCode_46_Medium.HIndex(); break;
                    case 47: LeetCode_47_Medium.RandomizedSet(); break;
                    case 48: LeetCode_48_Medium.ProductExceptSelf(); break;
                    //case 49: LeetCode_49_Medium.(); break;

                    //case 50: LeetCode_50_Medium.(); break;
                    //case 51: LeetCode_51_Medium.(); break;
                    //case 52: LeetCode_52_Medium.(); break;
                    //case 53: LeetCode_53_Medium.(); break;
                    //case 54: LeetCode_54_Medium.(); break;
                    //case 55: LeetCode_55_Medium.(); break;
                    //case 56: LeetCode_56_Medium.(); break;
                    //case 57: LeetCode_57_Medium.(); break;
                    //case 58: LeetCode_58_Medium.(); break;
                    //case 59: LeetCode_59_Medium.(); break;
                    //case 60: LeetCode_60_Medium.(); break;
                    
                    //case 61: LeetCode__Medium.(); break;
                    //case 62: LeetCode__Medium.(); break;
                    //case 63: LeetCode__Medium.(); break;
                    //case 64: LeetCode__Medium.(); break;
                    //case 65: LeetCode__Medium.(); break;
                    //case 66: LeetCode__Medium.(); break;
                    //case 67: LeetCode__Medium.(); break;
                    //case 68: LeetCode__Medium.(); break;
                    //case 69: LeetCode__Medium.(); break;
                    //case 70: LeetCode__Medium.(); break;
                    //case 71: LeetCode__Medium.(); break;
                    //case 72: LeetCode__Medium.(); break;
                    //case 73: LeetCode__Medium.(); break;
                    //case 74: LeetCode__Medium.(); break;
                    //case 75: LeetCode__Medium.(); break;
                    //case 76: LeetCode__Medium.(); break;
                    //case 77: LeetCode__Medium.(); break;
                    //case 78: LeetCode__Medium.(); break;
                    //case 79: LeetCode__Medium.(); break;
                    //case 80: LeetCode__Medium.(); break;

                    //case 81: LeetCode__Medium.(); break;
                    //case 82: LeetCode__Medium.(); break;
                    //case 83: LeetCode__Medium.(); break;
                    //case 84: LeetCode__Medium.(); break;
                    //case 85: LeetCode__Medium.(); break;
                    //case 86: LeetCode__Medium.(); break;
                    //case 87: LeetCode__Medium.(); break;
                    //case 88: LeetCode__Medium.(); break;
                    //case 89: LeetCode__Medium.(); break;
                    //case 90: LeetCode__Medium.(); break;
                    //case 91: LeetCode__Medium.(); break;
                    //case 92: LeetCode__Medium.(); break;
                    //case 93: LeetCode__Medium.(); break;
                    //case 94: LeetCode__Medium.(); break;
                    //case 95: LeetCode__Medium.(); break;
                    //case 96: LeetCode__Medium.(); break;
                    //case 97: LeetCode__Medium.(); break;
                    //case 98: LeetCode__Medium.(); break;
                    //case 99: LeetCode__Medium.(); break;                   
                    //case 100: LeetCode__Medium.(); break;

                    //case 101: LeetCode__Medium.(); break;
                    //case 102: LeetCode__Medium.(); break;
                    //case 103: LeetCode__Medium.(); break;
                    //case 104: LeetCode__Medium.(); break;
                    //case 105: LeetCode__Medium.(); break;
                    //case 106: LeetCode__Medium.(); break;
                    //case 107: LeetCode__Medium.(); break;
                    //case 108: LeetCode__Medium.(); break;
                    //case 109: LeetCode__Medium.(); break;
                    //case 110: LeetCode__Medium.(); break;

                    //case 111: LeetCode__Medium.(); break;
                    //case 112: LeetCode__Medium.(); break;
                    //case 113: LeetCode__Medium.(); break;
                    //case 114: LeetCode__Medium.(); break;
                    //case 115: LeetCode__Medium.(); break;
                    //case 116: LeetCode__Medium.(); break;
                    //case 117: LeetCode__Medium.(); break;
                    //case 118: LeetCode__Medium.(); break;
                    //case 119: LeetCode__Medium.(); break;
                    //case 120: LeetCode__Medium.(); break;

                    //case 121: LeetCode__Medium.(); break;
                    //case 122: LeetCode__Medium.(); break;
                    //case 123: LeetCode__Medium.(); break;
                    //case 124: LeetCode__Medium.(); break;
                    //case 125: LeetCode__Medium.(); break;
                    //case 126: LeetCode__Medium.(); break;
                    //case 127: LeetCode__Medium.(); break;
                    //case 128: LeetCode__Medium.(); break;
                    //case 129: LeetCode__Medium.(); break;
                    //case 130: LeetCode__Medium.(); break;

                    //case 131: LeetCode__Medium.(); break;
                    //case 132: LeetCode__Medium.(); break;
                    //case 133: LeetCode__Medium.(); break;
                    //case 134: LeetCode__Medium.(); break;
                    //case 135: LeetCode__Medium.(); break;


                    case 0:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOptionInt != 0);
        }
    }
}

