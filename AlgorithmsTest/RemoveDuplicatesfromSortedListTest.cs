using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedListTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode head, ListNode output)
        {
            Assert.Equal(output, Solution083.DeleteDuplicates(head));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                ListNode head = new ListNode(1);
                head.next = new ListNode(1);
                head.next.next = new ListNode(2);
                
                ListNode output = new ListNode(1);
                output.next = new ListNode(2);
                driverData.Add(new object[] { head, output });
                
                return driverData;
            }
        } 
    }
}

