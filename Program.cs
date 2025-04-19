// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = {2, 7, 11, 15};
int target = 9;

TwoSumProblem problem = new TwoSumProblem(nums, target);
int[] result = problem.findTwoSum();

Console.WriteLine($"Indices: {result[0]}, {result[1]}");

Console.ReadLine();