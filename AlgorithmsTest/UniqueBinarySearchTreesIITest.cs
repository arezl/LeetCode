using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class UniqueBinarySearchTreesIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, IList<TreeNode> output)
        {
            Assert.Equal(output, Solution095.GenerateTrees(n));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var nums = 3;

                var output = new List<TreeNode>();
                var root = new TreeNode(1);
                root.Right = new TreeNode(3);
                root.Right.Left = new TreeNode(2);
                output.Add(root);
                root = new TreeNode(3);
                root.Left = new TreeNode(2);
                root.Left.Left = new TreeNode(1);
                output.Add(root);
                root = new TreeNode(3);
                root.Left = new TreeNode(1);
                root.Left.Right = new TreeNode(2);
                output.Add(root);
                root = new TreeNode(2);
                root.Right = new TreeNode(3);
                root.Left = new TreeNode(1);
                output.Add(root);
                root = new TreeNode(1);
                root.Right = new TreeNode(2);
                root.Right.Right = new TreeNode(3);
                output.Add(root);
                driverData.Add(new object[] { nums,  output });
                
                return driverData;
            }
        }  
    }
}

