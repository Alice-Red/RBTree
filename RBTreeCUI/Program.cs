using System;
using RUtil.Collections;


namespace RBTreeCUI
{
    class Program
    {
        static void Main(string[] args) {
            BTree<int, string> rbt = new BTree<int, string>() {
                { 601, "600ばん" },
                { 805, "804ばん" },
                { 985, "985ばん" },
                { 551, "551ばん" },
                { 488, "487ばん" },
                { 638, "637ばん" },
                {  63, "63ばん" },
                {  76, "76ばん" },
                { 825, "825ばん" },
                { 189, "189ばん" },
                { 255, "255ばん" },
                {  11, "11ばん" },
                { 564, "563ばん" },
                { 639, "639ばん" },
                { 154, "153ばん" },
                { 285, "285ばん" },
                { 502, "502ばん" },
                { 400, "399ばん" },
                { 245, "245ばん" },
                { 127, "126ばん" },
                { 688, "688ばん" },
                { 925, "924ばん" },
                { 524, "523ばん" },
                { 965, "964ばん" },
                { 569, "569ばん" }
            };

            foreach(var item in rbt) {
                Console.WriteLine(item);
            }



            
            Console.ReadKey();

        }
    }
}
