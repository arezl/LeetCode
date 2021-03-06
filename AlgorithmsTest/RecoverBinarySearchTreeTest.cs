using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RecoverBinarySearchTreeTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root)
        {
            Solution099.RecoverTree(root);
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                TreeNode root = new TreeNode(2);
                root.Left = new TreeNode(2);
                root.Right = new TreeNode(2);
                root.Left.Left = new TreeNode(3);
                root.Left.Right = new TreeNode(4);
                
                
                driverData.Add(new object[] { root });
                
                return driverData;
            }
        }  
    }
}

