using CodeWarsKatas.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public class SumTheTreeKata
    {
        public static int SumTree(Node root)
        {
            return root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);

            //if (root == null)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return root.Value + SumTree(root.Left) + SumTree(root.Right);
            //}
        }
    }
}
