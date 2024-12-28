public class Solution {
    public double Average(int[] salary) {
        int minimumSalary = salary[0];
        int maximumSalary = salary[0];
        int sumOfSalary = salary[0];
        int count = salary.Length;
        double averageSalary;

        for(int i=1; i<count;i++){
                if(salary[i]<minimumSalary){
                    minimumSalary=salary[i];
                }
                if(salary[i]>maximumSalary){
                    maximumSalary=salary[i];
                }
                sumOfSalary+=salary[i];
        }
        sumOfSalary=sumOfSalary-(minimumSalary+maximumSalary);

        averageSalary = (double)sumOfSalary/(count-2);
        averageSalary = Math.Round(averageSalary, 5);

        return averageSalary;
    }
}